using iTasks_ProjetoDA.Models;
using System;
using System.Windows.Forms;
using iTasks_ProjetoDA.Enums;
using System.Linq;

namespace iTasks_ProjetoDA
{
    public partial class KanbanForm : Form
    {
        private Utilizador utilizadorAtual;

        public KanbanForm(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            // Configura ListViews para exibir colunas em detalhes
            lvToDo.View = View.Details;
            lvDoing.View = View.Details;
            lvDone.View = View.Details;

            // Define colunas para cada ListView (ID e Descrição e ProgramadorID)
            lvToDo.Columns.Clear();
            lvToDo.Columns.Add("ID", 50);
            lvToDo.Columns.Add("Descrição", 200);
            lvToDo.Columns.Add("ProgID", 70);

            lvDoing.Columns.Clear();
            lvDoing.Columns.Add("ID", 50);
            lvDoing.Columns.Add("Descrição", 200);
            lvDoing.Columns.Add("ProgID", 70);

            lvDone.Columns.Clear();
            lvDone.Columns.Add("ID", 50);
            lvDone.Columns.Add("Descrição", 200);
            lvDone.Columns.Add("ProgID", 70);
            lvToDo.View = View.Details;
            lvDoing.View = View.Details;
            lvDone.View = View.Details;

            utilizadorAtual = utilizadorLogado;
            lblLoggedAs.Text = utilizadorAtual.Nome;

            lvToDo.MouseDoubleClick += Lista_MouseDoubleClick;
            lvDoing.MouseDoubleClick += Lista_MouseDoubleClick;
            lvDone.MouseDoubleClick += Lista_MouseDoubleClick;

            bool isGestor = utilizadorAtual is Gestor;
            tsGestaoUtilizadores.Visible = isGestor;
            tsCriarTiposTarefa.Visible = isGestor;
            tSCriarTarefas.Visible = isGestor;
            tsProjetos.Visible = isGestor;
            
            tsGestorTarefasTerminadas.Visible = isGestor;
            tsVerMinhasTarefasConcluidas.Visible = !isGestor;
            tsGestorTarefasTerminadas.Visible = isGestor;

            bool isProgramador = utilizadorAtual is Programador;

            // desactiva os botões de mover tarefa se não for Programador
            btnExecutar.Enabled = isProgramador;
            btnPorfazer.Enabled = isProgramador;
            btnTerminar.Enabled = isProgramador;





            CarregarListaProjetos();
            cBProjeto.SelectedIndexChanged += (s, e) => CarregarTarefas();
            CarregarTarefas();
        }


        private void CarregarListaProjetos()
        {
            using (var db = new iTasksContext())
            {
                cBProjeto.DataSource = db.Projetos.ToList();
                cBProjeto.DisplayMember = "Descricao";
                cBProjeto.ValueMember = "Id";
                if (cBProjeto.Items.Count > 0) 
                {
                    cBProjeto.SelectedIndex = 0;
                }



            }
        }
        private void FiltrarTarefasPorProjeto() 
        {
            
        }



        private void Lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var lv = (ListView)sender;
            if (lv.SelectedItems.Count == 0) return;

            if (!int.TryParse(lv.SelectedItems[0].SubItems[0].Text, out int idTarefa))
                return;

            Tarefa tarefa;
            using (var db = new iTasksContext())
            {
                tarefa = db.Tarefas
                           .Include("Programador")
                           .Include("Gestor")
                           .Include("TipoTarefa")
                           .FirstOrDefault(t => t.Id == idTarefa);
            }
            if (tarefa == null) return;

            // 1) Programador só pode ver AS SUAS tarefas:
            if (utilizadorAtual is Programador prog && tarefa.ProgramadorId != prog.Id)
            {
                MessageBox.Show("Só podes ver as tuas tarefas.");
                return;
            }

            // 2) Se for Programador, o form fica READ-ONLY; se for Gestor, pode editar
            bool isReadOnly = utilizadorAtual is Programador;

            using (var form = new CriarTarefaForm(utilizadorAtual, tarefa, isReadOnly))
            {
                if (form.ShowDialog() == DialogResult.OK)
                    CarregarTarefas();
            }
        }


        /// <summary>
        /// Carrega todas as tarefas e popula as colunas ToDo, Doing e Done
        /// Exibe colunas: ID, Descrição e ID do Programador
        /// </summary>
        public void CarregarTarefas()
        {
            lvToDo.Items.Clear();
            lvDoing.Items.Clear();
            lvDone.Items.Clear();

            // se não houver nada selecionado, sai sem fazer nada
            if (cBProjeto.SelectedValue == null) return;
            int projetoId = Convert.ToInt32(cBProjeto.SelectedValue);

            using (var db = new iTasksContext())
            {
                var tarefas = db.Tarefas.Include("Programador").Where(t => t.ProjetoId == projetoId).ToList();
                foreach (var tarefa in tarefas)
                {
                    var progId = tarefa.Programador?.Id.ToString() ?? string.Empty;
                    var item = new ListViewItem(new[]
                    {
                        tarefa.Id.ToString(),
                        tarefa.Descricao ?? string.Empty,
                        progId
                    });

                    switch (tarefa.EstadoAtual)
                    {
                        case EstadoAtual.ToDo:
                            lvToDo.Items.Add(item);
                            break;
                        case EstadoAtual.Doing:
                            lvDoing.Items.Add(item);
                            break;
                        case EstadoAtual.Done:
                            lvDone.Items.Add(item);
                            break;
                    }
                }
            }
        }





        // Move tarefa de ToDo para Doing
        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (lvToDo.SelectedItems.Count == 0) 
            {
                return;
            }
                

            var item = lvToDo.SelectedItems[0];
            if (!int.TryParse(item.SubItems[0].Text, out int idTarefa))
                return;



            using (var db = new iTasksContext())
            {
                var tarefa = db.Tarefas.Find(idTarefa);

                if (utilizadorAtual is Programador && tarefa.ProgramadorId != utilizadorAtual.Id) 
                {
                    MessageBox.Show("So podes alterar as tuas tarefas");
                    return;
                }

                if (utilizadorAtual is Programador prog2)
                {
                    var doingCount = db.Tarefas
                        .Count(t => t.ProgramadorId == prog2.Id && t.EstadoAtual == EstadoAtual.Doing);
                    if (doingCount >= 2)
                    {
                        MessageBox.Show("Não podes ter mais de 2 tarefas em execução simultânea.");
                        return;
                    }
                }

                // só a menor ordem em ToDo
                if (utilizadorAtual is Programador prog3)
                {
                    var ordens = db.Tarefas
                        .Where(t => t.ProgramadorId == prog3.Id && t.EstadoAtual == EstadoAtual.ToDo)
                        .Select(t => t.OrdemExecucao);
                    if (ordens.Any() && tarefa.OrdemExecucao != ordens.Min())
                    {
                        MessageBox.Show($"Deves primeiro executar a tarefa de ordem {ordens.Min()}.");
                        return;
                    }
                }

                if (tarefa != null)
                {
                    tarefa.EstadoAtual = EstadoAtual.Doing;
                    tarefa.DataInicio = DateTime.Now;
                    db.SaveChanges();
                }
            }

            var novoItem = (ListViewItem)item.Clone();
            lvDoing.Items.Add(novoItem);
            lvToDo.Items.Remove(item);
        }

        // Move tarefa de Doing para ToDo
        private void btnPorfazer_Click(object sender, EventArgs e)
        {
            if (lvDoing.SelectedItems.Count == 0)
                return;



            var item = lvDoing.SelectedItems[0];
            if (!int.TryParse(item.SubItems[0].Text, out int idTarefa))
                return;
            if (lvDoing.SelectedItems.Count == 0) return;
            int id = int.Parse(lvDoing.SelectedItems[0].Text);

            using (var db = new iTasksContext())
            {
                var t = db.Tarefas.Find(id);
                if (utilizadorAtual is Programador p && t.ProgramadorId != p.Id)
                {
                    MessageBox.Show("Só podes alterar as tuas tarefas");
                    return;
                }

                t.EstadoAtual = EstadoAtual.ToDo;
                db.SaveChanges();
            }

            CarregarTarefas();

            
        }

        // Move tarefa de Doing para Done
        private void btnTerminar_Click(object sender, EventArgs e)
        {
            if (lvDoing.SelectedItems.Count == 0)
                return;

            // obtemos o ID da tarefa selecionada
            if (!int.TryParse(lvDoing.SelectedItems[0].SubItems[0].Text, out int idTarefa))
                return;

            using (var db = new iTasksContext())
            {
                var tarefa = db.Tarefas
                .Include("Programador")
                .Include("Projeto")
                .FirstOrDefault(t => t.Id == idTarefa);

                if (tarefa == null)
                    return;

                // Só o programador responsável pode alterar
                if (utilizadorAtual is Programador p && tarefa.ProgramadorId != p.Id)
                {
                    MessageBox.Show("Só podes alterar as tuas tarefas");
                    return;
                }

                // Ordem mínima em Doing deve ser terminada primeiro
                if (utilizadorAtual is Programador prog)
                {
                    var ordensDoing = db.Tarefas
                        .Where(t => t.ProgramadorId == prog.Id && t.EstadoAtual == EstadoAtual.Doing)
                        .Select(t => t.OrdemExecucao);
                    if (ordensDoing.Any())
                    {
                        int minOrderDoing = ordensDoing.Min();
                        if (tarefa.OrdemExecucao != minOrderDoing)
                        {
                            MessageBox.Show($"Deves primeiro terminar a tarefa de ordem {minOrderDoing}.");
                            return;
                        }
                    }
                }

                // efetiva a mudança de estado
                tarefa.EstadoAtual = EstadoAtual.Done;
                tarefa.DataFim = DateTime.Now;
                db.SaveChanges();
                //EnviarEmailConclusao(tarefa);
            }

            // recarrega todas as colunas
            CarregarTarefas();
            
        }
        /*
        private void EnviarEmailConclusao(Tarefa tarefa)
        {
                var assunto = $"Tarefa #{tarefa.Id} concluída";
                var corpo = $@"Projeto: {tarefa.Projeto.Descricao}
                Tarefa: {tarefa.Descricao}
                Programador: {tarefa.Programador.Username}
                ";

            using (var msg = new System.Net.Mail.MailMessage())
            {
                msg.From = new System.Net.Mail.MailAddress("seu@email");
                msg.To.Add("tiaglourenco@gmail.com");
                msg.Subject = assunto;
                msg.Body = corpo;

                using (var smtp = new System.Net.Mail.SmtpClient("smtp.seuprovedor.com", 587))
                {
                    smtp.Credentials = new System.Net.NetworkCredential("seu@email",
                                                                       "suaSenha");
                    smtp.EnableSsl = true;
                    smtp.Send(msg);
                }
            }
        }
        */

        // Outros handlers de menu e ListView
        private void tSCriarTarefas_Click(object sender, EventArgs e)
        {
            using (var form = new CriarTarefaForm(utilizadorAtual))
                if (form.ShowDialog() == DialogResult.OK)
                    CarregarTarefas();
        }

        private void tsCriarTiposTarefa_Click(object sender, EventArgs e)
        {
            using (var f = new TiposTarefaForm())
                f.ShowDialog();
        }

        private void tSCriarUtilizadores_Click(object sender, EventArgs e)
        {
            using (var f = new CriarUtilizadoresForm(utilizadorAtual))
                f.ShowDialog();
        }

        private void tSGerirUtilizadores_Click(object sender, EventArgs e)
        {
            // TODO: implementar gestão de utilizadores
        }

        
        private void lvDoing_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se selecionar no Doing, volta para ToDo automaticamente
            btnPorfazer_Click(sender, e);
        }
        private void lvDone_SelectedIndexChanged(object sender, EventArgs e) { }

        private void verTarefasPorFazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new VerTarefasPorFazerForm(utilizadorAtual))
                f.ShowDialog();
        }

        private void verTarefasEmExecuçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new VerTarefasEmExecucaoForm(utilizadorAtual))
                f.ShowDialog();
        }

        private void verTarefasTerminadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new VerTarefasTerminadasForm(utilizadorAtual))
                f.ShowDialog();
        }

        

        private void verAsMinhasTarefasConcluidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new VerAsMinhasTarefasConcluidasForm(utilizadorAtual)) 
            {
                f.ShowDialog();
            }
        }

        private void tarefasCriadasTerminadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TarefasConcluidasGestorForm(utilizadorAtual)) 
            {
                f.ShowDialog();
            }
      
        }

        private void tarefasCriadasTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new TarefasEmCursoGestorForm(utilizadorAtual)) 
            {
                f.ShowDialog();
            }
        }

        private void criarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new GestaoDeProjetosForm(utilizadorAtual))
                f.ShowDialog();
            CarregarListaProjetos();
            CarregarTarefas();

        }

        private void listagemProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new ListagemProjetosForm(utilizadorAtual))
            { f.ShowDialog(); }
        }
    }
}

using iTasks_ProjetoDA.Enums;
using iTasks_ProjetoDA.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace iTasks_ProjetoDA
{
    public partial class CriarUtilizadoresForm : Form
    {
        // Entidades para controlar o estado do form
        private Utilizador utilizadorAtual;            // quem está logado
        private Utilizador utilizadorSelecionado;      // item escolhido na ListView

        public CriarUtilizadoresForm(Utilizador utilizadorLogado)
        {
            InitializeComponent();

            lvTodosUtilizadores.View = View.Details;
            lvTodosUtilizadores.FullRowSelect = true;
            lvTodosUtilizadores.GridLines = true;
            lvTodosUtilizadores.Columns.Clear();
            lvTodosUtilizadores.Columns.Add("Id",            50, HorizontalAlignment.Left);
            lvTodosUtilizadores.Columns.Add("Nome",         150, HorizontalAlignment.Left);
            lvTodosUtilizadores.Columns.Add("IdGestor",      70, HorizontalAlignment.Left);
            lvTodosUtilizadores.Columns.Add("Experiência",  100, HorizontalAlignment.Left);
            lvTodosUtilizadores.Columns.Add("Departamento", 100, HorizontalAlignment.Left);

            // 1) Popula ComboBox de enums para Programador e Gestor
            cBExperiencia.DataSource = Enum.GetValues(typeof(NivelExperiencia));
            cBDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
            

            // 2) Popula ComboBox de Gestores para associação de Programador
            using (var db = new iTasksContext())
            {
                var gestores = db.Utilizadors.OfType<Gestor>().ToList();
                cBIdGestor.DataSource = gestores;
                cBIdGestor.DisplayMember = "Nome";    // mostra o nome no dropdown
                cBIdGestor.ValueMember = "Id";        // SelectedValue retorna o Id (int)
            }

            // 3) Carrega lista de utilizadores existentes na ListView
            CarregarListaUtilizadores();

            // Guarda quem acionou o form
            utilizadorAtual = utilizadorLogado;
        }

        /// <summary>
        /// Repopula a ListView com Programadores e Gestores do DB
        /// </summary>
        private void CarregarListaUtilizadores()
        {
            lvTodosUtilizadores.Items.Clear();

            using (var db = new iTasksContext())
            {
                var listaProg = db.Utilizadors
                                  .OfType<Programador>()
                                  .Include(p => p.Gestor)
                                  .ToList();

                foreach (var prog in listaProg)
                {
                    string gestorId = prog.Gestor != null
                                     ? prog.Gestor.Id.ToString()
                                     : prog.IdGestor.ToString();
                    var cols = new[]
                    {
                prog.Id.ToString(),
                prog.Nome,
                gestorId,
                prog.NivelDeExperiencia.ToString(),
                string.Empty
            };
                    lvTodosUtilizadores.Items.Add(new ListViewItem(cols));
                }

                var listaGest = db.Utilizadors.OfType<Gestor>().ToList();
                foreach (var gest in listaGest)
                {
                    var cols = new[]
                    {
                gest.Id.ToString(),
                gest.Nome,
                string.Empty,
                string.Empty,
                gest.Departamento.ToString()
            };
                    lvTodosUtilizadores.Items.Add(new ListViewItem(cols));
                }
            }

            foreach (ColumnHeader ch in lvTodosUtilizadores.Columns)
                ch.AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        /// <summary>
        /// Limpa todos os inputs do form e esconde grupos
        /// </summary>
        private void LimparDetalhes()
        {
            tBNome.Clear();
            tBId.Clear();
            tBUsername.Clear();
            tBPassword.Clear();

            rBProgramador.Checked = false;
            rBGestor.Checked = false;
            rBSim.Checked = false;
            rbNao.Checked = false;

            gBProgramador.Visible = false;
            gBGestor.Visible = false;
            utilizadorSelecionado = null;
        }

        // Toggle de grupos conforme radio buttons
        private void rBProgramador_CheckedChanged(object sender, EventArgs e)
        {
            gBProgramador.Visible = rBProgramador.Checked;
            gBGestor.Visible = !rBProgramador.Checked;
        }

        private void rBGestor_CheckedChanged(object sender, EventArgs e)
        {
            gBGestor.Visible = rBGestor.Checked;
            gBProgramador.Visible = !rBGestor.Checked;
        }

        /// <summary>
        /// Preenche campos com dados do utilizador selecionado na ListView
        /// </summary>
        private void lvTodosUtilizadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTodosUtilizadores.SelectedItems.Count == 0)
            {
                LimparDetalhes();
                return;
            }

            // Obtém ID do item
            var item = lvTodosUtilizadores.SelectedItems[0];
            if (!int.TryParse(item.SubItems[0].Text, out int idUtilizador))
            {
                LimparDetalhes();
                return;
            }

            using (var db = new iTasksContext())
            {
                // Carrega entidade do DB
                var user = db.Utilizadors.Find(idUtilizador);
                if (user == null)
                {
                    LimparDetalhes();
                    return;
                }

                // Guarda para operações futuras
                utilizadorSelecionado = user;

                // Campos comuns
                tBNome.Text = user.Nome;
                tBId.Text = user.Id.ToString();
                tBUsername.Text = user.Username;
                tBPassword.Text = user.Password;

                // Campos específicos
                if (user is Programador prog)
                {
                    rBProgramador.Checked = true;
                    cBExperiencia.SelectedItem = prog.NivelDeExperiencia;
                    cBIdGestor.SelectedValue = prog.IdGestor;
                }
                else if (user is Gestor gest)
                {
                    rBGestor.Checked = true;
                    cBDepartamento.SelectedItem = gest.Departamento;
                    rBSim.Checked = gest.GereUtilizadores;
                    rbNao.Checked = !gest.GereUtilizadores;
                }
            }
        }

        /// <summary>
        /// Cria um novo Programador ou Gestor, se o logado for Gestor
        /// </summary>
        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (utilizadorAtual is Programador)
            {
                MessageBox.Show("Erro: não tens permissão para criar utilizadores.");
                return;
            }

            var nome = tBNome.Text.Trim();
            var username = tBUsername.Text.Trim();
            var password = tBPassword.Text;
            var criarProg = rBProgramador.Checked;
            var criarGest = rBGestor.Checked;

            // Valida campos obrigatórios
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                (!criarProg && !criarGest))
            {
                MessageBox.Show("Preenche todos os campos obrigatórios.");
                return;
            }

            using (var db = new iTasksContext())
            {
                // Verifica username duplicado
                if (db.Utilizadors.Any(u => u.Username == username))
                {
                    MessageBox.Show("Username já existe.");
                    return;
                }

                if (criarProg)
                {
                    // Valida extras de Programador
                    if (cBExperiencia.SelectedItem == null || cBIdGestor.SelectedItem == null)
                    {
                        MessageBox.Show("Seleciona experiência e gestor para o programador.");
                        return;
                    }

                    var prog = new Programador
                    {
                        Nome = nome,
                        Username = username,
                        Password = password,
                        NivelDeExperiencia = (NivelExperiencia)cBExperiencia.SelectedItem,
                        IdGestor = (int)cBIdGestor.SelectedValue 
                    };
                    db.Utilizadors.Add(prog);
                }
                else // criar Gestor
                {
                    if (cBDepartamento.SelectedItem == null)
                    {
                        MessageBox.Show("Seleciona um departamento para o gestor.");
                        return;
                    }

                    var gest = new Gestor
                    {
                        Nome = nome,
                        Username = username,
                        Password = password,
                        Departamento = (Departamento)cBDepartamento.SelectedItem,
                        GereUtilizadores = rBSim.Checked
                    };
                    db.Utilizadors.Add(gest);
                }

                db.SaveChanges();
            }

            using (var db = new iTasksContext())
            {
                var gestores = db.Utilizadors.OfType<Gestor>().ToList();
                cBIdGestor.DataSource = gestores;
                cBIdGestor.DisplayMember = "Nome";    // mostra o nome no dropdown
                cBIdGestor.ValueMember = "Id";        // SelectedValue retorna o Id (int)
            }

            MessageBox.Show("Utilizador criado com sucesso.");
            LimparDetalhes();
            CarregarListaUtilizadores();
        }

        /// <summary>
        /// Atualiza o utilizador selecionado
        /// </summary>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (utilizadorSelecionado == null)
            {
                MessageBox.Show("Seleciona um utilizador para editar.");
                return;
            }

            // Atualiza campos comuns
            utilizadorSelecionado.Nome = tBNome.Text.Trim();
            utilizadorSelecionado.Username = tBUsername.Text.Trim();
            utilizadorSelecionado.Password = tBPassword.Text;

            using (var db = new iTasksContext())
            {
                db.Utilizadors.Attach(utilizadorSelecionado);

                if (utilizadorSelecionado is Programador prog)
                {
                    prog.NivelDeExperiencia = (NivelExperiencia)cBExperiencia.SelectedItem;
                    prog.IdGestor =(int)cBIdGestor.SelectedValue;
                }
                else if (utilizadorSelecionado is Gestor gest)
                {
                    gest.Departamento = (Departamento)cBDepartamento.SelectedItem;
                    gest.GereUtilizadores = rBSim.Checked;
                }

                db.SaveChanges();
            }

            MessageBox.Show("Utilizador atualizado com sucesso.");
            LimparDetalhes();
            CarregarListaUtilizadores();
        }

        /// <summary>
        /// Apaga o utilizador selecionado (somente se Gestor sem dependentes)
        /// </summary>
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (utilizadorSelecionado == null)
            {
                MessageBox.Show("Seleciona um utilizador para apagar.");
                return;
            }

            using (var db = new iTasksContext())
            {
                if (utilizadorSelecionado is Gestor &&
                    db.Utilizadors.OfType<Programador>()
                      .Any(p => p.Gestor.Id == utilizadorSelecionado.Id))
                {
                    MessageBox.Show("Não podes apagar um gestor com programadores associados.");
                    return;
                }

                db.Utilizadors.Attach(utilizadorSelecionado);
                db.Utilizadors.Remove(utilizadorSelecionado);
                db.SaveChanges();
            }

            MessageBox.Show("Utilizador apagado com sucesso.");
            LimparDetalhes();
            CarregarListaUtilizadores();
        }

        // Garante que apenas um dos radio buttons (Sim/Nao) fica checked
        private void rBSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rBSim.Checked)
                rbNao.Checked = false;
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNao.Checked)
                rBSim.Checked = false;
        }
    }
}

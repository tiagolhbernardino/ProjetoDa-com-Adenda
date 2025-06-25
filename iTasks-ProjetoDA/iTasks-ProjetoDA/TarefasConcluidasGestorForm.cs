using iTasks_ProjetoDA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTasks_ProjetoDA.Enums;

namespace iTasks_ProjetoDA
{
    public partial class TarefasConcluidasGestorForm : Form
    {
        Utilizador utilizadorAtual;

        public TarefasConcluidasGestorForm(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            utilizadorAtual = utilizadorLogado;

            lvTarefasTerminadas.View = View.Details;

            // —— Colunas originais ——
            lvTarefasTerminadas.Columns.Clear();
            lvTarefasTerminadas.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lvTarefasTerminadas.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
            lvTarefasTerminadas.Columns.Add("Programador", 120, HorizontalAlignment.Left);
            lvTarefasTerminadas.Columns.Add("Previstos (dias)", 100, HorizontalAlignment.Right);
            lvTarefasTerminadas.Columns.Add("Reais (dias)", 100, HorizontalAlignment.Right);
            lvTarefasTerminadas.Columns.Add("Diferença", 80, HorizontalAlignment.Right);

            // —— NOVAS colunas para mostrar as datas completas ——
            lvTarefasTerminadas.Columns.Add("Início Previsto", 100, HorizontalAlignment.Left);
            lvTarefasTerminadas.Columns.Add("Fim Previsto", 100, HorizontalAlignment.Left);
            lvTarefasTerminadas.Columns.Add("Início Real", 100, HorizontalAlignment.Left);
            lvTarefasTerminadas.Columns.Add("Fim Real", 100, HorizontalAlignment.Left);
            lvTarefasTerminadas.Columns.Add("Projeto", 100, HorizontalAlignment.Left);
            CarregarListaTarefas();
        }

        private void CarregarListaTarefas()
        {
            lvTarefasTerminadas.Items.Clear();

            using (var db = new iTasksContext())
            {
                var lista = db.Tarefas
                    .Include(t => t.Programador)
                    .Include(t => t.Projeto)
                    .Where(t =>
                        t.EstadoAtual == EstadoAtual.Done &&
                        t.IdGestor == utilizadorAtual.Id &&
                        t.DataInicio.HasValue &&
                        t.DataFim.HasValue)
                    .ToList();

                foreach (var t in lista)
                {
                    int previstoDias = (t.DataPrevistaFim - t.DataPrevistaInicio).Days;
                    int reaisDias = (t.DataFim.Value - t.DataInicio.Value).Days;
                    int diferenca = reaisDias - previstoDias;

                    var item = new ListViewItem(t.Id.ToString());
                    item.SubItems.Add(t.Descricao);
                    item.SubItems.Add(t.Programador.Username);
                    item.SubItems.Add(previstoDias.ToString());
                    item.SubItems.Add(reaisDias.ToString());
                    item.SubItems.Add(diferenca.ToString());
                    item.SubItems.Add(t.DataPrevistaInicio.ToShortDateString());
                    item.SubItems.Add(t.DataPrevistaFim.ToShortDateString());
                    item.SubItems.Add(t.DataInicio.Value.ToShortDateString());
                    item.SubItems.Add(t.DataFim.Value.ToShortDateString());
                    item.SubItems.Add(t.Projeto.Descricao.ToString());
                    lvTarefasTerminadas.Items.Add(item);
                }
            }

            // Auto-redimensiona cada coluna ao conteúdo
            for (int i = 0; i < lvTarefasTerminadas.Columns.Count; i++)
            {
                lvTarefasTerminadas.AutoResizeColumn(
                    i,
                    ColumnHeaderAutoResizeStyle.ColumnContent
                );
            }
        }



        private void btnExportarCsv_Click_1(object sender, EventArgs e)
        {
            List<Tarefa> lista;
            using (var db = new iTasksContext())
            {
                lista = db.Tarefas
                          .Include(t => t.Programador)
                          .Include(t => t.TipoTarefa)
                          .Where(t => t.EstadoAtual == EstadoAtual.Done
                                   && t.IdGestor == utilizadorAtual.Id
                                   && t.DataInicio.HasValue
                                   && t.DataFim.HasValue)
                          .ToList();
            }

            if (!lista.Any())
            {
                MessageBox.Show("Não há tarefas concluídas para exportar.");
                return;
            }

            var sb = new StringBuilder();
            // Cabeçalho com nome das colunas
            sb.AppendLine("Programador;Descricao;DataPrevistaInicio;DataPrevistaFim;TipoTarefa;DataRealInicio;DataRealFim");

            foreach (var t in lista)
            {
                var prog = t.Programador.Username;
                var desc = t.Descricao.Replace("\"", "\"\"");
                var tipo = t.TipoTarefa?.Nome ?? "";
                var prevI = t.DataPrevistaInicio.ToString("yyyy-MM-dd");
                var prevF = t.DataPrevistaFim.ToString("yyyy-MM-dd");
                var realI = t.DataInicio.Value.ToString("yyyy-MM-dd");
                var realF = t.DataFim.Value.ToString("yyyy-MM-dd");

                sb.AppendLine($"{prog};\"{desc}\";{prevI};{prevF};{tipo};{realI};{realF}");
            }

            using (var sfd = new SaveFileDialog
            {
                Filter = "Text File (*.txt)|*.txt",
                DefaultExt = "txt",
                FileName = "TarefasConcluidas.txt"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                    System.IO.File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
            }
        }


    }
}

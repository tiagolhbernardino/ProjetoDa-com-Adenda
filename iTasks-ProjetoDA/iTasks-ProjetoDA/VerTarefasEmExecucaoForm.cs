using iTasks_ProjetoDA.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using iTasks_ProjetoDA.Enums;

namespace iTasks_ProjetoDA
{
    public partial class VerTarefasEmExecucaoForm : Form
    {
        private readonly Utilizador utilizadorAtual;

        public VerTarefasEmExecucaoForm(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            utilizadorAtual = utilizadorLogado;

            // Configura ListView para exibir colunas em modo detalhes
            lvTarefasDoing.View = View.Details;
            lvTarefasDoing.FullRowSelect = true;
            lvTarefasDoing.Columns.Clear();
            lvTarefasDoing.Columns.Add("ID", 50);
            lvTarefasDoing.Columns.Add("Descrição", 200);
            lvTarefasDoing.Columns.Add("Programador", 100);
            lvTarefasDoing.Columns.Add("Ordem", 60);
            lvTarefasDoing.Columns.Add("Prev.Início", 100);
            lvTarefasDoing.Columns.Add("Prev.Fim", 100);
            lvTarefasDoing.Columns.Add("Início real", 100);
            lvTarefasDoing.Columns.Add("Fim real", 100);
            lvTarefasDoing.Columns.Add("StoryPoints", 80);

            CarregarListaTarefas();
        }

        private void CarregarListaTarefas()
        {
            lvTarefasDoing.Items.Clear();

            using (var db = new iTasksContext())
            {
                // Inclui programador e tipo para detalhes
                var listaDoing = db.Tarefas
                    .Include(t => t.Programador)
                    .Where(t => t.EstadoAtual == EstadoAtual.Doing)
                    .ToList();

                foreach (var t in listaDoing)
                {
                    var progName = t.Programador?.Username ?? "-";
                    var dataInicioReal = t.DataInicio?.ToString("g") ?? "-";
                    var dataFimReal = t.DataFim?.ToString("g") ?? "-";

                    var item = new ListViewItem(new[]
                    {
                        t.Id.ToString(),
                        t.Descricao,
                        progName,
                        t.OrdemExecucao.ToString(),
                        t.DataPrevistaInicio.ToShortDateString(),
                        t.DataPrevistaFim.ToShortDateString(),
                        dataInicioReal,
                        dataFimReal,
                        t.StoryPoints.ToString()
                    });

                    lvTarefasDoing.Items.Add(item);
                }
            }
        }
    }
}

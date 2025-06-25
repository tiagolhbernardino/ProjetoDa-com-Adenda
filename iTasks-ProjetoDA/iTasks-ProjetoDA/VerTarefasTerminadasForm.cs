using iTasks_ProjetoDA.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using iTasks_ProjetoDA.Enums;

namespace iTasks_ProjetoDA
{
    public partial class VerTarefasTerminadasForm : Form
    {
        private readonly Utilizador utilizadorAtual;

        public VerTarefasTerminadasForm(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            utilizadorAtual = utilizadorLogado;

            // Configura ListView para exibir colunas em modo detalhes
            lvVerTarefasTerminadas.View = View.Details;
            lvVerTarefasTerminadas.FullRowSelect = true;
            lvVerTarefasTerminadas.Columns.Clear();
            lvVerTarefasTerminadas.Columns.Add("ID", 50);
            lvVerTarefasTerminadas.Columns.Add("Descrição", 200);
            lvVerTarefasTerminadas.Columns.Add("Programador", 120);
            lvVerTarefasTerminadas.Columns.Add("Ordem", 60);
            lvVerTarefasTerminadas.Columns.Add("Prev.Início", 100);
            lvVerTarefasTerminadas.Columns.Add("Prev.Fim", 100);
            lvVerTarefasTerminadas.Columns.Add("Início real", 100);
            lvVerTarefasTerminadas.Columns.Add("Fim real", 100);
            lvVerTarefasTerminadas.Columns.Add("Tempo (dias)", 80);
            lvVerTarefasTerminadas.Columns.Add("StoryPoints", 20);

            CarregarListaTarefas();
        }

        private void CarregarListaTarefas()
        {
            lvVerTarefasTerminadas.Items.Clear();

            using (var db = new iTasksContext())
            {
                var listaDone = db.Tarefas
                    .Include(t => t.Programador)
                    .Where(t => t.EstadoAtual == EstadoAtual.Done)
                    .ToList();

                foreach (var t in listaDone)
                {
                    var progName = t.Programador?.Username ?? "-";
                    var inicioReal = t.DataInicio?.ToShortDateString() ?? "-";
                    var fimReal = t.DataFim?.ToShortDateString() ?? "-";

                    // Calcula diferença em dias entre data de início e fim
                    string dias;
                    if (t.DataInicio.HasValue && t.DataFim.HasValue)
                        dias = (t.DataFim.Value - t.DataInicio.Value).TotalDays.ToString("0");
                    else
                        dias = "-";

                    var item = new ListViewItem(new[]
                    {
                        t.Id.ToString(),
                        t.Descricao,
                        progName,
                        t.OrdemExecucao.ToString(),
                        t.DataPrevistaInicio.ToShortDateString(),
                        t.DataPrevistaFim.ToShortDateString(),
                        inicioReal,
                        fimReal,
                        dias,
                        t.StoryPoints.ToString(),
                    });

                    lvVerTarefasTerminadas.Items.Add(item);
                }
            }
        }
    }
}

using iTasks_ProjetoDA.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using iTasks_ProjetoDA.Enums;

namespace iTasks_ProjetoDA
{
    public partial class VerTarefasPorFazerForm : Form
    {
        private readonly Utilizador utilizadorAtual;

        public VerTarefasPorFazerForm(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            utilizadorAtual = utilizadorLogado;

            // Configura ListView para exibir colunas em modo detalhes
            lvTarefasToDo.View = View.Details;
            lvTarefasToDo.FullRowSelect = true;
            lvTarefasToDo.Columns.Clear();
            lvTarefasToDo.Columns.Add("ID", 50);
            lvTarefasToDo.Columns.Add("Descrição", 200);
            lvTarefasToDo.Columns.Add("Programador", 120);
            lvTarefasToDo.Columns.Add("Ordem", 60);
            lvTarefasToDo.Columns.Add("Prev.Início", 100);
            lvTarefasToDo.Columns.Add("Prev.Fim", 100);
            lvTarefasToDo.Columns.Add("StoryPoints", 80);

            CarregarListaTarefas();
        }

        private void CarregarListaTarefas()
        {
            lvTarefasToDo.Items.Clear();

            using (var db = new iTasksContext())
            {
                var listaToDo = db.Tarefas
                    .Include(t => t.Programador)       // agora vai carregar!
                    .Where(t => t.EstadoAtual == EstadoAtual.ToDo)
                    .ToList();

                foreach (var t in listaToDo)
                {
                    var progName = t.Programador?.Username ?? "-";

                    var item = new ListViewItem(new[]
                    {
                t.Id.ToString(),
                t.Descricao,
                progName,
                t.OrdemExecucao.ToString(),
                t.DataPrevistaInicio.ToShortDateString(),
                t.DataPrevistaFim.ToShortDateString(),
                t.StoryPoints.ToString()
            });

                    lvTarefasToDo.Items.Add(item);
                }
            }
        }

    }
}

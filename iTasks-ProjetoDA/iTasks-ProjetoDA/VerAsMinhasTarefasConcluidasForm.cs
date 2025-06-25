using iTasks_ProjetoDA.Enums;
using iTasks_ProjetoDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks_ProjetoDA
{
    public partial class VerAsMinhasTarefasConcluidasForm : Form
    {
        Utilizador utilizadorAtual;

        public VerAsMinhasTarefasConcluidasForm(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            utilizadorAtual = utilizadorLogado;

            lvMinhasTarefasTerminadas.View = View.Details;
            lvMinhasTarefasTerminadas.Columns.Clear();
            lvMinhasTarefasTerminadas.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lvMinhasTarefasTerminadas.Columns.Add("Descricao", 200, HorizontalAlignment.Left);
            lvMinhasTarefasTerminadas.Columns.Add("Inicio", 80, HorizontalAlignment.Left);
            lvMinhasTarefasTerminadas.Columns.Add("Fim", 80, HorizontalAlignment.Left);
            lvMinhasTarefasTerminadas.Columns.Add("Total dias", 80, HorizontalAlignment.Left);

            // chama logo ao criar o form
            CarregarTarefasConcluidas();
        }

        private void CarregarTarefasConcluidas()
        {
            if (!(utilizadorAtual is Programador prog))
                throw new InvalidOperationException("Apenas programadores podem ver esta lista.");

            lvMinhasTarefasTerminadas.Items.Clear();

            using (var db = new iTasksContext())
            {
                // compara pelo FK ProgramadorId
                var tarefas = db.Tarefas
                    .Where(t => t.EstadoAtual == EstadoAtual.Done
                             && t.ProgramadorId == prog.Id)
                    .ToList();

                foreach (var t in tarefas)
                {
                    var strInicio = t.DataInicio?.ToShortDateString() ?? "";
                    var strFim = t.DataFim?.ToShortDateString() ?? "";
                    var dias = (t.DataInicio.HasValue && t.DataFim.HasValue)
                             ? (t.DataFim.Value - t.DataInicio.Value).Days
                             : 0;

                    var item = new ListViewItem(t.Id.ToString());
                    item.SubItems.Add(t.Descricao);
                    item.SubItems.Add(strInicio);
                    item.SubItems.Add(strFim);
                    item.SubItems.Add(dias.ToString());
                    lvMinhasTarefasTerminadas.Items.Add(item);
                }
            }
        }
    }


}

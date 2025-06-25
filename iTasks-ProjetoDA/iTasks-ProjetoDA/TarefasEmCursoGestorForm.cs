using iTasks_ProjetoDA.Models;
using iTasks_ProjetoDA.Enums;
using System;
using System.Data.Entity;        // <- necessário para Include
using System.Linq;
using System.Windows.Forms;

namespace iTasks_ProjetoDA
{
    public partial class TarefasEmCursoGestorForm : Form
    {
        private readonly Utilizador utilizadorAtual;

        public TarefasEmCursoGestorForm(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            utilizadorAtual = utilizadorLogado;

            lvEmCursoGestor.View = View.Details;
            lvEmCursoGestor.FullRowSelect = true;
            lvEmCursoGestor.GridLines = true;
            lvEmCursoGestor.Columns.Clear();
            lvEmCursoGestor.Columns.Add("ID", 50, HorizontalAlignment.Left);
            lvEmCursoGestor.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
            lvEmCursoGestor.Columns.Add("Programador", 120, HorizontalAlignment.Left);
            lvEmCursoGestor.Columns.Add("Estado", 80, HorizontalAlignment.Left);
            lvEmCursoGestor.Columns.Add("Dias Restantes", 100, HorizontalAlignment.Right);
            lvEmCursoGestor.Columns.Add("Dias Atraso", 80, HorizontalAlignment.Right);

            CarregarTarefas();
        }

        private void CarregarTarefas()
        {
            lvEmCursoGestor.Items.Clear();  // limpa sempre antes de popular

            using (var db = new iTasksContext())
            {
                var listaTarefas = db.Tarefas
                    .Include(t => t.Programador)   // carrega o Programador
                    .Where(t =>
                        t.IdGestor == utilizadorAtual.Id &&       // usa GestorId, não IdGestor
                        t.EstadoAtual != EstadoAtual.Done
                    )
                    .OrderBy(t => t.EstadoAtual)
                    .ToList();

                var hoje = DateTime.Now.Date;

                foreach (var t in listaTarefas)
                {
                    int diasRaw = (t.DataPrevistaFim.Date - hoje).Days;
                    int diasRestantes = Math.Max(diasRaw, 0);
                    int diasAtraso = diasRaw < 0 ? -diasRaw : 0;

                    var item = new ListViewItem(t.Id.ToString());
                    item.SubItems.Add(t.Descricao);
                    item.SubItems.Add(t.Programador?.Username ?? "-");
                    item.SubItems.Add(t.EstadoAtual.ToString());
                    item.SubItems.Add(diasRestantes.ToString());
                    item.SubItems.Add(diasAtraso.ToString());
                    lvEmCursoGestor.Items.Add(item);
                }
            }
        }
    }
}

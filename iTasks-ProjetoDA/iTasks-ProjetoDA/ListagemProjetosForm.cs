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
    public partial class ListagemProjetosForm : Form
    {
        private readonly Utilizador utilizadorAtual;

        public ListagemProjetosForm(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            utilizadorAtual = utilizadorLogado;

            // 1) Configura o ListView
            lvListagem.View = View.Details;
            lvListagem.FullRowSelect = true;
            lvListagem.Columns.Clear();
            lvListagem.Columns.Add("Projeto", 200, HorizontalAlignment.Left);
            lvListagem.Columns.Add("TotalTarefas", 100, HorizontalAlignment.Right);
            lvListagem.Columns.Add("ConcluidasATempo", 120, HorizontalAlignment.Right);
            lvListagem.Columns.Add("ConcluidasForaPrazo", 140, HorizontalAlignment.Right);
            lvListagem.Columns.Add("ProgramadorATempo", 100, HorizontalAlignment.Right);
            lvListagem.Columns.Add("ProgramadorForaPrazo", 120, HorizontalAlignment.Right);

            CarregarListagemProjetos();
        }

        private void CarregarListagemProjetos()
        {
            lvListagem.Items.Clear();

            using (var db = new iTasksContext())
            {
                // traz todos os projetos
                var projetos = db.Projetos.ToList();

                foreach (var proj in projetos)
                {
                    // todas as tarefas deste projeto
                    var tarefas = db.Tarefas
                                    .Where(t => t.ProjetoId == proj.Id && t.EstadoAtual == EstadoAtual.Done)
                                    .ToList();

                    int total = tarefas.Count;
                    int dentroPrazo = tarefas.Count(t => t.DataFim.Value <= t.DataPrevistaFim);
                    int foraPrazo = tarefas.Count(t => t.DataFim.Value > t.DataPrevistaFim);

                    int progDentro = tarefas
                                        .Where(t => t.DataFim.Value <= t.DataPrevistaFim)
                                        .Select(t => t.ProgramadorId)
                                        .Distinct().Count();
                    int progFora = tarefas
                                        .Where(t => t.DataFim.Value > t.DataPrevistaFim)
                                        .Select(t => t.ProgramadorId)
                                        .Distinct().Count();

                    var item = new ListViewItem(proj.Descricao);
                    item.SubItems.Add(total.ToString());
                    item.SubItems.Add(dentroPrazo.ToString());
                    item.SubItems.Add(foraPrazo.ToString());
                    item.SubItems.Add(progDentro.ToString());
                    item.SubItems.Add(progFora.ToString());

                    lvListagem.Items.Add(item);
                }
            }
        }
    }

}

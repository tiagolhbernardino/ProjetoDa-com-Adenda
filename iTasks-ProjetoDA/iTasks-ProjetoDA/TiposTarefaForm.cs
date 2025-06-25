using iTasks_ProjetoDA.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace iTasks_ProjetoDA
{
    public partial class TiposTarefaForm : Form
    {
        public TiposTarefaForm()
        {
            InitializeComponent();
            CarregarListaTiposTarefa();
        }

        /// <summary>
        /// Carrega a ListView com todos os Tipos de Tarefa existentes
        /// </summary>
        private void CarregarListaTiposTarefa()
        {
            lvTiposTarefas.Items.Clear();
            using (var db = new iTasksContext())
            {
                var tipos = db.TiposTarefa.ToList();
                foreach (var tipo in tipos)
                {
                    var item = new ListViewItem(new[]
                    {
                        tipo.Id.ToString(),
                        tipo.Nome
                    });
                    lvTiposTarefas.Items.Add(item);
                }
            }
        }

        /// <summary>
        /// Limpa os campos de input
        /// </summary>
        private void LimparCampos()
        {
            tbId.Clear();
            tBNome.Clear();
        }

        /// <summary>
        /// Cria um novo TipoTarefa; o EF gera o ID automaticamente
        /// </summary>
        private void btnCriar_Click(object sender, EventArgs e)
        {
            string descricao = tBNome.Text.Trim();
            if (string.IsNullOrWhiteSpace(descricao))
            {
                MessageBox.Show("Erro: Tipo de tarefa sem descrição.");
                return;
            }

            using (var db = new iTasksContext())
            {

                if (db.TiposTarefa.Any(t => t.Nome.Equals(descricao, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Já existe um tipo de tarefa com esse nome.");
                    tBNome.Focus();
                    return;
                }
                // Cria entidade sem definir ID
                var novo = new TipoTarefa
                {
                    Nome = descricao
                };
                db.TiposTarefa.Add(novo);
                db.SaveChanges();
            }

            // Atualiza a lista e limpa campos
            CarregarListaTiposTarefa();
            LimparCampos();
        }

        /// <summary>
        /// Preenche campos ao selecionar um item na ListView
        /// </summary>
        private void lvTiposTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTiposTarefas.SelectedItems.Count == 0)
            {
                LimparCampos();
                return;
            }

            var item = lvTiposTarefas.SelectedItems[0];
            if (!int.TryParse(item.SubItems[0].Text, out int idTipo))
            {
                LimparCampos();
                return;
            }

            using (var db = new iTasksContext())
            {
                var tipo = db.TiposTarefa.Find(idTipo);
                if (tipo == null) return;

                tbId.Text = tipo.Id.ToString();
                tBNome.Text = tipo.Nome;
            }
        }

        /// <summary>
        /// Atualiza a descrição do TipoTarefa selecionado
        /// </summary>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbId.Text, out int idTipo))
            {
                MessageBox.Show("Erro: selecione um tipo válido.");
                return;
            }
            string novaDesc = tBNome.Text.Trim();
            if (string.IsNullOrWhiteSpace(novaDesc))
            {
                MessageBox.Show("Erro: descrição não pode ficar vazia.");
                return;
            }

            using (var db = new iTasksContext())
            {
                var tipo = db.TiposTarefa.Find(idTipo);
                if (tipo == null)
                {
                    MessageBox.Show("Erro: tipo não encontrado.");
                    return;
                }
                tipo.Nome = novaDesc;
                db.SaveChanges();
            }

            MessageBox.Show("Tipo de tarefa atualizado com sucesso.");
            CarregarListaTiposTarefa();
            LimparCampos();
        }

        /// <summary>
        /// Remove o TipoTarefa selecionado
        /// </summary>
        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbId.Text, out int idTipo))
            {
                MessageBox.Show("Erro: selecione um tipo válido.");
                return;
            }

            using (var db = new iTasksContext())
            {

                bool usado = db.Tarefas.Any(t => t.TipoTarefa.Id == idTipo);
                if (usado)
                {
                    MessageBox.Show("Não é possível apagar: este tipo de tarefa está em uso.");
                    return;
                }

                var tipo = db.TiposTarefa.Find(idTipo);
                if (tipo == null)
                {
                    MessageBox.Show("Erro: tipo não encontrado.");
                    return;
                }


                db.TiposTarefa.Remove(tipo);
                db.SaveChanges();
            }

            MessageBox.Show("Tipo de tarefa removido.");
            CarregarListaTiposTarefa();
            LimparCampos();
        }
    }
}

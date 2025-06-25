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
    public partial class GestaoDeProjetosForm : Form
    {
        private Utilizador utilizadorAtual;
        
        public GestaoDeProjetosForm(Utilizador utilizadorLogado)
        {
            InitializeComponent();
            
            utilizadorAtual= utilizadorLogado;
            if (!(utilizadorAtual is Gestor))
                throw new InvalidOperationException("Só gestores podem gerir projetos");

            CarregarProjetos();
        }

        private void LimparCampos() 
        {
            tBId.Clear();
            tBDesccricao.Clear();
            listView1.SelectedItems.Clear();
        }

        private void CarregarProjetos() 
        {
            listView1.View = View.Details;

            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("Id", 50, HorizontalAlignment.Left);
                listView1.Columns.Add("Descrição", 300, HorizontalAlignment.Left);
            }
            listView1.Items.Clear();


            using (var db = new iTasksContext()) 
            {
                var listaProjetos = db.Projetos.OrderBy(p => p.Id).Select(p => new { p.Id, p.Descricao}).ToList();
                foreach (var p in listaProjetos) 
                {
                    var item = new ListViewItem(p.Id.ToString());
                    item.SubItems.Add(p.Descricao);
                    item.Tag = p;
                    listView1.Items.Add(item);
                }
                

            }
        
        }

        private void btnCriarProjeto_Click(object sender, EventArgs e)
        {
            var descricao = tBDesccricao.Text.Trim();

            if (string.IsNullOrEmpty(descricao)) 
            {
                MessageBox.Show("A descricao nao pode estar vazia");
                return;
            }

            if (utilizadorAtual is Programador)
            {
                MessageBox.Show("O utilizador autal nao pode criar projetos");
                return;
            }

            using (var db = new iTasksContext()) 
            {
                if (db.Projetos.Any(p => p.Descricao == descricao)) 
                {
                    MessageBox.Show("Ja existe um projeto com esta descrição");
                    return;
                }


                var projetoCriado = new Projeto {Descricao = descricao};
                db.Projetos.Add(projetoCriado);
                db.SaveChanges();

            }

            MessageBox.Show("Projeto cirado com seucesso");
            CarregarProjetos();
            LimparCampos();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) 
            {
                MessageBox.Show("Não há nenhum campo selecionado");
                return;
            }

            if (!int.TryParse(tBId.Text, out int id)) 
            {
                MessageBox.Show("ID invalido");
                return;
            }

            var novaDescricao = tBDesccricao.Text.Trim();

            if (string.IsNullOrEmpty(novaDescricao)) 
            {
                MessageBox.Show("Campo tem de ser preenchido");
                return;
            }

            using (var db = new iTasksContext()) 
            {
                var proj = db.Projetos.Find(id);
                if (proj == null) 
                {
                    MessageBox.Show("Nao foi possivel encontrr o id com esse projeto");
                    return;

                }
                if(db.Projetos.Any(p => p.Descricao == novaDescricao && p.Id != id)) 
                {
                    MessageBox.Show("Ja existe essa descricao para outro id");
                    return;
                }

                proj.Descricao = novaDescricao;
                db.SaveChanges();
            }
            MessageBox.Show("Projeto alterado com sucesso");

            LimparCampos();
            CarregarProjetos();

            return;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nenhum item selecionado");
                return;
            }

            if (!int.TryParse(tBId.Text, out int id)) 
            {
                return;
            }

            using (var db = new iTasksContext()) 
            {
                var proj = db.Projetos.Find(id);
                if (proj == null) 
                {
                    MessageBox.Show("Nenhum projeto com este id");
                    return;
                }

                db.Projetos.Remove(proj);
                db.SaveChanges();
            }
            CarregarProjetos();
            LimparCampos();
            MessageBox.Show("Apagado com sucesso");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) 
            {
                return;
            }
            var item = listView1.SelectedItems[0];
            tBId.Text = item.Text;
            tBDesccricao.Text = item.SubItems[1].Text;
        }
    }
}

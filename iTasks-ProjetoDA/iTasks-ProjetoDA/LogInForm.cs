using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using iTasks_ProjetoDA.Models;

namespace iTasks_ProjetoDA
{
    public partial class LogInForm : Form
    {
        // Guarda o utilizador autenticado
        public Utilizador UtilizadorLogado { get; private set; }

        public LogInForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento click do botão Login: valida credenciais e fecha o form em caso de sucesso
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1) Lê e valida campos
            var username = txtBUsername.Text.Trim();    // verifique na Designer se o TextBox se chama txtUsername
            var password = txtBPassword.Text.Trim();           // e txtPassword, ajuste caso contrário

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha ambos os campos.", "Campos em branco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Consulta no banco de dados
            using (var db = new iTasksContext())
            {
                // Se o EF não reconhecer FirstOrDefault, adicione: using System.Linq;
                var user = db.Utilizadors
                             .FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    // 3) Autenticação bem-sucedida
                    UtilizadorLogado = user;
                    MessageBox.Show($"Bem-vindo(a), {user.Nome}!", "Login OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // 4) Falha na autenticação
                    MessageBox.Show("Credenciais inválidas. Tente novamente.", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

using iTasks_ProjetoDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTasks_ProjetoDA
{

    internal static class Program
    {

        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var db = new iTasksContext()) 
            {
                var utilizadorAdmin = db.Utilizadors.FirstOrDefault(u => u.Username == "Admin");

                if (utilizadorAdmin == null)
                {
                    var admin = new Gestor
                    {
                        Nome = "Admin",
                        Username = "Admin",
                        Password = "Admin",
                        Departamento = Enums.Departamento.Administracao,
                        GereUtilizadores = true,
                    };
                    db.Utilizadors.Add(admin);
                    db.SaveChanges();
                }
            }



                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


                
            var loginform = new LogInForm();
            Application.Run(loginform);
            
              
                if (loginform.DialogResult == DialogResult.OK) 
                {
                    var utilizadorloggado = loginform.UtilizadorLogado;
                    Application.Run(new KanbanForm(utilizadorloggado));

                }
            

        }
    }
}

using iTasks_ProjetoDA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks_ProjetoDA.Models
{
    public class Gestor : Utilizador
    {
        public  Departamento Departamento { get; set; }
        public  bool GereUtilizadores {  get; set; }

        public List<Programador> Programadores { get; set; } = new List<Programador>();

        public List<Tarefa> TarefasCriadas { get; set; } = new List<Tarefa>();


        public Gestor() { }
        

    }
}

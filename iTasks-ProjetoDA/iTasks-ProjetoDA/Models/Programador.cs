using iTasks_ProjetoDA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks_ProjetoDA.Models
{
    public class Programador : Utilizador
    {
        public NivelExperiencia NivelDeExperiencia { get; set; }

        public Gestor Gestor { get; set; }

        public int IdGestor { get; set; }

        

        public List<Tarefa> ListaTarefas { get; set; }


        public Programador() { }
        

    }
}

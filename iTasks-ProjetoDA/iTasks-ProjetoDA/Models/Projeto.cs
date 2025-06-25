using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks_ProjetoDA.Models
{
    public class Projeto
    {
        
        [Key]public int Id { get; set; }

        public string Descricao { get; set; }
        public Projeto() { }

        public List<Tarefa> ListaTarefas { get; set; } = new List<Tarefa>();

        

    }
}

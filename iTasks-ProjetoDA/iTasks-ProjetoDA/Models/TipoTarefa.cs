using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTasks_ProjetoDA.Models
{
    public class TipoTarefa
    {
        [Key]public int Id { get; set; }
        public string Nome { get; set; }

        public List<Tarefa> Tarefas { get; set; } = new List<Tarefa>();

        public TipoTarefa() { }

        public TipoTarefa(int id , string nome) 
        {
            this.Id = id;
            this.Nome = nome;

        }
    }
}

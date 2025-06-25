using iTasks_ProjetoDA.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace iTasks_ProjetoDA.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        
        public Gestor Gestor { get; set; }
        public int IdGestor { get; set; }


       
        public Programador Programador { get; set; }
        public int ProgramadorId { get; set; }

        public Projeto Projeto { get; set; }
        public int ProjetoId { get; set; }
        


        public int OrdemExecucao { get; set; }
        public string Descricao { get; set; }


        public DateTime DataPrevistaInicio { get; set; }
        public DateTime DataPrevistaFim {  get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public DateTime DataCriacao { get; set; }

        public TipoTarefa TipoTarefa { get; set; }
        public int TipoTarefaId { get; set; }
        
         
        public int StoryPoints { get; set; }
        public EstadoAtual EstadoAtual { get; set; }

        


        public Tarefa() { }
        public Tarefa(Gestor idgestor, Programador idprogramador, int ordemexecucao, string descricao,
            DateTime dataprevistainicio, DateTime dataprevistafim, DateTime? datainicio, DateTime? datafim,
            DateTime datacriacao, TipoTarefa idtipotarefa , int storypoints ,EstadoAtual estadoatual) 
        {
            
            this.Gestor = idgestor;
            this.Programador = idprogramador;
            this.OrdemExecucao = ordemexecucao;
            this.Descricao = descricao;
            this.DataPrevistaInicio = dataprevistainicio;
            this.DataPrevistaFim = dataprevistafim;
            this.DataInicio = null;
            this.DataFim = null;
            this.DataCriacao = datacriacao;
            this.TipoTarefa = idtipotarefa;
            this.StoryPoints = storypoints;
            this.EstadoAtual = estadoatual;

        }

    }
}

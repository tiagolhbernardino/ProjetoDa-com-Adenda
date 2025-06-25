namespace iTasks_ProjetoDA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iTaskContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projetoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tarefas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdGestor = c.Int(nullable: false),
                        ProgramadorId = c.Int(nullable: false),
                        ProjetoId = c.Int(nullable: false),
                        OrdemExecucao = c.Int(nullable: false),
                        Descricao = c.String(),
                        DataPrevistaInicio = c.DateTime(nullable: false),
                        DataPrevistaFim = c.DateTime(nullable: false),
                        DataInicio = c.DateTime(),
                        DataFim = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        TipoTarefaId = c.Int(nullable: false),
                        StoryPoints = c.Int(nullable: false),
                        EstadoAtual = c.Int(nullable: false),
                        Gestor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadors", t => t.ProgramadorId, cascadeDelete: true)
                .ForeignKey("dbo.Utilizadors", t => t.Gestor_Id)
                .ForeignKey("dbo.Projetoes", t => t.ProjetoId, cascadeDelete: true)
                .ForeignKey("dbo.TipoTarefas", t => t.TipoTarefaId, cascadeDelete: true)
                .Index(t => t.ProgramadorId)
                .Index(t => t.ProjetoId)
                .Index(t => t.TipoTarefaId)
                .Index(t => t.Gestor_Id);
            
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Departamento = c.Int(),
                        GereUtilizadores = c.Boolean(),
                        NivelDeExperiencia = c.Int(),
                        IdGestor = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Gestor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadors", t => t.Gestor_Id)
                .Index(t => t.Gestor_Id);
            
            CreateTable(
                "dbo.TipoTarefas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tarefas", "TipoTarefaId", "dbo.TipoTarefas");
            DropForeignKey("dbo.Tarefas", "ProjetoId", "dbo.Projetoes");
            DropForeignKey("dbo.Tarefas", "Gestor_Id", "dbo.Utilizadors");
            DropForeignKey("dbo.Tarefas", "ProgramadorId", "dbo.Utilizadors");
            DropForeignKey("dbo.Utilizadors", "Gestor_Id", "dbo.Utilizadors");
            DropIndex("dbo.Utilizadors", new[] { "Gestor_Id" });
            DropIndex("dbo.Tarefas", new[] { "Gestor_Id" });
            DropIndex("dbo.Tarefas", new[] { "TipoTarefaId" });
            DropIndex("dbo.Tarefas", new[] { "ProjetoId" });
            DropIndex("dbo.Tarefas", new[] { "ProgramadorId" });
            DropTable("dbo.TipoTarefas");
            DropTable("dbo.Utilizadors");
            DropTable("dbo.Tarefas");
            DropTable("dbo.Projetoes");
        }
    }
}

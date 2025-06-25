namespace iTasks_ProjetoDA
{
    partial class KanbanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanbanForm));
            this.lvToDo = new System.Windows.Forms.ListView();
            this.IdTarefa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Programador = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDone = new System.Windows.Forms.ListView();
            this.lvDoing = new System.Windows.Forms.ListView();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblDoing = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblLogged = new System.Windows.Forms.Label();
            this.lblLoggedAs = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsProjetos = new System.Windows.Forms.ToolStripDropDownButton();
            this.criarProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemProjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGestaoUtilizadores = new System.Windows.Forms.ToolStripDropDownButton();
            this.tSCriarUtilizadores = new System.Windows.Forms.ToolStripMenuItem();
            this.tSGerirUtilizadores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGestaoTarefas = new System.Windows.Forms.ToolStripDropDownButton();
            this.tSCriarTarefas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCriarTiposTarefa = new System.Windows.Forms.ToolStripMenuItem();
            this.verTarefasPorFazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTarefasEmExecuçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTarefasTerminadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsVerMinhasTarefasConcluidas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGestorTarefasTerminadas = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefasCriadasTodasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnPorfazer = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.cBProjeto = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvToDo
            // 
            this.lvToDo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdTarefa,
            this.Descricao,
            this.Programador});
            this.lvToDo.HideSelection = false;
            this.lvToDo.Location = new System.Drawing.Point(329, 94);
            this.lvToDo.Name = "lvToDo";
            this.lvToDo.Size = new System.Drawing.Size(328, 606);
            this.lvToDo.TabIndex = 0;
            this.lvToDo.UseCompatibleStateImageBehavior = false;
            // 
            // lvDone
            // 
            this.lvDone.HideSelection = false;
            this.lvDone.Location = new System.Drawing.Point(1025, 94);
            this.lvDone.Name = "lvDone";
            this.lvDone.Size = new System.Drawing.Size(328, 606);
            this.lvDone.TabIndex = 1;
            this.lvDone.UseCompatibleStateImageBehavior = false;
            // 
            // lvDoing
            // 
            this.lvDoing.HideSelection = false;
            this.lvDoing.Location = new System.Drawing.Point(677, 94);
            this.lvDoing.Name = "lvDoing";
            this.lvDoing.Size = new System.Drawing.Size(328, 606);
            this.lvDoing.TabIndex = 2;
            this.lvDoing.UseCompatibleStateImageBehavior = false;
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblToDo.Location = new System.Drawing.Point(324, 62);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(80, 29);
            this.lblToDo.TabIndex = 3;
            this.lblToDo.Text = "To Do";
            // 
            // lblDoing
            // 
            this.lblDoing.AutoSize = true;
            this.lblDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoing.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDoing.Location = new System.Drawing.Point(672, 62);
            this.lblDoing.Name = "lblDoing";
            this.lblDoing.Size = new System.Drawing.Size(77, 29);
            this.lblDoing.TabIndex = 4;
            this.lblDoing.Text = "Doing";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDone.Location = new System.Drawing.Point(1020, 62);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(71, 29);
            this.lblDone.TabIndex = 5;
            this.lblDone.Text = "Done";
            // 
            // lblLogged
            // 
            this.lblLogged.AutoSize = true;
            this.lblLogged.Location = new System.Drawing.Point(12, 815);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(92, 20);
            this.lblLogged.TabIndex = 6;
            this.lblLogged.Text = "Logged as: ";
            // 
            // lblLoggedAs
            // 
            this.lblLoggedAs.AutoSize = true;
            this.lblLoggedAs.Location = new System.Drawing.Point(101, 815);
            this.lblLoggedAs.Name = "lblLoggedAs";
            this.lblLoggedAs.Size = new System.Drawing.Size(65, 20);
            this.lblLoggedAs.TabIndex = 7;
            this.lblLoggedAs.Text = "xxxxxxxx";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsProjetos,
            this.tsGestaoUtilizadores,
            this.tsGestaoTarefas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1378, 34);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tsProjetos
            // 
            this.tsProjetos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsProjetos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarProjetoToolStripMenuItem,
            this.listagemProjetosToolStripMenuItem});
            this.tsProjetos.Image = ((System.Drawing.Image)(resources.GetObject("tsProjetos.Image")));
            this.tsProjetos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsProjetos.Name = "tsProjetos";
            this.tsProjetos.Size = new System.Drawing.Size(181, 29);
            this.tsProjetos.Text = "Gestão de projetos";
            // 
            // criarProjetoToolStripMenuItem
            // 
            this.criarProjetoToolStripMenuItem.Name = "criarProjetoToolStripMenuItem";
            this.criarProjetoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.criarProjetoToolStripMenuItem.Text = "Criar Projeto";
            this.criarProjetoToolStripMenuItem.Click += new System.EventHandler(this.criarProjetoToolStripMenuItem_Click);
            // 
            // listagemProjetosToolStripMenuItem
            // 
            this.listagemProjetosToolStripMenuItem.Name = "listagemProjetosToolStripMenuItem";
            this.listagemProjetosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listagemProjetosToolStripMenuItem.Text = "Listagem Projetos";
            this.listagemProjetosToolStripMenuItem.Click += new System.EventHandler(this.listagemProjetosToolStripMenuItem_Click);
            // 
            // tsGestaoUtilizadores
            // 
            this.tsGestaoUtilizadores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsGestaoUtilizadores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSCriarUtilizadores,
            this.tSGerirUtilizadores});
            this.tsGestaoUtilizadores.Image = ((System.Drawing.Image)(resources.GetObject("tsGestaoUtilizadores.Image")));
            this.tsGestaoUtilizadores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGestaoUtilizadores.Name = "tsGestaoUtilizadores";
            this.tsGestaoUtilizadores.Size = new System.Drawing.Size(182, 29);
            this.tsGestaoUtilizadores.Text = "Gestao Utilizadores";
            // 
            // tSCriarUtilizadores
            // 
            this.tSCriarUtilizadores.Name = "tSCriarUtilizadores";
            this.tSCriarUtilizadores.Size = new System.Drawing.Size(248, 34);
            this.tSCriarUtilizadores.Text = "Criar Utilizadores";
            this.tSCriarUtilizadores.Click += new System.EventHandler(this.tSCriarUtilizadores_Click);
            // 
            // tSGerirUtilizadores
            // 
            this.tSGerirUtilizadores.Name = "tSGerirUtilizadores";
            this.tSGerirUtilizadores.Size = new System.Drawing.Size(248, 34);
            this.tSGerirUtilizadores.Text = "Gerir Utilizadores";
            // 
            // tsGestaoTarefas
            // 
            this.tsGestaoTarefas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsGestaoTarefas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSCriarTarefas,
            this.tsCriarTiposTarefa,
            this.verTarefasPorFazerToolStripMenuItem,
            this.verTarefasEmExecuçãoToolStripMenuItem,
            this.verTarefasTerminadasToolStripMenuItem,
            this.tsVerMinhasTarefasConcluidas,
            this.tsGestorTarefasTerminadas,
            this.tarefasCriadasTodasToolStripMenuItem});
            this.tsGestaoTarefas.Image = ((System.Drawing.Image)(resources.GetObject("tsGestaoTarefas.Image")));
            this.tsGestaoTarefas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGestaoTarefas.Name = "tsGestaoTarefas";
            this.tsGestaoTarefas.Size = new System.Drawing.Size(168, 29);
            this.tsGestaoTarefas.Text = "Gestão de tarefas";
            // 
            // tSCriarTarefas
            // 
            this.tSCriarTarefas.Name = "tSCriarTarefas";
            this.tSCriarTarefas.Size = new System.Drawing.Size(373, 34);
            this.tSCriarTarefas.Text = "Criar Tarefas";
            this.tSCriarTarefas.Click += new System.EventHandler(this.tSCriarTarefas_Click);
            // 
            // tsCriarTiposTarefa
            // 
            this.tsCriarTiposTarefa.Name = "tsCriarTiposTarefa";
            this.tsCriarTiposTarefa.Size = new System.Drawing.Size(373, 34);
            this.tsCriarTiposTarefa.Text = "Criar TiposTarefa";
            this.tsCriarTiposTarefa.Click += new System.EventHandler(this.tsCriarTiposTarefa_Click);
            // 
            // verTarefasPorFazerToolStripMenuItem
            // 
            this.verTarefasPorFazerToolStripMenuItem.Name = "verTarefasPorFazerToolStripMenuItem";
            this.verTarefasPorFazerToolStripMenuItem.Size = new System.Drawing.Size(373, 34);
            this.verTarefasPorFazerToolStripMenuItem.Text = "Ver Tarefas Por Fazer";
            this.verTarefasPorFazerToolStripMenuItem.Click += new System.EventHandler(this.verTarefasPorFazerToolStripMenuItem_Click);
            // 
            // verTarefasEmExecuçãoToolStripMenuItem
            // 
            this.verTarefasEmExecuçãoToolStripMenuItem.Name = "verTarefasEmExecuçãoToolStripMenuItem";
            this.verTarefasEmExecuçãoToolStripMenuItem.Size = new System.Drawing.Size(373, 34);
            this.verTarefasEmExecuçãoToolStripMenuItem.Text = "Ver Tarefas em Execução";
            this.verTarefasEmExecuçãoToolStripMenuItem.Click += new System.EventHandler(this.verTarefasEmExecuçãoToolStripMenuItem_Click);
            // 
            // verTarefasTerminadasToolStripMenuItem
            // 
            this.verTarefasTerminadasToolStripMenuItem.Name = "verTarefasTerminadasToolStripMenuItem";
            this.verTarefasTerminadasToolStripMenuItem.Size = new System.Drawing.Size(373, 34);
            this.verTarefasTerminadasToolStripMenuItem.Text = "Ver Tarefas Terminadas";
            this.verTarefasTerminadasToolStripMenuItem.Click += new System.EventHandler(this.verTarefasTerminadasToolStripMenuItem_Click);
            // 
            // tsVerMinhasTarefasConcluidas
            // 
            this.tsVerMinhasTarefasConcluidas.Name = "tsVerMinhasTarefasConcluidas";
            this.tsVerMinhasTarefasConcluidas.Size = new System.Drawing.Size(373, 34);
            this.tsVerMinhasTarefasConcluidas.Text = "Ver as Minhas Tarefas Concluidas";
            this.tsVerMinhasTarefasConcluidas.Click += new System.EventHandler(this.verAsMinhasTarefasConcluidasToolStripMenuItem_Click);
            // 
            // tsGestorTarefasTerminadas
            // 
            this.tsGestorTarefasTerminadas.Name = "tsGestorTarefasTerminadas";
            this.tsGestorTarefasTerminadas.Size = new System.Drawing.Size(373, 34);
            this.tsGestorTarefasTerminadas.Text = "Tarefas Criadas - Terminadas";
            this.tsGestorTarefasTerminadas.Click += new System.EventHandler(this.tarefasCriadasTerminadasToolStripMenuItem_Click);
            // 
            // tarefasCriadasTodasToolStripMenuItem
            // 
           
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(329, 706);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(328, 37);
            this.btnExecutar.TabIndex = 9;
            this.btnExecutar.Text = "Executar >>";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnPorfazer
            // 
            this.btnPorfazer.Location = new System.Drawing.Point(677, 706);
            this.btnPorfazer.Name = "btnPorfazer";
            this.btnPorfazer.Size = new System.Drawing.Size(328, 37);
            this.btnPorfazer.TabIndex = 10;
            this.btnPorfazer.Text = "<< Por Fazer";
            this.btnPorfazer.UseVisualStyleBackColor = true;
            this.btnPorfazer.Click += new System.EventHandler(this.btnPorfazer_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(1025, 706);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(328, 37);
            this.btnTerminar.TabIndex = 11;
            this.btnTerminar.Text = "Terminar >>";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // lblProjeto
            // 
            this.lblProjeto.AutoSize = true;
            this.lblProjeto.Location = new System.Drawing.Point(29, 94);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(59, 20);
            this.lblProjeto.TabIndex = 12;
            this.lblProjeto.Text = "Projeto";
            // 
            // cBProjeto
            // 
            this.cBProjeto.FormattingEnabled = true;
            this.cBProjeto.Location = new System.Drawing.Point(105, 94);
            this.cBProjeto.Name = "cBProjeto";
            this.cBProjeto.Size = new System.Drawing.Size(185, 28);
            this.cBProjeto.TabIndex = 13;
            // 
            // KanbanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.cBProjeto);
            this.Controls.Add(this.lblProjeto);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnPorfazer);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblLoggedAs);
            this.Controls.Add(this.lblLogged);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblDoing);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.lvDoing);
            this.Controls.Add(this.lvDone);
            this.Controls.Add(this.lvToDo);
            this.Name = "KanbanForm";
            this.Text = "KanbanForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvToDo;
        private System.Windows.Forms.ListView lvDone;
        private System.Windows.Forms.ListView lvDoing;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblDoing;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Label lblLogged;
        private System.Windows.Forms.Label lblLoggedAs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsGestaoUtilizadores;
        private System.Windows.Forms.ToolStripMenuItem tSCriarUtilizadores;
        private System.Windows.Forms.ToolStripDropDownButton tsGestaoTarefas;
        private System.Windows.Forms.ToolStripMenuItem verTarefasPorFazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTarefasEmExecuçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTarefasTerminadasToolStripMenuItem;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ToolStripMenuItem tsCriarTiposTarefa;
        private System.Windows.Forms.ToolStripMenuItem tSGerirUtilizadores;
        private System.Windows.Forms.ToolStripMenuItem tSCriarTarefas;
        private System.Windows.Forms.ColumnHeader IdTarefa;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.Button btnPorfazer;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label lblProjeto;
        private System.Windows.Forms.ColumnHeader Programador;
        private System.Windows.Forms.ToolStripDropDownButton tsProjetos;
        private System.Windows.Forms.ToolStripMenuItem tsVerMinhasTarefasConcluidas;
        private System.Windows.Forms.ToolStripMenuItem tsGestorTarefasTerminadas;
        private System.Windows.Forms.ComboBox cBProjeto;
        private System.Windows.Forms.ToolStripMenuItem tarefasCriadasTodasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarProjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemProjetosToolStripMenuItem;
    }
}
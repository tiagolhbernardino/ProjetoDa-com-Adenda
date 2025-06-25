namespace iTasks_ProjetoDA
{
    partial class CriarTarefaForm
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
            this.lblId = new System.Windows.Forms.Label();
            this.tBId = new System.Windows.Forms.TextBox();
            this.lblDataRealInicio = new System.Windows.Forms.Label();
            this.tBDataRealInicio = new System.Windows.Forms.TextBox();
            this.lblDataRealFim = new System.Windows.Forms.Label();
            this.tBDataRealFim = new System.Windows.Forms.TextBox();
            this.lblEstadoAtual = new System.Windows.Forms.Label();
            this.cBEstado = new System.Windows.Forms.ComboBox();
            this.lblDataCriacao = new System.Windows.Forms.Label();
            this.tBDataDeCriacao = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tBDescricao = new System.Windows.Forms.TextBox();
            this.lblTipoDeTarefa = new System.Windows.Forms.Label();
            this.cBTipoTarefa = new System.Windows.Forms.ComboBox();
            this.lblProgramador = new System.Windows.Forms.Label();
            this.cBProgramador = new System.Windows.Forms.ComboBox();
            this.lblOrdem = new System.Windows.Forms.Label();
            this.tBOrdem = new System.Windows.Forms.TextBox();
            this.lblStoryPoints = new System.Windows.Forms.Label();
            this.tBStoryPoints = new System.Windows.Forms.TextBox();
            this.lblPrevisaoInicio = new System.Windows.Forms.Label();
            this.lblPrevisaoFim = new System.Windows.Forms.Label();
            this.dPInicio = new System.Windows.Forms.DateTimePicker();
            this.dPFim = new System.Windows.Forms.DateTimePicker();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cBProjeto = new System.Windows.Forms.ComboBox();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(92, 59);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // tBId
            // 
            this.tBId.Location = new System.Drawing.Point(255, 59);
            this.tBId.Name = "tBId";
            this.tBId.ReadOnly = true;
            this.tBId.Size = new System.Drawing.Size(135, 26);
            this.tBId.TabIndex = 1;
            // 
            // lblDataRealInicio
            // 
            this.lblDataRealInicio.AutoSize = true;
            this.lblDataRealInicio.Location = new System.Drawing.Point(92, 113);
            this.lblDataRealInicio.Name = "lblDataRealInicio";
            this.lblDataRealInicio.Size = new System.Drawing.Size(135, 20);
            this.lblDataRealInicio.TabIndex = 2;
            this.lblDataRealInicio.Text = "Data real de inicio";
            // 
            // tBDataRealInicio
            // 
            this.tBDataRealInicio.Location = new System.Drawing.Point(255, 113);
            this.tBDataRealInicio.Name = "tBDataRealInicio";
            this.tBDataRealInicio.ReadOnly = true;
            this.tBDataRealInicio.Size = new System.Drawing.Size(135, 26);
            this.tBDataRealInicio.TabIndex = 3;
            // 
            // lblDataRealFim
            // 
            this.lblDataRealFim.AutoSize = true;
            this.lblDataRealFim.Location = new System.Drawing.Point(92, 163);
            this.lblDataRealFim.Name = "lblDataRealFim";
            this.lblDataRealFim.Size = new System.Drawing.Size(121, 20);
            this.lblDataRealFim.TabIndex = 4;
            this.lblDataRealFim.Text = "Data real de fim";
            // 
            // tBDataRealFim
            // 
            this.tBDataRealFim.Location = new System.Drawing.Point(255, 163);
            this.tBDataRealFim.Name = "tBDataRealFim";
            this.tBDataRealFim.ReadOnly = true;
            this.tBDataRealFim.Size = new System.Drawing.Size(135, 26);
            this.tBDataRealFim.TabIndex = 5;
            // 
            // lblEstadoAtual
            // 
            this.lblEstadoAtual.AutoSize = true;
            this.lblEstadoAtual.Location = new System.Drawing.Point(644, 65);
            this.lblEstadoAtual.Name = "lblEstadoAtual";
            this.lblEstadoAtual.Size = new System.Drawing.Size(101, 20);
            this.lblEstadoAtual.TabIndex = 6;
            this.lblEstadoAtual.Text = "Estado Atual";
            // 
            // cBEstado
            // 
            this.cBEstado.FormattingEnabled = true;
            this.cBEstado.Location = new System.Drawing.Point(794, 65);
            this.cBEstado.Name = "cBEstado";
            this.cBEstado.Size = new System.Drawing.Size(135, 28);
            this.cBEstado.TabIndex = 7;
            // 
            // lblDataCriacao
            // 
            this.lblDataCriacao.AutoSize = true;
            this.lblDataCriacao.Location = new System.Drawing.Point(644, 119);
            this.lblDataCriacao.Name = "lblDataCriacao";
            this.lblDataCriacao.Size = new System.Drawing.Size(121, 20);
            this.lblDataCriacao.TabIndex = 8;
            this.lblDataCriacao.Text = "Data de criação";
            // 
            // tBDataDeCriacao
            // 
            this.tBDataDeCriacao.Location = new System.Drawing.Point(794, 119);
            this.tBDataDeCriacao.Name = "tBDataDeCriacao";
            this.tBDataDeCriacao.ReadOnly = true;
            this.tBDataDeCriacao.Size = new System.Drawing.Size(135, 26);
            this.tBDataDeCriacao.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(-15, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1419, 10);
            this.panel1.TabIndex = 10;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(92, 313);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 11;
            this.lblDescricao.Text = "Descrição";
            // 
            // tBDescricao
            // 
            this.tBDescricao.Location = new System.Drawing.Point(255, 313);
            this.tBDescricao.Multiline = true;
            this.tBDescricao.Name = "tBDescricao";
            this.tBDescricao.Size = new System.Drawing.Size(1013, 63);
            this.tBDescricao.TabIndex = 12;
            // 
            // lblTipoDeTarefa
            // 
            this.lblTipoDeTarefa.AutoSize = true;
            this.lblTipoDeTarefa.Location = new System.Drawing.Point(92, 406);
            this.lblTipoDeTarefa.Name = "lblTipoDeTarefa";
            this.lblTipoDeTarefa.Size = new System.Drawing.Size(111, 20);
            this.lblTipoDeTarefa.TabIndex = 13;
            this.lblTipoDeTarefa.Text = "Tipo de Tarefa";
            // 
            // cBTipoTarefa
            // 
            this.cBTipoTarefa.FormattingEnabled = true;
            this.cBTipoTarefa.Location = new System.Drawing.Point(255, 406);
            this.cBTipoTarefa.Name = "cBTipoTarefa";
            this.cBTipoTarefa.Size = new System.Drawing.Size(352, 28);
            this.cBTipoTarefa.TabIndex = 14;
            // 
            // lblProgramador
            // 
            this.lblProgramador.AutoSize = true;
            this.lblProgramador.Location = new System.Drawing.Point(92, 459);
            this.lblProgramador.Name = "lblProgramador";
            this.lblProgramador.Size = new System.Drawing.Size(101, 20);
            this.lblProgramador.TabIndex = 15;
            this.lblProgramador.Text = "Programador";
            // 
            // cBProgramador
            // 
            this.cBProgramador.FormattingEnabled = true;
            this.cBProgramador.Location = new System.Drawing.Point(255, 459);
            this.cBProgramador.Name = "cBProgramador";
            this.cBProgramador.Size = new System.Drawing.Size(352, 28);
            this.cBProgramador.TabIndex = 16;
            // 
            // lblOrdem
            // 
            this.lblOrdem.AutoSize = true;
            this.lblOrdem.Location = new System.Drawing.Point(92, 510);
            this.lblOrdem.Name = "lblOrdem";
            this.lblOrdem.Size = new System.Drawing.Size(57, 20);
            this.lblOrdem.TabIndex = 17;
            this.lblOrdem.Text = "Ordem";
            // 
            // tBOrdem
            // 
            this.tBOrdem.Location = new System.Drawing.Point(255, 510);
            this.tBOrdem.Name = "tBOrdem";
            this.tBOrdem.Size = new System.Drawing.Size(135, 26);
            this.tBOrdem.TabIndex = 18;
            // 
            // lblStoryPoints
            // 
            this.lblStoryPoints.AutoSize = true;
            this.lblStoryPoints.Location = new System.Drawing.Point(92, 562);
            this.lblStoryPoints.Name = "lblStoryPoints";
            this.lblStoryPoints.Size = new System.Drawing.Size(94, 20);
            this.lblStoryPoints.TabIndex = 19;
            this.lblStoryPoints.Text = "Story Points";
            // 
            // tBStoryPoints
            // 
            this.tBStoryPoints.Location = new System.Drawing.Point(255, 559);
            this.tBStoryPoints.Name = "tBStoryPoints";
            this.tBStoryPoints.Size = new System.Drawing.Size(135, 26);
            this.tBStoryPoints.TabIndex = 20;
            // 
            // lblPrevisaoInicio
            // 
            this.lblPrevisaoInicio.AutoSize = true;
            this.lblPrevisaoInicio.Location = new System.Drawing.Point(92, 619);
            this.lblPrevisaoInicio.Name = "lblPrevisaoInicio";
            this.lblPrevisaoInicio.Size = new System.Drawing.Size(130, 20);
            this.lblPrevisaoInicio.TabIndex = 21;
            this.lblPrevisaoInicio.Text = "Previsao de inicio";
            // 
            // lblPrevisaoFim
            // 
            this.lblPrevisaoFim.AutoSize = true;
            this.lblPrevisaoFim.Location = new System.Drawing.Point(92, 677);
            this.lblPrevisaoFim.Name = "lblPrevisaoFim";
            this.lblPrevisaoFim.Size = new System.Drawing.Size(121, 20);
            this.lblPrevisaoFim.TabIndex = 22;
            this.lblPrevisaoFim.Text = "Previsao de Fim";
            // 
            // dPInicio
            // 
            this.dPInicio.Location = new System.Drawing.Point(255, 619);
            this.dPInicio.Name = "dPInicio";
            this.dPInicio.Size = new System.Drawing.Size(243, 26);
            this.dPInicio.TabIndex = 24;
            // 
            // dPFim
            // 
            this.dPFim.Location = new System.Drawing.Point(255, 677);
            this.dPFim.Name = "dPFim";
            this.dPFim.Size = new System.Drawing.Size(243, 26);
            this.dPFim.TabIndex = 25;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(96, 732);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(279, 46);
            this.btnCriar.TabIndex = 26;
            this.btnCriar.Text = "Gravar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(381, 732);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(226, 46);
            this.btnFechar.TabIndex = 27;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cBProjeto
            // 
            this.cBProjeto.FormattingEnabled = true;
            this.cBProjeto.Location = new System.Drawing.Point(886, 406);
            this.cBProjeto.Name = "cBProjeto";
            this.cBProjeto.Size = new System.Drawing.Size(352, 28);
            this.cBProjeto.TabIndex = 28;
            // 
            // lblProjeto
            // 
            this.lblProjeto.AutoSize = true;
            this.lblProjeto.Location = new System.Drawing.Point(756, 409);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(59, 20);
            this.lblProjeto.TabIndex = 29;
            this.lblProjeto.Text = "Projeto";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1107, 732);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(226, 46);
            this.btnAtualizar.TabIndex = 30;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // CriarTarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lblProjeto);
            this.Controls.Add(this.cBProjeto);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.dPFim);
            this.Controls.Add(this.dPInicio);
            this.Controls.Add(this.lblPrevisaoFim);
            this.Controls.Add(this.lblPrevisaoInicio);
            this.Controls.Add(this.tBStoryPoints);
            this.Controls.Add(this.lblStoryPoints);
            this.Controls.Add(this.tBOrdem);
            this.Controls.Add(this.lblOrdem);
            this.Controls.Add(this.cBProgramador);
            this.Controls.Add(this.lblProgramador);
            this.Controls.Add(this.cBTipoTarefa);
            this.Controls.Add(this.lblTipoDeTarefa);
            this.Controls.Add(this.tBDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tBDataDeCriacao);
            this.Controls.Add(this.lblDataCriacao);
            this.Controls.Add(this.cBEstado);
            this.Controls.Add(this.lblEstadoAtual);
            this.Controls.Add(this.tBDataRealFim);
            this.Controls.Add(this.lblDataRealFim);
            this.Controls.Add(this.tBDataRealInicio);
            this.Controls.Add(this.lblDataRealInicio);
            this.Controls.Add(this.tBId);
            this.Controls.Add(this.lblId);
            this.Name = "CriarTarefaForm";
            this.Text = "CriarTarefaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tBId;
        private System.Windows.Forms.Label lblDataRealInicio;
        private System.Windows.Forms.TextBox tBDataRealInicio;
        private System.Windows.Forms.Label lblDataRealFim;
        private System.Windows.Forms.TextBox tBDataRealFim;
        private System.Windows.Forms.Label lblEstadoAtual;
        private System.Windows.Forms.ComboBox cBEstado;
        private System.Windows.Forms.Label lblDataCriacao;
        private System.Windows.Forms.TextBox tBDataDeCriacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tBDescricao;
        private System.Windows.Forms.Label lblTipoDeTarefa;
        private System.Windows.Forms.ComboBox cBTipoTarefa;
        private System.Windows.Forms.Label lblProgramador;
        private System.Windows.Forms.ComboBox cBProgramador;
        private System.Windows.Forms.Label lblOrdem;
        private System.Windows.Forms.TextBox tBOrdem;
        private System.Windows.Forms.Label lblStoryPoints;
        private System.Windows.Forms.TextBox tBStoryPoints;
        private System.Windows.Forms.Label lblPrevisaoInicio;
        private System.Windows.Forms.Label lblPrevisaoFim;
        private System.Windows.Forms.DateTimePicker dPInicio;
        private System.Windows.Forms.DateTimePicker dPFim;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cBProjeto;
        private System.Windows.Forms.Label lblProjeto;
        private System.Windows.Forms.Button btnAtualizar;
    }
}
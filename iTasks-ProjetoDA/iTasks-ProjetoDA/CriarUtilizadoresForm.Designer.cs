namespace iTasks_ProjetoDA
{
    partial class CriarUtilizadoresForm
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
            this.lblNome = new System.Windows.Forms.Label();
            this.tBNome = new System.Windows.Forms.TextBox();
            this.tBId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.tBUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gBProgramador = new System.Windows.Forms.GroupBox();
            this.cBExperiencia = new System.Windows.Forms.ComboBox();
            this.lblIdGestor = new System.Windows.Forms.Label();
            this.lblExperiencia = new System.Windows.Forms.Label();
            this.gBGestor = new System.Windows.Forms.GroupBox();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rBSim = new System.Windows.Forms.RadioButton();
            this.cBDepartamento = new System.Windows.Forms.ComboBox();
            this.lblGereUtilizadores = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.rBProgramador = new System.Windows.Forms.RadioButton();
            this.rBGestor = new System.Windows.Forms.RadioButton();
            this.lvTodosUtilizadores = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUtilizadores = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnVerDetalhes = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cBIdGestor = new System.Windows.Forms.ComboBox();
            this.gBProgramador.SuspendLayout();
            this.gBGestor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(31, 54);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tBNome
            // 
            this.tBNome.Location = new System.Drawing.Point(169, 54);
            this.tBNome.Name = "tBNome";
            this.tBNome.Size = new System.Drawing.Size(248, 26);
            this.tBNome.TabIndex = 1;
            // 
            // tBId
            // 
            this.tBId.Location = new System.Drawing.Point(169, 106);
            this.tBId.Name = "tBId";
            this.tBId.ReadOnly = true;
            this.tBId.Size = new System.Drawing.Size(248, 26);
            this.tBId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(31, 106);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // tBUsername
            // 
            this.tBUsername.Location = new System.Drawing.Point(169, 163);
            this.tBUsername.Name = "tBUsername";
            this.tBUsername.Size = new System.Drawing.Size(248, 26);
            this.tBUsername.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(31, 163);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // tBPassword
            // 
            this.tBPassword.Location = new System.Drawing.Point(169, 223);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(248, 26);
            this.tBPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(31, 223);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // gBProgramador
            // 
            this.gBProgramador.Controls.Add(this.cBIdGestor);
            this.gBProgramador.Controls.Add(this.cBExperiencia);
            this.gBProgramador.Controls.Add(this.lblIdGestor);
            this.gBProgramador.Controls.Add(this.lblExperiencia);
            this.gBProgramador.Location = new System.Drawing.Point(35, 333);
            this.gBProgramador.Name = "gBProgramador";
            this.gBProgramador.Size = new System.Drawing.Size(382, 201);
            this.gBProgramador.TabIndex = 8;
            this.gBProgramador.TabStop = false;
            this.gBProgramador.Text = "Programador";
            this.gBProgramador.Visible = false;
            // 
            // cBExperiencia
            // 
            this.cBExperiencia.FormattingEnabled = true;
            this.cBExperiencia.Location = new System.Drawing.Point(163, 58);
            this.cBExperiencia.Name = "cBExperiencia";
            this.cBExperiencia.Size = new System.Drawing.Size(197, 28);
            this.cBExperiencia.TabIndex = 12;
            // 
            // lblIdGestor
            // 
            this.lblIdGestor.AutoSize = true;
            this.lblIdGestor.Location = new System.Drawing.Point(28, 121);
            this.lblIdGestor.Name = "lblIdGestor";
            this.lblIdGestor.Size = new System.Drawing.Size(79, 20);
            this.lblIdGestor.TabIndex = 10;
            this.lblIdGestor.Text = "ID Gestor";
            // 
            // lblExperiencia
            // 
            this.lblExperiencia.AutoSize = true;
            this.lblExperiencia.Location = new System.Drawing.Point(28, 61);
            this.lblExperiencia.Name = "lblExperiencia";
            this.lblExperiencia.Size = new System.Drawing.Size(91, 20);
            this.lblExperiencia.TabIndex = 8;
            this.lblExperiencia.Text = "Experiencia";
            // 
            // gBGestor
            // 
            this.gBGestor.Controls.Add(this.rbNao);
            this.gBGestor.Controls.Add(this.rBSim);
            this.gBGestor.Controls.Add(this.cBDepartamento);
            this.gBGestor.Controls.Add(this.lblGereUtilizadores);
            this.gBGestor.Controls.Add(this.lblDepartamento);
            this.gBGestor.Location = new System.Drawing.Point(35, 554);
            this.gBGestor.Name = "gBGestor";
            this.gBGestor.Size = new System.Drawing.Size(382, 201);
            this.gBGestor.TabIndex = 9;
            this.gBGestor.TabStop = false;
            this.gBGestor.Text = "Gestor";
            this.gBGestor.Visible = false;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(264, 117);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(63, 24);
            this.rbNao.TabIndex = 18;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Nao";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // rBSim
            // 
            this.rBSim.AutoSize = true;
            this.rBSim.Location = new System.Drawing.Point(173, 117);
            this.rBSim.Name = "rBSim";
            this.rBSim.Size = new System.Drawing.Size(61, 24);
            this.rBSim.TabIndex = 17;
            this.rBSim.TabStop = true;
            this.rBSim.Text = "Sim";
            this.rBSim.UseVisualStyleBackColor = true;
            this.rBSim.CheckedChanged += new System.EventHandler(this.rBSim_CheckedChanged);
            // 
            // cBDepartamento
            // 
            this.cBDepartamento.FormattingEnabled = true;
            this.cBDepartamento.Location = new System.Drawing.Point(163, 57);
            this.cBDepartamento.Name = "cBDepartamento";
            this.cBDepartamento.Size = new System.Drawing.Size(194, 28);
            this.cBDepartamento.TabIndex = 16;
            // 
            // lblGereUtilizadores
            // 
            this.lblGereUtilizadores.AutoSize = true;
            this.lblGereUtilizadores.Location = new System.Drawing.Point(25, 117);
            this.lblGereUtilizadores.Name = "lblGereUtilizadores";
            this.lblGereUtilizadores.Size = new System.Drawing.Size(129, 20);
            this.lblGereUtilizadores.TabIndex = 14;
            this.lblGereUtilizadores.Text = "Gere Utlizadores";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(25, 57);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(112, 20);
            this.lblDepartamento.TabIndex = 12;
            this.lblDepartamento.Text = "Departamento";
            // 
            // rBProgramador
            // 
            this.rBProgramador.AutoSize = true;
            this.rBProgramador.Location = new System.Drawing.Point(35, 291);
            this.rBProgramador.Name = "rBProgramador";
            this.rBProgramador.Size = new System.Drawing.Size(126, 24);
            this.rBProgramador.TabIndex = 0;
            this.rBProgramador.TabStop = true;
            this.rBProgramador.Text = "Programador";
            this.rBProgramador.UseVisualStyleBackColor = true;
            this.rBProgramador.CheckedChanged += new System.EventHandler(this.rBProgramador_CheckedChanged);
            // 
            // rBGestor
            // 
            this.rBGestor.AutoSize = true;
            this.rBGestor.Location = new System.Drawing.Point(208, 291);
            this.rBGestor.Name = "rBGestor";
            this.rBGestor.Size = new System.Drawing.Size(83, 24);
            this.rBGestor.TabIndex = 10;
            this.rBGestor.TabStop = true;
            this.rBGestor.Text = "Gestor";
            this.rBGestor.UseVisualStyleBackColor = true;
            this.rBGestor.CheckedChanged += new System.EventHandler(this.rBGestor_CheckedChanged);
            // 
            // lvTodosUtilizadores
            // 
            this.lvTodosUtilizadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nome});
            this.lvTodosUtilizadores.HideSelection = false;
            this.lvTodosUtilizadores.Location = new System.Drawing.Point(442, 83);
            this.lvTodosUtilizadores.Name = "lvTodosUtilizadores";
            this.lvTodosUtilizadores.Size = new System.Drawing.Size(401, 672);
            this.lvTodosUtilizadores.TabIndex = 11;
            this.lvTodosUtilizadores.UseCompatibleStateImageBehavior = false;
            this.lvTodosUtilizadores.SelectedIndexChanged += new System.EventHandler(this.lvTodosUtilizadores_SelectedIndexChanged);
            // 
            // lblUtilizadores
            // 
            this.lblUtilizadores.AutoSize = true;
            this.lblUtilizadores.Location = new System.Drawing.Point(682, 54);
            this.lblUtilizadores.Name = "lblUtilizadores";
            this.lblUtilizadores.Size = new System.Drawing.Size(161, 20);
            this.lblUtilizadores.TabIndex = 12;
            this.lblUtilizadores.Text = "Todos os Utilizadores";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(35, 770);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(325, 40);
            this.btnCriar.TabIndex = 13;
            this.btnCriar.Text = "Criar Utilizador";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnVerDetalhes
            // 
            this.btnVerDetalhes.Location = new System.Drawing.Point(366, 770);
            this.btnVerDetalhes.Name = "btnVerDetalhes";
            this.btnVerDetalhes.Size = new System.Drawing.Size(343, 40);
            this.btnVerDetalhes.TabIndex = 14;
            this.btnVerDetalhes.Text = "Ver Detalhes";
            this.btnVerDetalhes.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(715, 770);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(330, 40);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Atualizar Dados";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(1051, 770);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(315, 40);
            this.btnApagar.TabIndex = 16;
            this.btnApagar.Text = "Apagar Utilizador";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // cBIdGestor
            // 
            this.cBIdGestor.FormattingEnabled = true;
            this.cBIdGestor.Location = new System.Drawing.Point(163, 121);
            this.cBIdGestor.Name = "cBIdGestor";
            this.cBIdGestor.Size = new System.Drawing.Size(194, 28);
            this.cBIdGestor.TabIndex = 13;
            // 
            // CriarUtilizadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVerDetalhes);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.lblUtilizadores);
            this.Controls.Add(this.lvTodosUtilizadores);
            this.Controls.Add(this.rBGestor);
            this.Controls.Add(this.rBProgramador);
            this.Controls.Add(this.gBGestor);
            this.Controls.Add(this.gBProgramador);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tBUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tBId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tBNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CriarUtilizadoresForm";
            this.Text = "CriarUtilizadoresForm";
            this.gBProgramador.ResumeLayout(false);
            this.gBProgramador.PerformLayout();
            this.gBGestor.ResumeLayout(false);
            this.gBGestor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tBNome;
        private System.Windows.Forms.TextBox tBId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tBUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gBProgramador;
        private System.Windows.Forms.Label lblIdGestor;
        private System.Windows.Forms.Label lblExperiencia;
        private System.Windows.Forms.GroupBox gBGestor;
        private System.Windows.Forms.Label lblGereUtilizadores;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.RadioButton rBProgramador;
        private System.Windows.Forms.RadioButton rBGestor;
        private System.Windows.Forms.ListView lvTodosUtilizadores;
        private System.Windows.Forms.Label lblUtilizadores;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnVerDetalhes;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ComboBox cBExperiencia;
        private System.Windows.Forms.ComboBox cBDepartamento;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rBSim;
        private System.Windows.Forms.ComboBox cBIdGestor;
    }
}
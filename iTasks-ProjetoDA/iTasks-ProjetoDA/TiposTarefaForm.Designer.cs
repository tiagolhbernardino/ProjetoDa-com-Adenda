namespace iTasks_ProjetoDA
{
    partial class TiposTarefaForm
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
            this.lvTiposTarefas = new System.Windows.Forms.ListView();
            this.lblTiposTarefasExistentes = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tBNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvTiposTarefas
            // 
            this.lvTiposTarefas.HideSelection = false;
            this.lvTiposTarefas.Location = new System.Drawing.Point(32, 55);
            this.lvTiposTarefas.Name = "lvTiposTarefas";
            this.lvTiposTarefas.Size = new System.Drawing.Size(385, 751);
            this.lvTiposTarefas.TabIndex = 0;
            this.lvTiposTarefas.UseCompatibleStateImageBehavior = false;
            this.lvTiposTarefas.SelectedIndexChanged += new System.EventHandler(this.lvTiposTarefas_SelectedIndexChanged);
            // 
            // lblTiposTarefasExistentes
            // 
            this.lblTiposTarefasExistentes.AutoSize = true;
            this.lblTiposTarefasExistentes.Location = new System.Drawing.Point(32, 29);
            this.lblTiposTarefasExistentes.Name = "lblTiposTarefasExistentes";
            this.lblTiposTarefasExistentes.Size = new System.Drawing.Size(199, 20);
            this.lblTiposTarefasExistentes.TabIndex = 1;
            this.lblTiposTarefasExistentes.Text = "Tipos de tarefas existentes";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(434, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 20);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(533, 49);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(100, 26);
            this.tbId.TabIndex = 3;
            // 
            // tBNome
            // 
            this.tBNome.Location = new System.Drawing.Point(533, 104);
            this.tBNome.Multiline = true;
            this.tBNome.Name = "tBNome";
            this.tBNome.Size = new System.Drawing.Size(779, 106);
            this.tBNome.TabIndex = 5;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(434, 104);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(533, 227);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(142, 43);
            this.btnCriar.TabIndex = 6;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(697, 227);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(142, 43);
            this.btnVisualizar.TabIndex = 7;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(863, 227);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(142, 43);
            this.btnAtualizar.TabIndex = 8;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(1024, 227);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(142, 43);
            this.btnApagar.TabIndex = 9;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // TiposTarefaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.tBNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTiposTarefasExistentes);
            this.Controls.Add(this.lvTiposTarefas);
            this.Name = "TiposTarefaForm";
            this.Text = "TiposTarefaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvTiposTarefas;
        private System.Windows.Forms.Label lblTiposTarefasExistentes;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tBNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnApagar;
    }
}
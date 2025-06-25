namespace iTasks_ProjetoDA
{
    partial class GestaoDeProjetosForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblId = new System.Windows.Forms.Label();
            this.tBId = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tBDesccricao = new System.Windows.Forms.TextBox();
            this.btnCriarProjeto = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(441, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 731);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(35, 58);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 20);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Id:";
            // 
            // tBId
            // 
            this.tBId.Location = new System.Drawing.Point(144, 55);
            this.tBId.Name = "tBId";
            this.tBId.ReadOnly = true;
            this.tBId.Size = new System.Drawing.Size(232, 26);
            this.tBId.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(35, 119);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 20);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";
            // 
            // tBDesccricao
            // 
            this.tBDesccricao.Location = new System.Drawing.Point(144, 119);
            this.tBDesccricao.Multiline = true;
            this.tBDesccricao.Name = "tBDesccricao";
            this.tBDesccricao.Size = new System.Drawing.Size(232, 230);
            this.tBDesccricao.TabIndex = 4;
            // 
            // btnCriarProjeto
            // 
            this.btnCriarProjeto.Location = new System.Drawing.Point(39, 687);
            this.btnCriarProjeto.Name = "btnCriarProjeto";
            this.btnCriarProjeto.Size = new System.Drawing.Size(384, 48);
            this.btnCriarProjeto.TabIndex = 5;
            this.btnCriarProjeto.Text = "Criar Projeto";
            this.btnCriarProjeto.UseVisualStyleBackColor = true;
            this.btnCriarProjeto.Click += new System.EventHandler(this.btnCriarProjeto_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(39, 741);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(384, 48);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(935, 741);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(384, 48);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(894, 58);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(83, 20);
            this.lblPesquisar.TabIndex = 8;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(984, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 26);
            this.textBox1.TabIndex = 9;
            // 
            // GestaoDeProjetosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCriarProjeto);
            this.Controls.Add(this.tBDesccricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.tBId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.listView1);
            this.Name = "GestaoDeProjetosForm";
            this.Text = "GestaoDeProjetosFormForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tBId;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox tBDesccricao;
        private System.Windows.Forms.Button btnCriarProjeto;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox textBox1;
    }
}
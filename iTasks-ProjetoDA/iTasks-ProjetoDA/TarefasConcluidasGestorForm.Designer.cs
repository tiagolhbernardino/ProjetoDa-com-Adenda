namespace iTasks_ProjetoDA
{
    partial class TarefasConcluidasGestorForm
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
            this.lvTarefasTerminadas = new System.Windows.Forms.ListView();
            this.btnExportarCsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvTarefasTerminadas
            // 
            this.lvTarefasTerminadas.HideSelection = false;
            this.lvTarefasTerminadas.Location = new System.Drawing.Point(13, 13);
            this.lvTarefasTerminadas.Name = "lvTarefasTerminadas";
            this.lvTarefasTerminadas.Size = new System.Drawing.Size(1100, 819);
            this.lvTarefasTerminadas.TabIndex = 0;
            this.lvTarefasTerminadas.UseCompatibleStateImageBehavior = false;
            // 
            // btnExportarCsv
            // 
            this.btnExportarCsv.Location = new System.Drawing.Point(1119, 703);
            this.btnExportarCsv.Name = "btnExportarCsv";
            this.btnExportarCsv.Size = new System.Drawing.Size(247, 129);
            this.btnExportarCsv.TabIndex = 1;
            this.btnExportarCsv.Text = "Exportar";
            this.btnExportarCsv.UseVisualStyleBackColor = true;
            this.btnExportarCsv.Click += new System.EventHandler(this.btnExportarCsv_Click_1);
            // 
            // TarefasConcluidasGestorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.btnExportarCsv);
            this.Controls.Add(this.lvTarefasTerminadas);
            this.Name = "TarefasConcluidasGestorForm";
            this.Text = "TarefasConcluidasGestorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTarefasTerminadas;
        private System.Windows.Forms.Button btnExportarCsv;
    }
}
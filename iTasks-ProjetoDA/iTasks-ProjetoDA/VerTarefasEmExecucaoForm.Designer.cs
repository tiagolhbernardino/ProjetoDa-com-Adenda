namespace iTasks_ProjetoDA
{
    partial class VerTarefasEmExecucaoForm
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
            this.lvTarefasDoing = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvTarefasDoing
            // 
            this.lvTarefasDoing.HideSelection = false;
            this.lvTarefasDoing.Location = new System.Drawing.Point(13, 13);
            this.lvTarefasDoing.Name = "lvTarefasDoing";
            this.lvTarefasDoing.Size = new System.Drawing.Size(1353, 819);
            this.lvTarefasDoing.TabIndex = 0;
            this.lvTarefasDoing.UseCompatibleStateImageBehavior = false;
            // 
            // TarefasEmExecucaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.lvTarefasDoing);
            this.Name = "TarefasEmExecucaoForm";
            this.Text = "TarefasEmExecucaoForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTarefasDoing;
    }
}
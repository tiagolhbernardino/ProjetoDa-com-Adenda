namespace iTasks_ProjetoDA
{
    partial class TarefasEmCursoGestorForm
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
            this.lvEmCursoGestor = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvEmCursoGestor
            // 
            this.lvEmCursoGestor.HideSelection = false;
            this.lvEmCursoGestor.Location = new System.Drawing.Point(13, 13);
            this.lvEmCursoGestor.Name = "lvEmCursoGestor";
            this.lvEmCursoGestor.Size = new System.Drawing.Size(1353, 819);
            this.lvEmCursoGestor.TabIndex = 0;
            this.lvEmCursoGestor.UseCompatibleStateImageBehavior = false;
            // 
            // TarefasEmCursoGestorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.lvEmCursoGestor);
            this.Name = "TarefasEmCursoGestorForm";
            this.Text = "TodasAsTarefasGestorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEmCursoGestor;
    }
}
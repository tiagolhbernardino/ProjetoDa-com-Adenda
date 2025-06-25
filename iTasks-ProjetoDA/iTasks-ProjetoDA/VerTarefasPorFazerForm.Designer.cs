namespace iTasks_ProjetoDA
{
    partial class VerTarefasPorFazerForm
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
            this.lvTarefasToDo = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descrição = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvTarefasToDo
            // 
            this.lvTarefasToDo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Descrição});
            this.lvTarefasToDo.HideSelection = false;
            this.lvTarefasToDo.Location = new System.Drawing.Point(12, 12);
            this.lvTarefasToDo.Name = "lvTarefasToDo";
            this.lvTarefasToDo.Size = new System.Drawing.Size(1354, 820);
            this.lvTarefasToDo.TabIndex = 0;
            this.lvTarefasToDo.UseCompatibleStateImageBehavior = false;
            // 
            // VerTarefasPorFazerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.lvTarefasToDo);
            this.Name = "VerTarefasPorFazerForm";
            this.Text = "VerTarefasPorFazerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTarefasToDo;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Descrição;
    }
}
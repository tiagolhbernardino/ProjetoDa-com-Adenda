﻿namespace iTasks_ProjetoDA
{
    partial class VerAsMinhasTarefasConcluidasForm
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
            this.lvMinhasTarefasTerminadas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvMinhasTarefasTerminadas
            // 
            this.lvMinhasTarefasTerminadas.HideSelection = false;
            this.lvMinhasTarefasTerminadas.Location = new System.Drawing.Point(13, 13);
            this.lvMinhasTarefasTerminadas.Name = "lvMinhasTarefasTerminadas";
            this.lvMinhasTarefasTerminadas.Size = new System.Drawing.Size(1353, 819);
            this.lvMinhasTarefasTerminadas.TabIndex = 0;
            this.lvMinhasTarefasTerminadas.UseCompatibleStateImageBehavior = false;
            // 
            // VerAsMinhasTarefasConcluidasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.lvMinhasTarefasTerminadas);
            this.Name = "VerAsMinhasTarefasConcluidasForm";
            this.Text = "VerAsMinhasTarefasConcluidasForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMinhasTarefasTerminadas;
    }
}
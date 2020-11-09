namespace ProyectoCatedra_MDB_G01T
{
    partial class FrmAdmCursos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.btnaddcurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 403);
            this.panel1.TabIndex = 0;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label39.Location = new System.Drawing.Point(40, 23);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(284, 24);
            this.label39.TabIndex = 15;
            this.label39.Text = "Prestamo de equipo y materiales";
            // 
            // btnaddcurso
            // 
            this.btnaddcurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btnaddcurso.FlatAppearance.BorderSize = 0;
            this.btnaddcurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddcurso.ForeColor = System.Drawing.Color.White;
            this.btnaddcurso.Location = new System.Drawing.Point(124, 97);
            this.btnaddcurso.Name = "btnaddcurso";
            this.btnaddcurso.Size = new System.Drawing.Size(118, 35);
            this.btnaddcurso.TabIndex = 19;
            this.btnaddcurso.Text = "Agregar curso";
            this.btnaddcurso.UseVisualStyleBackColor = false;
            // 
            // FrmAdmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 572);
            this.Controls.Add(this.btnaddcurso);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmCursos";
            this.Text = "FrmAdmCursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btnaddcurso;
    }
}
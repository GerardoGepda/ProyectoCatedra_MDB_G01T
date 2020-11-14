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
            this.btnCrearcurso = new System.Windows.Forms.Button();
            this.btncategorias = new System.Windows.Forms.Button();
            this.btnaddgrupo = new System.Windows.Forms.Button();
            this.btnhorario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 507);
            this.panel1.TabIndex = 0;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label39.Location = new System.Drawing.Point(40, 23);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(300, 24);
            this.label39.TabIndex = 15;
            this.label39.Text = "Administración de cursos y grupos";
            // 
            // btnCrearcurso
            // 
            this.btnCrearcurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btnCrearcurso.FlatAppearance.BorderSize = 0;
            this.btnCrearcurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearcurso.ForeColor = System.Drawing.Color.White;
            this.btnCrearcurso.Location = new System.Drawing.Point(543, 15);
            this.btnCrearcurso.Name = "btnCrearcurso";
            this.btnCrearcurso.Size = new System.Drawing.Size(128, 42);
            this.btnCrearcurso.TabIndex = 28;
            this.btnCrearcurso.Text = "Crear curso";
            this.btnCrearcurso.UseVisualStyleBackColor = false;
            this.btnCrearcurso.Click += new System.EventHandler(this.btnCrearcurso_Click);
            // 
            // btncategorias
            // 
            this.btncategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btncategorias.FlatAppearance.BorderSize = 0;
            this.btncategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorias.ForeColor = System.Drawing.Color.White;
            this.btncategorias.Location = new System.Drawing.Point(681, 15);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Size = new System.Drawing.Size(128, 42);
            this.btncategorias.TabIndex = 29;
            this.btncategorias.Text = "Ver categorías";
            this.btncategorias.UseVisualStyleBackColor = false;
            this.btncategorias.Click += new System.EventHandler(this.btncategorias_Click);
            // 
            // btnaddgrupo
            // 
            this.btnaddgrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btnaddgrupo.FlatAppearance.BorderSize = 0;
            this.btnaddgrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddgrupo.ForeColor = System.Drawing.Color.White;
            this.btnaddgrupo.Location = new System.Drawing.Point(820, 15);
            this.btnaddgrupo.Name = "btnaddgrupo";
            this.btnaddgrupo.Size = new System.Drawing.Size(128, 42);
            this.btnaddgrupo.TabIndex = 30;
            this.btnaddgrupo.Text = "Crear grupo";
            this.btnaddgrupo.UseVisualStyleBackColor = false;
            // 
            // btnhorario
            // 
            this.btnhorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btnhorario.FlatAppearance.BorderSize = 0;
            this.btnhorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhorario.ForeColor = System.Drawing.Color.White;
            this.btnhorario.Location = new System.Drawing.Point(960, 15);
            this.btnhorario.Name = "btnhorario";
            this.btnhorario.Size = new System.Drawing.Size(128, 42);
            this.btnhorario.TabIndex = 31;
            this.btnhorario.Text = "Crear horario";
            this.btnhorario.UseVisualStyleBackColor = false;
            // 
            // FrmAdmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 572);
            this.Controls.Add(this.btnhorario);
            this.Controls.Add(this.btnaddgrupo);
            this.Controls.Add(this.btncategorias);
            this.Controls.Add(this.btnCrearcurso);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmCursos";
            this.Text = "FrmAdmCursos";
            this.Load += new System.EventHandler(this.FrmAdmCursos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btnCrearcurso;
        private System.Windows.Forms.Button btncategorias;
        private System.Windows.Forms.Button btnaddgrupo;
        private System.Windows.Forms.Button btnhorario;
    }
}
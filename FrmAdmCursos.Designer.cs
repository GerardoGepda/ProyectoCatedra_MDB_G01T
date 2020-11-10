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
            this.pnlcurso = new System.Windows.Forms.Panel();
            this.btnvergrupos = new System.Windows.Forms.Button();
            this.lblfechafintxt = new System.Windows.Forms.Label();
            this.lblfechafin = new System.Windows.Forms.Label();
            this.lblfechainiciotxt = new System.Windows.Forms.Label();
            this.lblfechainicio = new System.Windows.Forms.Label();
            this.btneditcurso = new System.Windows.Forms.Button();
            this.btndeletecurso = new System.Windows.Forms.Button();
            this.lblcategoriatxt = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lbldescripciontxt = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblnombrecurso = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlcurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pnlcurso);
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 507);
            this.panel1.TabIndex = 0;
            // 
            // pnlcurso
            // 
            this.pnlcurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlcurso.Controls.Add(this.btnvergrupos);
            this.pnlcurso.Controls.Add(this.lblfechafintxt);
            this.pnlcurso.Controls.Add(this.lblfechafin);
            this.pnlcurso.Controls.Add(this.lblfechainiciotxt);
            this.pnlcurso.Controls.Add(this.lblfechainicio);
            this.pnlcurso.Controls.Add(this.btneditcurso);
            this.pnlcurso.Controls.Add(this.btndeletecurso);
            this.pnlcurso.Controls.Add(this.lblcategoriatxt);
            this.pnlcurso.Controls.Add(this.lblcategoria);
            this.pnlcurso.Controls.Add(this.lbldescripciontxt);
            this.pnlcurso.Controls.Add(this.lbldescripcion);
            this.pnlcurso.Controls.Add(this.lblnombrecurso);
            this.pnlcurso.Location = new System.Drawing.Point(72, 38);
            this.pnlcurso.Name = "pnlcurso";
            this.pnlcurso.Size = new System.Drawing.Size(230, 286);
            this.pnlcurso.TabIndex = 1;
            // 
            // btnvergrupos
            // 
            this.btnvergrupos.BackColor = System.Drawing.Color.Gray;
            this.btnvergrupos.FlatAppearance.BorderSize = 0;
            this.btnvergrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvergrupos.ForeColor = System.Drawing.Color.White;
            this.btnvergrupos.Location = new System.Drawing.Point(20, 241);
            this.btnvergrupos.Name = "btnvergrupos";
            this.btnvergrupos.Size = new System.Drawing.Size(194, 30);
            this.btnvergrupos.TabIndex = 29;
            this.btnvergrupos.Text = "Ver grupos";
            this.btnvergrupos.UseVisualStyleBackColor = false;
            // 
            // lblfechafintxt
            // 
            this.lblfechafintxt.AutoSize = true;
            this.lblfechafintxt.Location = new System.Drawing.Point(114, 159);
            this.lblfechafintxt.Name = "lblfechafintxt";
            this.lblfechafintxt.Size = new System.Drawing.Size(62, 13);
            this.lblfechafintxt.TabIndex = 28;
            this.lblfechafintxt.Text = "categoría...";
            // 
            // lblfechafin
            // 
            this.lblfechafin.AutoSize = true;
            this.lblfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechafin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblfechafin.Location = new System.Drawing.Point(20, 157);
            this.lblfechafin.Name = "lblfechafin";
            this.lblfechafin.Size = new System.Drawing.Size(70, 15);
            this.lblfechafin.TabIndex = 27;
            this.lblfechafin.Text = "Fecha fin:";
            // 
            // lblfechainiciotxt
            // 
            this.lblfechainiciotxt.AutoSize = true;
            this.lblfechainiciotxt.Location = new System.Drawing.Point(114, 133);
            this.lblfechainiciotxt.Name = "lblfechainiciotxt";
            this.lblfechainiciotxt.Size = new System.Drawing.Size(62, 13);
            this.lblfechainiciotxt.TabIndex = 26;
            this.lblfechainiciotxt.Text = "categoría...";
            // 
            // lblfechainicio
            // 
            this.lblfechainicio.AutoSize = true;
            this.lblfechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechainicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblfechainicio.Location = new System.Drawing.Point(20, 131);
            this.lblfechainicio.Name = "lblfechainicio";
            this.lblfechainicio.Size = new System.Drawing.Size(89, 15);
            this.lblfechainicio.TabIndex = 25;
            this.lblfechainicio.Text = "Fecha inicio:";
            // 
            // btneditcurso
            // 
            this.btneditcurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btneditcurso.FlatAppearance.BorderSize = 0;
            this.btneditcurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditcurso.ForeColor = System.Drawing.Color.White;
            this.btneditcurso.Location = new System.Drawing.Point(20, 195);
            this.btneditcurso.Name = "btneditcurso";
            this.btneditcurso.Size = new System.Drawing.Size(86, 30);
            this.btneditcurso.TabIndex = 24;
            this.btneditcurso.Text = "Editar curso";
            this.btneditcurso.UseVisualStyleBackColor = false;
            // 
            // btndeletecurso
            // 
            this.btndeletecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndeletecurso.FlatAppearance.BorderSize = 0;
            this.btndeletecurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeletecurso.ForeColor = System.Drawing.Color.White;
            this.btndeletecurso.Location = new System.Drawing.Point(128, 195);
            this.btndeletecurso.Name = "btndeletecurso";
            this.btndeletecurso.Size = new System.Drawing.Size(86, 30);
            this.btndeletecurso.TabIndex = 8;
            this.btndeletecurso.Text = "Eliminar Curso";
            this.btndeletecurso.UseVisualStyleBackColor = false;
            // 
            // lblcategoriatxt
            // 
            this.lblcategoriatxt.AutoSize = true;
            this.lblcategoriatxt.Location = new System.Drawing.Point(103, 56);
            this.lblcategoriatxt.Name = "lblcategoriatxt";
            this.lblcategoriatxt.Size = new System.Drawing.Size(62, 13);
            this.lblcategoriatxt.TabIndex = 4;
            this.lblcategoriatxt.Text = "categoría...";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblcategoria.Location = new System.Drawing.Point(19, 54);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(73, 15);
            this.lblcategoria.TabIndex = 3;
            this.lblcategoria.Text = "Categoría:";
            // 
            // lbldescripciontxt
            // 
            this.lbldescripciontxt.Location = new System.Drawing.Point(20, 95);
            this.lbldescripciontxt.Name = "lbldescripciontxt";
            this.lbldescripciontxt.Size = new System.Drawing.Size(194, 34);
            this.lbldescripciontxt.TabIndex = 2;
            this.lbldescripciontxt.Text = "descripción...";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbldescripcion.Location = new System.Drawing.Point(19, 76);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(87, 15);
            this.lbldescripcion.TabIndex = 1;
            this.lbldescripcion.Text = "Descripción:";
            // 
            // lblnombrecurso
            // 
            this.lblnombrecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.lblnombrecurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombrecurso.ForeColor = System.Drawing.Color.White;
            this.lblnombrecurso.Location = new System.Drawing.Point(0, 0);
            this.lblnombrecurso.Name = "lblnombrecurso";
            this.lblnombrecurso.Size = new System.Drawing.Size(229, 42);
            this.lblnombrecurso.TabIndex = 0;
            this.lblnombrecurso.Tag = "";
            this.lblnombrecurso.Text = "Vacío";
            this.lblnombrecurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // FrmAdmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 572);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmCursos";
            this.Text = "FrmAdmCursos";
            this.Load += new System.EventHandler(this.FrmAdmCursos_Load);
            this.panel1.ResumeLayout(false);
            this.pnlcurso.ResumeLayout(false);
            this.pnlcurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel pnlcurso;
        private System.Windows.Forms.Button btndeletecurso;
        private System.Windows.Forms.Label lblcategoriatxt;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbldescripciontxt;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblnombrecurso;
        private System.Windows.Forms.Button btneditcurso;
        private System.Windows.Forms.Label lblfechafintxt;
        private System.Windows.Forms.Label lblfechafin;
        private System.Windows.Forms.Label lblfechainiciotxt;
        private System.Windows.Forms.Label lblfechainicio;
        private System.Windows.Forms.Button btnvergrupos;
    }
}
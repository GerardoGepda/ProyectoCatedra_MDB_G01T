namespace ProyectoCatedra_MDB_G01T
{
    partial class FrmAddGrupo
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
            this.cbxmaestros = new System.Windows.Forms.ComboBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.txtidgrupo = new System.Windows.Forms.TextBox();
            this.lblnombre1 = new System.Windows.Forms.Label();
            this.txtcupo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxcursos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.Text = "Crear grupo";
            // 
            // cbxmaestros
            // 
            this.cbxmaestros.BackColor = System.Drawing.Color.White;
            this.cbxmaestros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxmaestros.FormattingEnabled = true;
            this.cbxmaestros.Location = new System.Drawing.Point(593, 232);
            this.cbxmaestros.Name = "cbxmaestros";
            this.cbxmaestros.Size = new System.Drawing.Size(160, 21);
            this.cbxmaestros.TabIndex = 20;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Gray;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(355, 389);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(96, 30);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(413, 317);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(96, 30);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btncrear.FlatAppearance.BorderSize = 0;
            this.btncrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrear.ForeColor = System.Drawing.Color.White;
            this.btncrear.Location = new System.Drawing.Point(283, 317);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(96, 30);
            this.btncrear.TabIndex = 10;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // txtidgrupo
            // 
            this.txtidgrupo.Enabled = false;
            this.txtidgrupo.Location = new System.Drawing.Point(211, 177);
            this.txtidgrupo.Name = "txtidgrupo";
            this.txtidgrupo.Size = new System.Drawing.Size(160, 20);
            this.txtidgrupo.TabIndex = 22;
            // 
            // lblnombre1
            // 
            this.lblnombre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.lblnombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre1.ForeColor = System.Drawing.Color.White;
            this.lblnombre1.Location = new System.Drawing.Point(45, 171);
            this.lblnombre1.Name = "lblnombre1";
            this.lblnombre1.Size = new System.Drawing.Size(142, 28);
            this.lblnombre1.TabIndex = 21;
            this.lblnombre1.Tag = "";
            this.lblnombre1.Text = "ID del grupo:";
            this.lblnombre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcupo
            // 
            this.txtcupo.Location = new System.Drawing.Point(593, 177);
            this.txtcupo.Name = "txtcupo";
            this.txtcupo.Size = new System.Drawing.Size(160, 20);
            this.txtcupo.TabIndex = 24;
            this.txtcupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers_KeyPress);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(431, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 28);
            this.label7.TabIndex = 23;
            this.label7.Tag = "";
            this.label7.Text = "Cupo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxcursos
            // 
            this.cbxcursos.BackColor = System.Drawing.Color.White;
            this.cbxcursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcursos.FormattingEnabled = true;
            this.cbxcursos.Location = new System.Drawing.Point(211, 232);
            this.cbxcursos.Name = "cbxcursos";
            this.cbxcursos.Size = new System.Drawing.Size(160, 21);
            this.cbxcursos.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 28);
            this.label8.TabIndex = 25;
            this.label8.Tag = "";
            this.label8.Text = "Curso:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(431, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 26;
            this.label2.Tag = "";
            this.label2.Text = "Maestros:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label39.Location = new System.Drawing.Point(302, 100);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(196, 24);
            this.label39.TabIndex = 27;
            this.label39.Text = "Creando nuevo grupo";
            // 
            // FrmAddGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 462);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxmaestros);
            this.Controls.Add(this.cbxcursos);
            this.Controls.Add(this.txtcupo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtidgrupo);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.lblnombre1);
            this.Name = "FrmAddGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddGrupo";
            this.Load += new System.EventHandler(this.FrmAddGrupo_Load);
            this.Controls.SetChildIndex(this.lblnombre1, 0);
            this.Controls.SetChildIndex(this.btncrear, 0);
            this.Controls.SetChildIndex(this.txtidgrupo, 0);
            this.Controls.SetChildIndex(this.btnlimpiar, 0);
            this.Controls.SetChildIndex(this.btncancelar, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtcupo, 0);
            this.Controls.SetChildIndex(this.cbxcursos, 0);
            this.Controls.SetChildIndex(this.cbxmaestros, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label39, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxmaestros;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.TextBox txtidgrupo;
        private System.Windows.Forms.Label lblnombre1;
        private System.Windows.Forms.TextBox txtcupo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxcursos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label39;
    }
}
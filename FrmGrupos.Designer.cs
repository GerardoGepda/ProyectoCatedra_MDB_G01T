namespace ProyectoCatedra_MDB_G01T
{
    partial class FrmGrupos
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
            this.label39 = new System.Windows.Forms.Label();
            this.cbxgrupo = new System.Windows.Forms.ComboBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.pnlActualizar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMaestro = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcupo = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvhorarios = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlacthorario = new System.Windows.Forms.Panel();
            this.dtphorafin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtphorainicio = new System.Windows.Forms.DateTimePicker();
            this.cbxdias = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btncancelarhorario = new System.Windows.Forms.Button();
            this.btnborrarhorario = new System.Windows.Forms.Button();
            this.btnupdatehorario = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtidhorario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorarios)).BeginInit();
            this.pnlacthorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.Text = "Administración de grupos";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label39.Location = new System.Drawing.Point(55, 82);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(312, 24);
            this.label39.TabIndex = 16;
            this.label39.Text = "Administración de grupos y horarios";
            // 
            // cbxgrupo
            // 
            this.cbxgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxgrupo.FormattingEnabled = true;
            this.cbxgrupo.Location = new System.Drawing.Point(59, 164);
            this.cbxgrupo.Name = "cbxgrupo";
            this.cbxgrupo.Size = new System.Drawing.Size(155, 21);
            this.cbxgrupo.TabIndex = 17;
            // 
            // btnselect
            // 
            this.btnselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btnselect.FlatAppearance.BorderSize = 0;
            this.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselect.ForeColor = System.Drawing.Color.White;
            this.btnselect.Location = new System.Drawing.Point(260, 158);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(74, 30);
            this.btnselect.TabIndex = 18;
            this.btnselect.Text = "Seleccionar";
            this.btnselect.UseVisualStyleBackColor = false;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // pnlActualizar
            // 
            this.pnlActualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActualizar.Controls.Add(this.label6);
            this.pnlActualizar.Controls.Add(this.cbxMaestro);
            this.pnlActualizar.Controls.Add(this.label5);
            this.pnlActualizar.Controls.Add(this.txtcurso);
            this.pnlActualizar.Controls.Add(this.label2);
            this.pnlActualizar.Controls.Add(this.txtcupo);
            this.pnlActualizar.Controls.Add(this.btncancelar);
            this.pnlActualizar.Controls.Add(this.btnborrar);
            this.pnlActualizar.Controls.Add(this.btnactualizar);
            this.pnlActualizar.Controls.Add(this.label3);
            this.pnlActualizar.Controls.Add(this.txtidGrupo);
            this.pnlActualizar.Controls.Add(this.label4);
            this.pnlActualizar.Enabled = false;
            this.pnlActualizar.Location = new System.Drawing.Point(59, 237);
            this.pnlActualizar.Name = "pnlActualizar";
            this.pnlActualizar.Size = new System.Drawing.Size(275, 327);
            this.pnlActualizar.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Maestro:";
            // 
            // cbxMaestro
            // 
            this.cbxMaestro.BackColor = System.Drawing.Color.White;
            this.cbxMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaestro.FormattingEnabled = true;
            this.cbxMaestro.Location = new System.Drawing.Point(50, 219);
            this.cbxMaestro.Name = "cbxMaestro";
            this.cbxMaestro.Size = new System.Drawing.Size(170, 21);
            this.cbxMaestro.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Curso:";
            // 
            // txtcurso
            // 
            this.txtcurso.Enabled = false;
            this.txtcurso.Location = new System.Drawing.Point(50, 169);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(170, 20);
            this.txtcurso.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cupo:";
            // 
            // txtcupo
            // 
            this.txtcupo.Location = new System.Drawing.Point(50, 118);
            this.txtcupo.Name = "txtcupo";
            this.txtcupo.Size = new System.Drawing.Size(170, 20);
            this.txtcupo.TabIndex = 13;
            this.txtcupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOnlyNumbers_KeyPress);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Gray;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(183, 274);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(74, 30);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnborrar.FlatAppearance.BorderSize = 0;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.ForeColor = System.Drawing.Color.White;
            this.btnborrar.Location = new System.Drawing.Point(99, 274);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(74, 30);
            this.btnborrar.TabIndex = 11;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btnactualizar.FlatAppearance.BorderSize = 0;
            this.btnactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizar.ForeColor = System.Drawing.Color.White;
            this.btnactualizar.Location = new System.Drawing.Point(16, 274);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(74, 30);
            this.btnactualizar.TabIndex = 10;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID del grupo:";
            // 
            // txtidGrupo
            // 
            this.txtidGrupo.Enabled = false;
            this.txtidGrupo.Location = new System.Drawing.Point(50, 70);
            this.txtidGrupo.Name = "txtidGrupo";
            this.txtidGrupo.Size = new System.Drawing.Size(170, 20);
            this.txtidGrupo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 37);
            this.label4.TabIndex = 0;
            this.label4.Tag = "";
            this.label4.Text = "Editar grupo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvhorarios
            // 
            this.dgvhorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhorarios.Location = new System.Drawing.Point(399, 122);
            this.dgvhorarios.Name = "dgvhorarios";
            this.dgvhorarios.Size = new System.Drawing.Size(396, 91);
            this.dgvhorarios.TabIndex = 20;
            this.dgvhorarios.DoubleClick += new System.EventHandler(this.dgvhorarios_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(395, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Horarios";
            // 
            // pnlacthorario
            // 
            this.pnlacthorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlacthorario.Controls.Add(this.dtphorafin);
            this.pnlacthorario.Controls.Add(this.label8);
            this.pnlacthorario.Controls.Add(this.dtphorainicio);
            this.pnlacthorario.Controls.Add(this.cbxdias);
            this.pnlacthorario.Controls.Add(this.label9);
            this.pnlacthorario.Controls.Add(this.label10);
            this.pnlacthorario.Controls.Add(this.btncancelarhorario);
            this.pnlacthorario.Controls.Add(this.btnborrarhorario);
            this.pnlacthorario.Controls.Add(this.btnupdatehorario);
            this.pnlacthorario.Controls.Add(this.label11);
            this.pnlacthorario.Controls.Add(this.txtidhorario);
            this.pnlacthorario.Controls.Add(this.label12);
            this.pnlacthorario.Enabled = false;
            this.pnlacthorario.Location = new System.Drawing.Point(485, 236);
            this.pnlacthorario.Name = "pnlacthorario";
            this.pnlacthorario.Size = new System.Drawing.Size(275, 327);
            this.pnlacthorario.TabIndex = 22;
            // 
            // dtphorafin
            // 
            this.dtphorafin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtphorafin.Location = new System.Drawing.Point(50, 220);
            this.dtphorafin.Name = "dtphorafin";
            this.dtphorafin.ShowUpDown = true;
            this.dtphorafin.Size = new System.Drawing.Size(170, 20);
            this.dtphorafin.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "hora de finalización:";
            // 
            // dtphorainicio
            // 
            this.dtphorainicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtphorainicio.Location = new System.Drawing.Point(50, 169);
            this.dtphorainicio.Name = "dtphorainicio";
            this.dtphorainicio.ShowUpDown = true;
            this.dtphorainicio.Size = new System.Drawing.Size(170, 20);
            this.dtphorainicio.TabIndex = 23;
            // 
            // cbxdias
            // 
            this.cbxdias.BackColor = System.Drawing.Color.White;
            this.cbxdias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxdias.FormattingEnabled = true;
            this.cbxdias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado"});
            this.cbxdias.Location = new System.Drawing.Point(50, 117);
            this.cbxdias.Name = "cbxdias";
            this.cbxdias.Size = new System.Drawing.Size(170, 21);
            this.cbxdias.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Hora de inicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Día:";
            // 
            // btncancelarhorario
            // 
            this.btncancelarhorario.BackColor = System.Drawing.Color.Gray;
            this.btncancelarhorario.FlatAppearance.BorderSize = 0;
            this.btncancelarhorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelarhorario.ForeColor = System.Drawing.Color.White;
            this.btncancelarhorario.Location = new System.Drawing.Point(183, 274);
            this.btncancelarhorario.Name = "btncancelarhorario";
            this.btncancelarhorario.Size = new System.Drawing.Size(74, 30);
            this.btncancelarhorario.TabIndex = 12;
            this.btncancelarhorario.Text = "Cancelar";
            this.btncancelarhorario.UseVisualStyleBackColor = false;
            this.btncancelarhorario.Click += new System.EventHandler(this.btncancelarhorario_Click);
            // 
            // btnborrarhorario
            // 
            this.btnborrarhorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnborrarhorario.FlatAppearance.BorderSize = 0;
            this.btnborrarhorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrarhorario.ForeColor = System.Drawing.Color.White;
            this.btnborrarhorario.Location = new System.Drawing.Point(99, 274);
            this.btnborrarhorario.Name = "btnborrarhorario";
            this.btnborrarhorario.Size = new System.Drawing.Size(74, 30);
            this.btnborrarhorario.TabIndex = 11;
            this.btnborrarhorario.Text = "Borrar";
            this.btnborrarhorario.UseVisualStyleBackColor = false;
            this.btnborrarhorario.Click += new System.EventHandler(this.btnborrarhorario_Click);
            // 
            // btnupdatehorario
            // 
            this.btnupdatehorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btnupdatehorario.FlatAppearance.BorderSize = 0;
            this.btnupdatehorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdatehorario.ForeColor = System.Drawing.Color.White;
            this.btnupdatehorario.Location = new System.Drawing.Point(16, 274);
            this.btnupdatehorario.Name = "btnupdatehorario";
            this.btnupdatehorario.Size = new System.Drawing.Size(74, 30);
            this.btnupdatehorario.TabIndex = 10;
            this.btnupdatehorario.Text = "Actualizar";
            this.btnupdatehorario.UseVisualStyleBackColor = false;
            this.btnupdatehorario.Click += new System.EventHandler(this.btnupdatehorario_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "ID del horario:";
            // 
            // txtidhorario
            // 
            this.txtidhorario.Enabled = false;
            this.txtidhorario.Location = new System.Drawing.Point(50, 70);
            this.txtidhorario.Name = "txtidhorario";
            this.txtidhorario.Size = new System.Drawing.Size(170, 20);
            this.txtidhorario.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(274, 37);
            this.label12.TabIndex = 0;
            this.label12.Tag = "";
            this.label12.Text = "Editar grupo";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(396, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(285, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Doble click en la primer columna para editar datos.";
            // 
            // FrmGrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 570);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pnlacthorario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvhorarios);
            this.Controls.Add(this.pnlActualizar);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.cbxgrupo);
            this.Controls.Add(this.label39);
            this.Name = "FrmGrupos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGrupos";
            this.Load += new System.EventHandler(this.FrmGrupos_Load);
            this.Controls.SetChildIndex(this.label39, 0);
            this.Controls.SetChildIndex(this.cbxgrupo, 0);
            this.Controls.SetChildIndex(this.btnselect, 0);
            this.Controls.SetChildIndex(this.pnlActualizar, 0);
            this.Controls.SetChildIndex(this.dgvhorarios, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.pnlacthorario, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.pnlActualizar.ResumeLayout(false);
            this.pnlActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorarios)).EndInit();
            this.pnlacthorario.ResumeLayout(false);
            this.pnlacthorario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox cbxgrupo;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Panel pnlActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcupo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcurso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMaestro;
        private System.Windows.Forms.DataGridView dgvhorarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlacthorario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btncancelarhorario;
        private System.Windows.Forms.Button btnborrarhorario;
        private System.Windows.Forms.Button btnupdatehorario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtidhorario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtphorainicio;
        private System.Windows.Forms.ComboBox cbxdias;
        private System.Windows.Forms.DateTimePicker dtphorafin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
    }
}
namespace ProyectoCatedra_MDB_G01T
{
    partial class FrmAddEditCurso
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.txtnomcurso = new System.Windows.Forms.TextBox();
            this.lblnombre1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpfechainicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfechafin = new System.Windows.Forms.DateTimePicker();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnCrearActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.Location = new System.Drawing.Point(756, 12);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.Text = "Administrar curso";
            // 
            // lbltitulo
            // 
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltitulo.Location = new System.Drawing.Point(234, 97);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(379, 24);
            this.lbltitulo.TabIndex = 16;
            this.lbltitulo.Text = "Crear un nuevo curso";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnomcurso
            // 
            this.txtnomcurso.Location = new System.Drawing.Point(238, 188);
            this.txtnomcurso.Name = "txtnomcurso";
            this.txtnomcurso.Size = new System.Drawing.Size(160, 20);
            this.txtnomcurso.TabIndex = 18;
            // 
            // lblnombre1
            // 
            this.lblnombre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.lblnombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre1.ForeColor = System.Drawing.Color.White;
            this.lblnombre1.Location = new System.Drawing.Point(41, 182);
            this.lblnombre1.Name = "lblnombre1";
            this.lblnombre1.Size = new System.Drawing.Size(163, 28);
            this.lblnombre1.TabIndex = 17;
            this.lblnombre1.Tag = "";
            this.lblnombre1.Text = "Nombre del curso:";
            this.lblnombre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(625, 188);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(160, 20);
            this.txtdescripcion.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(428, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 19;
            this.label2.Tag = "";
            this.label2.Text = "Descripción del curso:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpfechainicio
            // 
            this.dtpfechainicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechainicio.Location = new System.Drawing.Point(238, 246);
            this.dtpfechainicio.Name = "dtpfechainicio";
            this.dtpfechainicio.Size = new System.Drawing.Size(160, 20);
            this.dtpfechainicio.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 28);
            this.label3.TabIndex = 22;
            this.label3.Tag = "";
            this.label3.Text = "Fecha de inicio:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(428, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 28);
            this.label4.TabIndex = 24;
            this.label4.Tag = "";
            this.label4.Text = "Fecha de fin:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpfechafin
            // 
            this.dtpfechafin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafin.Location = new System.Drawing.Point(625, 246);
            this.dtpfechafin.Name = "dtpfechafin";
            this.dtpfechafin.Size = new System.Drawing.Size(160, 20);
            this.dtpfechafin.TabIndex = 23;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.BackColor = System.Drawing.Color.White;
            this.cbxcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(431, 316);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(160, 21);
            this.cbxcategoria.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(234, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 28);
            this.label5.TabIndex = 26;
            this.label5.Tag = "";
            this.label5.Text = "Categoría del curso:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Gray;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(463, 393);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(128, 42);
            this.btncancelar.TabIndex = 28;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnCrearActualizar
            // 
            this.btnCrearActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btnCrearActualizar.FlatAppearance.BorderSize = 0;
            this.btnCrearActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearActualizar.ForeColor = System.Drawing.Color.White;
            this.btnCrearActualizar.Location = new System.Drawing.Point(237, 393);
            this.btnCrearActualizar.Name = "btnCrearActualizar";
            this.btnCrearActualizar.Size = new System.Drawing.Size(128, 42);
            this.btnCrearActualizar.TabIndex = 27;
            this.btnCrearActualizar.Text = "Crear curso";
            this.btnCrearActualizar.UseVisualStyleBackColor = false;
            this.btnCrearActualizar.Click += new System.EventHandler(this.btnCrearActualizar_Click);
            // 
            // FrmAddEditCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 487);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnCrearActualizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxcategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpfechafin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpfechainicio);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnomcurso);
            this.Controls.Add(this.lblnombre1);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmAddEditCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddEditCurso";
            this.Load += new System.EventHandler(this.FrmAddEditCurso_Load);
            this.Controls.SetChildIndex(this.lbltitulo, 0);
            this.Controls.SetChildIndex(this.lblnombre1, 0);
            this.Controls.SetChildIndex(this.txtnomcurso, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtdescripcion, 0);
            this.Controls.SetChildIndex(this.dtpfechainicio, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dtpfechafin, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.cbxcategoria, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnCrearActualizar, 0);
            this.Controls.SetChildIndex(this.btncancelar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.TextBox txtnomcurso;
        private System.Windows.Forms.Label lblnombre1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpfechainicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfechafin;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnCrearActualizar;
    }
}
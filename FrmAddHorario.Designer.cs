namespace ProyectoCatedra_MDB_G01T
{
    partial class FrmAddHorario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.lblnombre1 = new System.Windows.Forms.Label();
            this.dtphorainicio = new System.Windows.Forms.DateTimePicker();
            this.dtphorafin = new System.Windows.Forms.DateTimePicker();
            this.cbxidgrupo = new System.Windows.Forms.ComboBox();
            this.cbxdias = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.Text = "Crear horario";
            // 
            // lbltitulo
            // 
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbltitulo.Location = new System.Drawing.Point(134, 96);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(534, 24);
            this.lbltitulo.TabIndex = 39;
            this.lbltitulo.Text = "Creando nuevo horario";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(432, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 38;
            this.label2.Tag = "";
            this.label2.Text = "hora de fin:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 28);
            this.label8.TabIndex = 37;
            this.label8.Tag = "";
            this.label8.Text = "Hora de inicio:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(432, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 28);
            this.label7.TabIndex = 35;
            this.label7.Tag = "";
            this.label7.Text = "Día:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Gray;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(356, 390);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(96, 30);
            this.btncancelar.TabIndex = 30;
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
            this.btnlimpiar.Location = new System.Drawing.Point(414, 318);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(96, 30);
            this.btnlimpiar.TabIndex = 29;
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
            this.btncrear.Location = new System.Drawing.Point(284, 318);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(96, 30);
            this.btncrear.TabIndex = 28;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // lblnombre1
            // 
            this.lblnombre1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.lblnombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre1.ForeColor = System.Drawing.Color.White;
            this.lblnombre1.Location = new System.Drawing.Point(46, 172);
            this.lblnombre1.Name = "lblnombre1";
            this.lblnombre1.Size = new System.Drawing.Size(142, 28);
            this.lblnombre1.TabIndex = 32;
            this.lblnombre1.Tag = "";
            this.lblnombre1.Text = "ID del grupo:";
            this.lblnombre1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtphorainicio
            // 
            this.dtphorainicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtphorainicio.Location = new System.Drawing.Point(212, 233);
            this.dtphorainicio.Name = "dtphorainicio";
            this.dtphorainicio.ShowUpDown = true;
            this.dtphorainicio.Size = new System.Drawing.Size(160, 20);
            this.dtphorainicio.TabIndex = 40;
            // 
            // dtphorafin
            // 
            this.dtphorafin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtphorafin.Location = new System.Drawing.Point(595, 234);
            this.dtphorafin.Name = "dtphorafin";
            this.dtphorafin.ShowUpDown = true;
            this.dtphorafin.Size = new System.Drawing.Size(160, 20);
            this.dtphorafin.TabIndex = 41;
            // 
            // cbxidgrupo
            // 
            this.cbxidgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxidgrupo.FormattingEnabled = true;
            this.cbxidgrupo.Location = new System.Drawing.Point(212, 177);
            this.cbxidgrupo.Name = "cbxidgrupo";
            this.cbxidgrupo.Size = new System.Drawing.Size(160, 21);
            this.cbxidgrupo.TabIndex = 42;
            // 
            // cbxdias
            // 
            this.cbxdias.BackColor = System.Drawing.Color.White;
            this.cbxdias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxdias.FormattingEnabled = true;
            this.cbxdias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado"});
            this.cbxdias.Location = new System.Drawing.Point(594, 177);
            this.cbxdias.Name = "cbxdias";
            this.cbxdias.Size = new System.Drawing.Size(161, 21);
            this.cbxdias.TabIndex = 43;
            // 
            // FrmAddHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxdias);
            this.Controls.Add(this.cbxidgrupo);
            this.Controls.Add(this.dtphorafin);
            this.Controls.Add(this.dtphorainicio);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.lblnombre1);
            this.Name = "FrmAddHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddHorario";
            this.Load += new System.EventHandler(this.FrmAddHorario_Load);
            this.Controls.SetChildIndex(this.lblnombre1, 0);
            this.Controls.SetChildIndex(this.btncrear, 0);
            this.Controls.SetChildIndex(this.btnlimpiar, 0);
            this.Controls.SetChildIndex(this.btncancelar, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lbltitulo, 0);
            this.Controls.SetChildIndex(this.dtphorainicio, 0);
            this.Controls.SetChildIndex(this.dtphorafin, 0);
            this.Controls.SetChildIndex(this.cbxidgrupo, 0);
            this.Controls.SetChildIndex(this.cbxdias, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label lblnombre1;
        private System.Windows.Forms.DateTimePicker dtphorainicio;
        private System.Windows.Forms.DateTimePicker dtphorafin;
        private System.Windows.Forms.ComboBox cbxidgrupo;
        private System.Windows.Forms.ComboBox cbxdias;
    }
}
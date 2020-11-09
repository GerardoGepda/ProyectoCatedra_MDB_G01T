namespace ProyectoCatedra_MDB_G01T
{
    partial class FrmPrestamo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxmateriales = new System.Windows.Forms.ComboBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.btnprestar = new System.Windows.Forms.Button();
            this.btnborrarselec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnactualizaedgv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label39.Location = new System.Drawing.Point(40, 23);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(284, 24);
            this.label39.TabIndex = 14;
            this.label39.Text = "Prestamo de equipo y materiales";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.panel1.Location = new System.Drawing.Point(550, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 472);
            this.panel1.TabIndex = 15;
            // 
            // cbxmateriales
            // 
            this.cbxmateriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxmateriales.FormattingEnabled = true;
            this.cbxmateriales.Location = new System.Drawing.Point(85, 241);
            this.cbxmateriales.Name = "cbxmateriales";
            this.cbxmateriales.Size = new System.Drawing.Size(155, 21);
            this.cbxmateriales.TabIndex = 16;
            this.cbxmateriales.SelectedIndexChanged += new System.EventHandler(this.cbxmateriales_SelectedIndexChanged);
            // 
            // lblcantidad
            // 
            this.lblcantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.ForeColor = System.Drawing.Color.White;
            this.lblcantidad.Location = new System.Drawing.Point(344, 241);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(73, 21);
            this.lblcantidad.TabIndex = 17;
            this.lblcantidad.Tag = "";
            this.lblcantidad.Text = "Vacío";
            this.lblcantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnprestar
            // 
            this.btnprestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btnprestar.FlatAppearance.BorderSize = 0;
            this.btnprestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprestar.ForeColor = System.Drawing.Color.White;
            this.btnprestar.Location = new System.Drawing.Point(85, 345);
            this.btnprestar.Name = "btnprestar";
            this.btnprestar.Size = new System.Drawing.Size(118, 35);
            this.btnprestar.TabIndex = 18;
            this.btnprestar.Text = "Realizar prestamo";
            this.btnprestar.UseVisualStyleBackColor = false;
            this.btnprestar.Click += new System.EventHandler(this.btnprestar_Click);
            // 
            // btnborrarselec
            // 
            this.btnborrarselec.BackColor = System.Drawing.Color.Gray;
            this.btnborrarselec.FlatAppearance.BorderSize = 0;
            this.btnborrarselec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrarselec.ForeColor = System.Drawing.Color.White;
            this.btnborrarselec.Location = new System.Drawing.Point(299, 345);
            this.btnborrarselec.Name = "btnborrarselec";
            this.btnborrarselec.Size = new System.Drawing.Size(118, 35);
            this.btnborrarselec.TabIndex = 19;
            this.btnborrarselec.Text = "Borrar selección";
            this.btnborrarselec.UseVisualStyleBackColor = false;
            this.btnborrarselec.Click += new System.EventHandler(this.btnborrarselec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seleccione un elemento de la lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 72);
            this.label3.TabIndex = 22;
            this.label3.Text = "• Solo puede tener un prestamo a la vez.\r\n• Su prestamo solo dura 2 días, procure" +
    " devolver\r\n   el objeto prestado a tiempo.";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Location = new System.Drawing.Point(586, 315);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.Size = new System.Drawing.Size(483, 150);
            this.dgvPrestamos.TabIndex = 23;
            this.dgvPrestamos.DoubleClick += new System.EventHandler(this.dgvPrestamos_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Hacer un prestamo de equipo o material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Registro de prestamos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(583, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Doble click en la primer columna para eliminar registro";
            // 
            // btnactualizaedgv
            // 
            this.btnactualizaedgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.btnactualizaedgv.FlatAppearance.BorderSize = 0;
            this.btnactualizaedgv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualizaedgv.ForeColor = System.Drawing.Color.White;
            this.btnactualizaedgv.Location = new System.Drawing.Point(971, 277);
            this.btnactualizaedgv.Name = "btnactualizaedgv";
            this.btnactualizaedgv.Size = new System.Drawing.Size(98, 32);
            this.btnactualizaedgv.TabIndex = 27;
            this.btnactualizaedgv.Text = "Actualizar";
            this.btnactualizaedgv.UseVisualStyleBackColor = false;
            this.btnactualizaedgv.Click += new System.EventHandler(this.btnactualizaedgv_Click);
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 572);
            this.Controls.Add(this.btnactualizaedgv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnborrarselec);
            this.Controls.Add(this.btnprestar);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.cbxmateriales);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label39);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxmateriales;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Button btnprestar;
        private System.Windows.Forms.Button btnborrarselec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnactualizaedgv;
    }
}
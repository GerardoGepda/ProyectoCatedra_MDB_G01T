namespace ProyectoCatedra_MDB_G01T
{
    partial class FrmAdmCategorias
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
            this.pnlCrear = new System.Windows.Forms.Panel();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnomcategoria = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.label39 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.pnlActualizar = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtupdatenomCate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCrear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.pnlActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.FlatAppearance.BorderSize = 0;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.Text = "Administración de categorías";
            // 
            // pnlCrear
            // 
            this.pnlCrear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCrear.Controls.Add(this.btnlimpiar);
            this.pnlCrear.Controls.Add(this.btncrear);
            this.pnlCrear.Controls.Add(this.label2);
            this.pnlCrear.Controls.Add(this.txtnomcategoria);
            this.pnlCrear.Controls.Add(this.lbltitulo);
            this.pnlCrear.Location = new System.Drawing.Point(13, 121);
            this.pnlCrear.Name = "pnlCrear";
            this.pnlCrear.Size = new System.Drawing.Size(275, 199);
            this.pnlCrear.TabIndex = 2;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnlimpiar.FlatAppearance.BorderSize = 0;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.Location = new System.Drawing.Point(146, 147);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(74, 30);
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
            this.btncrear.Location = new System.Drawing.Point(50, 147);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(74, 30);
            this.btncrear.TabIndex = 10;
            this.btncrear.Text = "Crear";
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de la categoría:";
            // 
            // txtnomcategoria
            // 
            this.txtnomcategoria.Location = new System.Drawing.Point(50, 103);
            this.txtnomcategoria.Name = "txtnomcategoria";
            this.txtnomcategoria.Size = new System.Drawing.Size(170, 20);
            this.txtnomcategoria.TabIndex = 1;
            // 
            // lbltitulo
            // 
            this.lbltitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(240)))));
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(0, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(274, 37);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Tag = "";
            this.lbltitulo.Text = "Crear nuea categoría";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(347, 177);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(433, 143);
            this.dgvCategorias.TabIndex = 3;
            this.dgvCategorias.DoubleClick += new System.EventHandler(this.dgvCategorias_DoubleClick);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label39.Location = new System.Drawing.Point(343, 121);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(99, 24);
            this.label39.TabIndex = 16;
            this.label39.Text = "Categorías";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Gray;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(338, 374);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(104, 39);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "Salir";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pnlActualizar
            // 
            this.pnlActualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActualizar.Controls.Add(this.btncancelar);
            this.pnlActualizar.Controls.Add(this.btnborrar);
            this.pnlActualizar.Controls.Add(this.btnactualizar);
            this.pnlActualizar.Controls.Add(this.label3);
            this.pnlActualizar.Controls.Add(this.txtupdatenomCate);
            this.pnlActualizar.Controls.Add(this.label4);
            this.pnlActualizar.Location = new System.Drawing.Point(13, 121);
            this.pnlActualizar.Name = "pnlActualizar";
            this.pnlActualizar.Size = new System.Drawing.Size(275, 199);
            this.pnlActualizar.TabIndex = 12;
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Gray;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(183, 147);
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
            this.btnborrar.Location = new System.Drawing.Point(99, 147);
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
            this.btnactualizar.Location = new System.Drawing.Point(16, 147);
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
            this.label3.Location = new System.Drawing.Point(50, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de la categoría:";
            // 
            // txtupdatenomCate
            // 
            this.txtupdatenomCate.Location = new System.Drawing.Point(50, 103);
            this.txtupdatenomCate.Name = "txtupdatenomCate";
            this.txtupdatenomCate.Size = new System.Drawing.Size(170, 20);
            this.txtupdatenomCate.TabIndex = 1;
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
            this.label4.Text = "Editar categoría";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(344, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Doble click en la primer columna para editar datos.";
            // 
            // FrmAdmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 440);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlActualizar);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.pnlCrear);
            this.Name = "FrmAdmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmAdmCategorias_Load);
            this.Controls.SetChildIndex(this.pnlCrear, 0);
            this.Controls.SetChildIndex(this.dgvCategorias, 0);
            this.Controls.SetChildIndex(this.label39, 0);
            this.Controls.SetChildIndex(this.btnclose, 0);
            this.Controls.SetChildIndex(this.pnlActualizar, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.pnlCrear.ResumeLayout(false);
            this.pnlCrear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.pnlActualizar.ResumeLayout(false);
            this.pnlActualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCrear;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnomcategoria;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel pnlActualizar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtupdatenomCate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
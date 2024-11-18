namespace ArmaTuPc2.FE
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPlaca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMemoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboAlmacenamiento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboGpu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboFuente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboGabinete = new System.Windows.Forms.ComboBox();
            this.bttAgregar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.dgvPC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arma tu pc!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Procesador:";
            // 
            // cboTipo
            // 
            this.cboTipo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "AMD",
            "INTEL"});
            this.cboTipo.Location = new System.Drawing.Point(28, 84);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(165, 21);
            this.cboTipo.TabIndex = 7;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Modelo de procesador:";
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(210, 84);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(165, 21);
            this.cboModelo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Placa Madre:";
            // 
            // cboPlaca
            // 
            this.cboPlaca.FormattingEnabled = true;
            this.cboPlaca.Location = new System.Drawing.Point(391, 84);
            this.cboPlaca.Name = "cboPlaca";
            this.cboPlaca.Size = new System.Drawing.Size(165, 21);
            this.cboPlaca.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Memoria RAM:";
            // 
            // cboMemoria
            // 
            this.cboMemoria.FormattingEnabled = true;
            this.cboMemoria.Location = new System.Drawing.Point(571, 84);
            this.cboMemoria.Name = "cboMemoria";
            this.cboMemoria.Size = new System.Drawing.Size(165, 21);
            this.cboMemoria.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Almacenamiento:";
            // 
            // cboAlmacenamiento
            // 
            this.cboAlmacenamiento.FormattingEnabled = true;
            this.cboAlmacenamiento.Location = new System.Drawing.Point(28, 155);
            this.cboAlmacenamiento.Name = "cboAlmacenamiento";
            this.cboAlmacenamiento.Size = new System.Drawing.Size(165, 21);
            this.cboAlmacenamiento.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Placa de video:";
            // 
            // cboGpu
            // 
            this.cboGpu.FormattingEnabled = true;
            this.cboGpu.Location = new System.Drawing.Point(210, 155);
            this.cboGpu.Name = "cboGpu";
            this.cboGpu.Size = new System.Drawing.Size(165, 21);
            this.cboGpu.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fuente de Poder:";
            // 
            // cboFuente
            // 
            this.cboFuente.FormattingEnabled = true;
            this.cboFuente.Location = new System.Drawing.Point(391, 155);
            this.cboFuente.Name = "cboFuente";
            this.cboFuente.Size = new System.Drawing.Size(165, 21);
            this.cboFuente.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(568, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Gabinete:";
            // 
            // cboGabinete
            // 
            this.cboGabinete.FormattingEnabled = true;
            this.cboGabinete.Location = new System.Drawing.Point(571, 155);
            this.cboGabinete.Name = "cboGabinete";
            this.cboGabinete.Size = new System.Drawing.Size(165, 21);
            this.cboGabinete.TabIndex = 27;
            // 
            // bttAgregar
            // 
            this.bttAgregar.Location = new System.Drawing.Point(142, 211);
            this.bttAgregar.Name = "bttAgregar";
            this.bttAgregar.Size = new System.Drawing.Size(156, 35);
            this.bttAgregar.TabIndex = 28;
            this.bttAgregar.Text = "AGREGAR";
            this.bttAgregar.UseVisualStyleBackColor = true;
            this.bttAgregar.Click += new System.EventHandler(this.bttAgregar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(452, 211);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(156, 35);
            this.bttEliminar.TabIndex = 29;
            this.bttEliminar.Text = "ELIMINAR";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // dgvPC
            // 
            this.dgvPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPC.Location = new System.Drawing.Point(2, 288);
            this.dgvPC.Name = "dgvPC";
            this.dgvPC.Size = new System.Drawing.Size(792, 150);
            this.dgvPC.TabIndex = 30;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPC);
            this.Controls.Add(this.bttEliminar);
            this.Controls.Add(this.bttAgregar);
            this.Controls.Add(this.cboGabinete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboFuente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboGpu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboAlmacenamiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMemoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboPlaca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInicio";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMemoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboAlmacenamiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboGpu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboFuente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboGabinete;
        private System.Windows.Forms.Button bttAgregar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.DataGridView dgvPC;
    }
}


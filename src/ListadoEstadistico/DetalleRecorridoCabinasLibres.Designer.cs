namespace FrbaCrucero.ListadoEstadistico
{
    partial class DetalleRecorridoCabinasLibres
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.DGVMeses = new System.Windows.Forms.DataGridView();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.DGVTramos = new System.Windows.Forms.DataGridView();
            this.idTramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.Label();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMeses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTramos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(158, 132);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(54, 20);
            this.lblFecha.TabIndex = 39;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(20, 734);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(53, 20);
            this.lblDias.TabIndex = 38;
            this.lblDias.Text = "label1";
            // 
            // DGVMeses
            // 
            this.DGVMeses.AllowUserToAddRows = false;
            this.DGVMeses.AllowUserToDeleteRows = false;
            this.DGVMeses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMeses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mes,
            this.CantidadVendida});
            this.DGVMeses.Location = new System.Drawing.Point(78, 423);
            this.DGVMeses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVMeses.Name = "DGVMeses";
            this.DGVMeses.ReadOnly = true;
            this.DGVMeses.Size = new System.Drawing.Size(387, 286);
            this.DGVMeses.TabIndex = 37;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(15, 378);
            this.lblPrecioTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(99, 20);
            this.lblPrecioTotal.TabIndex = 36;
            this.lblPrecioTotal.Text = "Precio total:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolver.Location = new System.Drawing.Point(162, 775);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(178, 65);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // DGVTramos
            // 
            this.DGVTramos.AllowUserToAddRows = false;
            this.DGVTramos.AllowUserToDeleteRows = false;
            this.DGVTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTramos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTramo,
            this.Inicio,
            this.Destino,
            this.Precio});
            this.DGVTramos.Location = new System.Drawing.Point(15, 171);
            this.DGVTramos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVTramos.Name = "DGVTramos";
            this.DGVTramos.ReadOnly = true;
            this.DGVTramos.Size = new System.Drawing.Size(514, 203);
            this.DGVTramos.TabIndex = 34;
            // 
            // idTramo
            // 
            this.idTramo.HeaderText = "idTramo";
            this.idTramo.Name = "idTramo";
            this.idTramo.ReadOnly = true;
            this.idTramo.Visible = false;
            // 
            // Inicio
            // 
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Titulo.Location = new System.Drawing.Point(30, 17);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(481, 58);
            this.Titulo.TabIndex = 33;
            this.Titulo.Text = "Detalle de Recorrido";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Mes
            // 
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            this.Mes.ReadOnly = true;
            // 
            // CantidadVendida
            // 
            this.CantidadVendida.HeaderText = "Cabinas libres";
            this.CantidadVendida.Name = "CantidadVendida";
            this.CantidadVendida.ReadOnly = true;
            // 
            // DetalleRecorridoCabinasLibres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 855);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.DGVMeses);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.DGVTramos);
            this.Controls.Add(this.Titulo);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "DetalleRecorridoCabinasLibres";
            this.Text = "DetalleRecorridoCabinasLibres";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DetalleRecorridoCabinasLibres_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMeses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTramos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.DataGridView DGVMeses;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView DGVTramos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVendida;

    }
}
namespace FrbaCrucero.AbmRecorrido
{
    partial class SeleccionarTramo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Titulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblInicio = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.DGVTramos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idinicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorController)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTramos)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Titulo.Location = new System.Drawing.Point(144, 14);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(446, 58);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "Seleccionar Tramo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblError);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblInicio);
            this.groupBox1.Controls.Add(this.txtInicio);
            this.groupBox1.Location = new System.Drawing.Point(78, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(546, 209);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscador de Tramos";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(16, 117);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(54, 25);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(220, 149);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(200, 34);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(64, 20);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(200, 63);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(148, 26);
            this.txtDestino.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(370, 34);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 20);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(370, 63);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(148, 26);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(16, 34);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(46, 20);
            this.lblInicio.TabIndex = 1;
            this.lblInicio.Text = "Inicio";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(16, 63);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(148, 26);
            this.txtInicio.TabIndex = 0;
            // 
            // DGVTramos
            // 
            this.DGVTramos.AllowUserToAddRows = false;
            this.DGVTramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTramos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Idinicio,
            this.Inicio,
            this.IdDestino,
            this.Destino,
            this.Precio,
            this.Accion});
            this.DGVTramos.Location = new System.Drawing.Point(33, 297);
            this.DGVTramos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVTramos.Name = "DGVTramos";
            this.DGVTramos.Size = new System.Drawing.Size(664, 231);
            this.DGVTramos.TabIndex = 8;
            this.DGVTramos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTramos_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Idinicio
            // 
            this.Idinicio.HeaderText = "IdInicio";
            this.Idinicio.Name = "Idinicio";
            this.Idinicio.Visible = false;
            // 
            // Inicio
            // 
            this.Inicio.HeaderText = "Inicio";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            // 
            // IdDestino
            // 
            this.IdDestino.HeaderText = "IdDestino";
            this.IdDestino.Name = "IdDestino";
            this.IdDestino.Visible = false;
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
            // Accion
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accion.DefaultCellStyle = dataGridViewCellStyle1;
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.Text = "Seleccionar";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolver.Location = new System.Drawing.Point(33, 537);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(147, 63);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Location = new System.Drawing.Point(550, 537);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(147, 63);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // SeleccionarTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 614);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.DGVTramos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Titulo);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "SeleccionarTramo";
            this.Text = "Seleccionar Tramo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeleccionarTramo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorController)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTramos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.DataGridView DGVTramos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idinicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}
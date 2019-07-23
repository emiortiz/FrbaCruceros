namespace FrbaCrucero.AbmRecorrido
{
    partial class BajaRecorrido
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
            this.Titulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionarD = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarI = new System.Windows.Forms.Button();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.DGVRecorridos = new System.Windows.Forms.DataGridView();
            this.idRecorrido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblError = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorController)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecorridos)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Titulo.Location = new System.Drawing.Point(135, 14);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(425, 58);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "Baja de Recorrido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSeleccionarD);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSeleccionarI);
            this.groupBox1.Controls.Add(this.txtInicio);
            this.groupBox1.Location = new System.Drawing.Point(18, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(680, 185);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de busqueda";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(252, 122);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 54);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ciudad de destino";
            // 
            // btnSeleccionarD
            // 
            this.btnSeleccionarD.Location = new System.Drawing.Point(524, 68);
            this.btnSeleccionarD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionarD.Name = "btnSeleccionarD";
            this.btnSeleccionarD.Size = new System.Drawing.Size(112, 35);
            this.btnSeleccionarD.TabIndex = 4;
            this.btnSeleccionarD.Text = "Seleccionar";
            this.btnSeleccionarD.UseVisualStyleBackColor = true;
            this.btnSeleccionarD.Click += new System.EventHandler(this.btnSeleccionarD_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(364, 71);
            this.txtDestino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.ReadOnly = true;
            this.txtDestino.Size = new System.Drawing.Size(148, 26);
            this.txtDestino.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ciudad de inicio";
            // 
            // btnSeleccionarI
            // 
            this.btnSeleccionarI.Location = new System.Drawing.Point(195, 68);
            this.btnSeleccionarI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeleccionarI.Name = "btnSeleccionarI";
            this.btnSeleccionarI.Size = new System.Drawing.Size(112, 35);
            this.btnSeleccionarI.TabIndex = 1;
            this.btnSeleccionarI.Text = "Seleccionar";
            this.btnSeleccionarI.UseVisualStyleBackColor = true;
            this.btnSeleccionarI.Click += new System.EventHandler(this.btnSeleccionarI_Click);
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(36, 71);
            this.txtInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.ReadOnly = true;
            this.txtInicio.Size = new System.Drawing.Size(148, 26);
            this.txtInicio.TabIndex = 0;
            // 
            // DGVRecorridos
            // 
            this.DGVRecorridos.AllowUserToAddRows = false;
            this.DGVRecorridos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRecorridos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRecorrido,
            this.Detalle,
            this.Accion});
            this.DGVRecorridos.Location = new System.Drawing.Point(104, 278);
            this.DGVRecorridos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVRecorridos.Name = "DGVRecorridos";
            this.DGVRecorridos.Size = new System.Drawing.Size(516, 231);
            this.DGVRecorridos.TabIndex = 8;
            this.DGVRecorridos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTramos_CellContentClick);
            // 
            // idRecorrido
            // 
            this.idRecorrido.HeaderText = "idRecorrido";
            this.idRecorrido.Name = "idRecorrido";
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(99, 514);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(54, 25);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolver.Location = new System.Drawing.Point(33, 558);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 54);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Location = new System.Drawing.Point(542, 558);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 54);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BajaRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 629);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.DGVRecorridos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Titulo);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "BajaRecorrido";
            this.Text = "Baja Recorrido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BajaRecorrido_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorController)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecorridos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionarD;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarI;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.DataGridView DGVRecorridos;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecorrido;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
    }
}
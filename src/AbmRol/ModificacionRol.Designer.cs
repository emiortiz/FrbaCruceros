namespace FrbaCrucero.AbmRol
{
    partial class ModificacionRol
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.DGVFuncionalidad = new System.Windows.Forms.DataGridView();
            this.idFuncionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFuncionalidad = new System.Windows.Forms.Label();
            this.CBFuncionalidad = new System.Windows.Forms.ComboBox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.lbRoles = new System.Windows.Forms.ListBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.cbInhabilitado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFuncionalidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Location = new System.Drawing.Point(201, 754);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(171, 66);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVolver.Location = new System.Drawing.Point(21, 754);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(171, 66);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 709);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(59, 25);
            this.lblError.TabIndex = 32;
            this.lblError.Text = "Error";
            this.lblError.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Location = new System.Drawing.Point(381, 754);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(171, 66);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // DGVFuncionalidad
            // 
            this.DGVFuncionalidad.AllowUserToAddRows = false;
            this.DGVFuncionalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVFuncionalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionalidad,
            this.Funcionalidad,
            this.Accion});
            this.DGVFuncionalidad.Location = new System.Drawing.Point(92, 398);
            this.DGVFuncionalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVFuncionalidad.Name = "DGVFuncionalidad";
            this.DGVFuncionalidad.ReadOnly = true;
            this.DGVFuncionalidad.Size = new System.Drawing.Size(392, 231);
            this.DGVFuncionalidad.TabIndex = 31;
            this.DGVFuncionalidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVFuncionalidad_CellContentClick);
            // 
            // idFuncionalidad
            // 
            this.idFuncionalidad.HeaderText = "idFuncionalidad";
            this.idFuncionalidad.Name = "idFuncionalidad";
            this.idFuncionalidad.ReadOnly = true;
            this.idFuncionalidad.Visible = false;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            this.Funcionalidad.ReadOnly = true;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblFuncionalidad);
            this.groupBox1.Controls.Add(this.CBFuncionalidad);
            this.groupBox1.Location = new System.Drawing.Point(92, 257);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(392, 132);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(10, 45);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 74);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // lblFuncionalidad
            // 
            this.lblFuncionalidad.AutoSize = true;
            this.lblFuncionalidad.Location = new System.Drawing.Point(196, 43);
            this.lblFuncionalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFuncionalidad.Name = "lblFuncionalidad";
            this.lblFuncionalidad.Size = new System.Drawing.Size(108, 20);
            this.lblFuncionalidad.TabIndex = 1;
            this.lblFuncionalidad.Text = "Funcionalidad";
            // 
            // CBFuncionalidad
            // 
            this.CBFuncionalidad.FormattingEnabled = true;
            this.CBFuncionalidad.Location = new System.Drawing.Point(195, 72);
            this.CBFuncionalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBFuncionalidad.Name = "CBFuncionalidad";
            this.CBFuncionalidad.Size = new System.Drawing.Size(180, 28);
            this.CBFuncionalidad.TabIndex = 0;
            this.CBFuncionalidad.Text = "Seleccionar";
            this.CBFuncionalidad.SelectedIndexChanged += new System.EventHandler(this.CBFuncionalidad_SelectedIndexChanged);
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(192, 82);
            this.lblRoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(50, 20);
            this.lblRoles.TabIndex = 28;
            this.lblRoles.Text = "Roles";
            // 
            // lbRoles
            // 
            this.lbRoles.FormattingEnabled = true;
            this.lbRoles.ItemHeight = 20;
            this.lbRoles.Location = new System.Drawing.Point(192, 111);
            this.lbRoles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbRoles.Name = "lbRoles";
            this.lbRoles.Size = new System.Drawing.Size(178, 104);
            this.lbRoles.TabIndex = 27;
            this.lbRoles.SelectedIndexChanged += new System.EventHandler(this.lbRoles_SelectedIndexChanged);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Titulo.Location = new System.Drawing.Point(135, 14);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(295, 37);
            this.Titulo.TabIndex = 26;
            this.Titulo.Text = "Modificacion de Rol";
            // 
            // cbInhabilitado
            // 
            this.cbInhabilitado.AutoSize = true;
            this.cbInhabilitado.Location = new System.Drawing.Point(201, 658);
            this.cbInhabilitado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbInhabilitado.Name = "cbInhabilitado";
            this.cbInhabilitado.Size = new System.Drawing.Size(117, 24);
            this.cbInhabilitado.TabIndex = 35;
            this.cbInhabilitado.Text = "Inhabilitado";
            this.cbInhabilitado.UseVisualStyleBackColor = true;
            // 
            // ModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 842);
            this.Controls.Add(this.cbInhabilitado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.DGVFuncionalidad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRoles);
            this.Controls.Add(this.lbRoles);
            this.Controls.Add(this.Titulo);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "ModificacionRol";
            this.Text = "Modificacion de Rol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModificacionRol_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFuncionalidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView DGVFuncionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFuncionalidad;
        private System.Windows.Forms.ComboBox CBFuncionalidad;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.ListBox lbRoles;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.CheckBox cbInhabilitado;
    }
}
namespace parcialCRUD
{
    partial class Form1
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
            this.dtgvtablas = new System.Windows.Forms.DataGridView();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.lblfechavencimiento = new System.Windows.Forms.Label();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblmarca = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.marca = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtablas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvtablas
            // 
            this.dtgvtablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvtablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.descripcion,
            this.existencia,
            this.fechavencimiento,
            this.fechacreacion,
            this.categoria,
            this.marca1,
            this.Estado});
            this.dtgvtablas.Location = new System.Drawing.Point(12, 219);
            this.dtgvtablas.Name = "dtgvtablas";
            this.dtgvtablas.Size = new System.Drawing.Size(823, 265);
            this.dtgvtablas.TabIndex = 0;
            this.dtgvtablas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvtablas_CellContentClick);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(49, 75);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(44, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(122, 72);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(122, 121);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(49, 124);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbldescripcion.TabIndex = 3;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(122, 170);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(100, 20);
            this.txtExistencia.TabIndex = 6;
            // 
            // lblexistencia
            // 
            this.lblexistencia.AutoSize = true;
            this.lblexistencia.Location = new System.Drawing.Point(49, 173);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(55, 13);
            this.lblexistencia.TabIndex = 5;
            this.lblexistencia.Text = "Existencia";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(335, 72);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVencimiento.TabIndex = 8;
            // 
            // lblfechavencimiento
            // 
            this.lblfechavencimiento.AutoSize = true;
            this.lblfechavencimiento.Location = new System.Drawing.Point(231, 75);
            this.lblfechavencimiento.Name = "lblfechavencimiento";
            this.lblfechavencimiento.Size = new System.Drawing.Size(98, 13);
            this.lblfechavencimiento.TabIndex = 7;
            this.lblfechavencimiento.Text = "Fecha Vencimiento";
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(335, 121);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(100, 20);
            this.txtFechaCreacion.TabIndex = 10;
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(247, 124);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(82, 13);
            this.lblFechaCreacion.TabIndex = 9;
            this.lblFechaCreacion.Text = "Fecha Creacion";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(335, 170);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 12;
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(484, 75);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(52, 13);
            this.lblmarca.TabIndex = 11;
            this.lblmarca.Text = "Categoria";
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(557, 72);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(100, 20);
            this.txtmarca.TabIndex = 14;
            // 
            // marca
            // 
            this.marca.AutoSize = true;
            this.marca.Location = new System.Drawing.Point(271, 173);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(37, 13);
            this.marca.TabIndex = 13;
            this.marca.Text = "Marca";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(557, 121);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 16;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(484, 124);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 15;
            this.lblestado.Text = "Estado";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(509, 173);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 17;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(642, 173);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 18;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // existencia
            // 
            this.existencia.HeaderText = "Existencia";
            this.existencia.Name = "existencia";
            // 
            // fechavencimiento
            // 
            this.fechavencimiento.HeaderText = "Fecha Vencimiento";
            this.fechavencimiento.Name = "fechavencimiento";
            // 
            // fechacreacion
            // 
            this.fechacreacion.HeaderText = "Fecha Creacion";
            this.fechacreacion.Name = "fechacreacion";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // marca1
            // 
            this.marca1.HeaderText = "Marca";
            this.marca1.Name = "marca1";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(836, 496);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.txtFechaVencimiento);
            this.Controls.Add(this.lblfechavencimiento);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lblexistencia);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.dtgvtablas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvtablas;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.Label lblfechavencimiento;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label marca;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
    }
}


namespace EjemploGrillas
{
    partial class Principal
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
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridFacturas = new System.Windows.Forms.DataGridView();
            this.gridFacturas2 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboClientes
            // 
            this.comboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(13, 42);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(121, 21);
            this.comboClientes.TabIndex = 0;
            this.comboClientes.SelectedIndexChanged += new System.EventHandler(this.comboClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro de cliente";
            // 
            // gridFacturas
            // 
            this.gridFacturas.AllowUserToAddRows = false;
            this.gridFacturas.AllowUserToDeleteRows = false;
            this.gridFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFacturas.Location = new System.Drawing.Point(13, 70);
            this.gridFacturas.Name = "gridFacturas";
            this.gridFacturas.ReadOnly = true;
            this.gridFacturas.Size = new System.Drawing.Size(411, 213);
            this.gridFacturas.TabIndex = 2;
            // 
            // gridFacturas2
            // 
            this.gridFacturas2.AllowUserToAddRows = false;
            this.gridFacturas2.AllowUserToDeleteRows = false;
            this.gridFacturas2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFacturas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFacturas2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Fecha,
            this.Modificar,
            this.Eliminar});
            this.gridFacturas2.Location = new System.Drawing.Point(12, 302);
            this.gridFacturas2.Name = "gridFacturas2";
            this.gridFacturas2.ReadOnly = true;
            this.gridFacturas2.Size = new System.Drawing.Size(412, 196);
            this.gridFacturas2.TabIndex = 3;
            this.gridFacturas2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFacturas2_CellClick);
            this.gridFacturas2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFacturas2_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "NumeroFactura";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForLinkValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.DataPropertyName = "(ninguno)";
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 508);
            this.Controls.Add(this.gridFacturas2);
            this.Controls.Add(this.gridFacturas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridFacturas;
        private System.Windows.Forms.DataGridView gridFacturas2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewLinkColumn Modificar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
    }
}



namespace ModificadorDePedidos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtEmpresas = new System.Windows.Forms.TextBox();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtMedidaInterna = new System.Windows.Forms.TextBox();
            this.cmbFlete = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rbtAscendente = new System.Windows.Forms.RadioButton();
            this.rbtDescendente = new System.Windows.Forms.RadioButton();
            this.FDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedInterna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deadline = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Senasa = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Emb = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Transporte = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enviofacturable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FDA,
            this.IdPedido,
            this.RecIdItem,
            this.Pedido,
            this.Cliente,
            this.Cantidad,
            this.MedInterna,
            this.Info,
            this.Deadline,
            this.Senasa,
            this.Emb,
            this.Transporte,
            this.Factura,
            this.Remito,
            this.Color,
            this.Produccion,
            this.enviofacturable});
            this.dgvPedidos.Location = new System.Drawing.Point(12, 51);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(1349, 626);
            this.dgvPedidos.TabIndex = 0;
            this.dgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellClick);
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            this.dgvPedidos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPedidos_CellMouseDown);
            this.dgvPedidos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPedidos_DataError);
            this.dgvPedidos.Sorted += new System.EventHandler(this.dgvPedidos_Sorted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Checked = false;
            this.dtpFecha.Location = new System.Drawing.Point(198, 25);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.Value = new System.DateTime(2022, 6, 15, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(893, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtEmpresas
            // 
            this.txtEmpresas.Location = new System.Drawing.Point(16, 24);
            this.txtEmpresas.Name = "txtEmpresas";
            this.txtEmpresas.Size = new System.Drawing.Size(176, 20);
            this.txtEmpresas.TabIndex = 6;
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(405, 25);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(161, 20);
            this.txtPedido.TabIndex = 7;
            // 
            // txtMedidaInterna
            // 
            this.txtMedidaInterna.Location = new System.Drawing.Point(572, 24);
            this.txtMedidaInterna.Name = "txtMedidaInterna";
            this.txtMedidaInterna.Size = new System.Drawing.Size(150, 20);
            this.txtMedidaInterna.TabIndex = 8;
            // 
            // cmbFlete
            // 
            this.cmbFlete.FormattingEnabled = true;
            this.cmbFlete.Items.AddRange(new object[] {
            "",
            "Retiran",
            "Entregamos"});
            this.cmbFlete.Location = new System.Drawing.Point(728, 23);
            this.cmbFlete.Name = "cmbFlete";
            this.cmbFlete.Size = new System.Drawing.Size(159, 21);
            this.cmbFlete.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numero de pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Medida Interna:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(728, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Flete";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1296, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(990, 21);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rbtAscendente
            // 
            this.rbtAscendente.AutoSize = true;
            this.rbtAscendente.Location = new System.Drawing.Point(1096, 23);
            this.rbtAscendente.Name = "rbtAscendente";
            this.rbtAscendente.Size = new System.Drawing.Size(82, 17);
            this.rbtAscendente.TabIndex = 15;
            this.rbtAscendente.TabStop = true;
            this.rbtAscendente.Text = "Ascendente";
            this.rbtAscendente.UseVisualStyleBackColor = true;
            this.rbtAscendente.CheckedChanged += new System.EventHandler(this.rbtAscendente_CheckedChanged);
            // 
            // rbtDescendente
            // 
            this.rbtDescendente.AutoSize = true;
            this.rbtDescendente.Location = new System.Drawing.Point(1187, 23);
            this.rbtDescendente.Name = "rbtDescendente";
            this.rbtDescendente.Size = new System.Drawing.Size(89, 17);
            this.rbtDescendente.TabIndex = 16;
            this.rbtDescendente.TabStop = true;
            this.rbtDescendente.Text = "Descendente";
            this.rbtDescendente.UseVisualStyleBackColor = true;
            this.rbtDescendente.CheckedChanged += new System.EventHandler(this.rbtDescendente_CheckedChanged);
            // 
            // FDA
            // 
            this.FDA.DataPropertyName = "FDA";
            this.FDA.HeaderText = "FDA";
            this.FDA.Name = "FDA";
            this.FDA.ReadOnly = true;
            // 
            // IdPedido
            // 
            this.IdPedido.DataPropertyName = "RecIdPedido";
            this.IdPedido.HeaderText = "Id pedido";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.Visible = false;
            // 
            // RecIdItem
            // 
            this.RecIdItem.DataPropertyName = "RecIdItem";
            this.RecIdItem.HeaderText = "RecIdItem";
            this.RecIdItem.Name = "RecIdItem";
            this.RecIdItem.Visible = false;
            // 
            // Pedido
            // 
            this.Pedido.DataPropertyName = "Pedido";
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // MedInterna
            // 
            this.MedInterna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedInterna.DataPropertyName = "MED INTERNA";
            this.MedInterna.HeaderText = "Med interna";
            this.MedInterna.Name = "MedInterna";
            this.MedInterna.ReadOnly = true;
            // 
            // Info
            // 
            this.Info.DataPropertyName = "Info";
            this.Info.HeaderText = "Info";
            this.Info.Name = "Info";
            // 
            // Deadline
            // 
            this.Deadline.DataPropertyName = "Deadline";
            this.Deadline.HeaderText = "Deadline";
            this.Deadline.Name = "Deadline";
            this.Deadline.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Deadline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Senasa
            // 
            this.Senasa.DataPropertyName = "Senasa";
            this.Senasa.HeaderText = "Senasa";
            this.Senasa.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.Senasa.Name = "Senasa";
            this.Senasa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Senasa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Emb
            // 
            this.Emb.DataPropertyName = "Embalaje";
            this.Emb.HeaderText = "Emb";
            this.Emb.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.Emb.Name = "Emb";
            this.Emb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Emb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Transporte
            // 
            this.Transporte.DataPropertyName = "EnvioFacturable2";
            this.Transporte.HeaderText = "Transporte";
            this.Transporte.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.Transporte.Name = "Transporte";
            this.Transporte.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Transporte.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Factura
            // 
            this.Factura.DataPropertyName = "Factura";
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            // 
            // Remito
            // 
            this.Remito.DataPropertyName = "Remito";
            this.Remito.HeaderText = "Remito";
            this.Remito.Name = "Remito";
            this.Remito.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.Visible = false;
            // 
            // Produccion
            // 
            this.Produccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produccion.DataPropertyName = "Produccion";
            this.Produccion.HeaderText = "Produccion";
            this.Produccion.Name = "Produccion";
            // 
            // enviofacturable
            // 
            this.enviofacturable.DataPropertyName = "enviofacturable";
            this.enviofacturable.HeaderText = "enviofacturable";
            this.enviofacturable.Name = "enviofacturable";
            this.enviofacturable.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 689);
            this.Controls.Add(this.rbtDescendente);
            this.Controls.Add(this.rbtAscendente);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFlete);
            this.Controls.Add(this.txtMedidaInterna);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.txtEmpresas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtEmpresas;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtMedidaInterna;
        private System.Windows.Forms.ComboBox cmbFlete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rbtAscendente;
        private System.Windows.Forms.RadioButton rbtDescendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedInterna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.DataGridViewButtonColumn Deadline;
        private System.Windows.Forms.DataGridViewComboBoxColumn Senasa;
        private System.Windows.Forms.DataGridViewComboBoxColumn Emb;
        private System.Windows.Forms.DataGridViewComboBoxColumn Transporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn enviofacturable;
    }
}


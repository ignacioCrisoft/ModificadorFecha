using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace ModificadorDePedidos
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataTable dtEmpresas = new DataTable();
        Negocios.NegociosFunciones negociosFunciones = new Negocios.NegociosFunciones();
        string IdRecPedido = string.Empty;
        string IdRecItem = string.Empty;
        DateTime Fecha;
        bool SenasaColumn;
        bool EmbalajeColumn;
        bool TransporteColumn;

        public Form1()
        {
            InitializeComponent();
            dt = negociosFunciones.getPedidos();
            dtEmpresas.Rows.Add();
            dtEmpresas = negociosFunciones.GetEmpresas();
            dgvPedidos.DataSource = dt;
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvPedidos_EditingControlShowing);
            CargarCultura();
            dtpFecha.Value = DateTime.ParseExact("18000101", "yyyyMMdd", CultureInfo.InvariantCulture).Date;

            DateTime a = DateTime.ParseExact("18000101", "yyyyMMdd", CultureInfo.InvariantCulture).Date;

            System.IO.StreamWriter oLog = null;
            oLog = new System.IO.StreamWriter(Application.StartupPath + "\\Errores.log", true);
            oLog.WriteLine(a);
            oLog.Close();
            oLog.Dispose();


            txtEmpresas.AutoCompleteCustomSource = LoadAutoComplete();
            txtEmpresas.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtEmpresas.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void CargarCultura()
        {
            try
            {
                CultureInfo cultura = new CultureInfo("es-AR");
                cultura.NumberFormat.NumberGroupSeparator = ",";
                cultura.NumberFormat.CurrencyGroupSeparator = ",";
                cultura.NumberFormat.NumberDecimalSeparator = ".";
                cultura.NumberFormat.CurrencyDecimalSeparator = ".";

                System.Threading.Thread.CurrentThread.CurrentCulture = cultura;
            }
            catch { throw; }
        }

        DateTimePicker Dtp;
        public  AutoCompleteStringCollection LoadAutoComplete()
        {
            DataTable dt = negociosFunciones.GetEmpresas();

            AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

            foreach (DataRow row in dt.Rows)
            {
                stringCol.Add(Convert.ToString(row["Empresa"]));
            }

            return stringCol;
        }

        public void RecargarTabla()
        {
            dt = negociosFunciones.getPedidos();
            dgvPedidos.DataSource = dt;
        }

        private void dgvPedidos_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            // Prevent System.ArgumentException: DataGridViewComboBoxCell value is not valid
            e.Row.Cells["Senasa"].Value = "";
            e.Row.Cells["Emb"].Value = "";
        }
        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 7)
                {
                    Dtp = new DateTimePicker();
                    dgvPedidos.Controls.Add(Dtp);
                    Dtp.Visible = false;
                    Dtp.Format = DateTimePickerFormat.Short;
                    Dtp.TextChanged += new EventHandler(Dtp_OnTextChange);
                    Dtp.Visible = true;
                    Rectangle rectangle1 = dgvPedidos.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    Dtp.Size = new Size(rectangle1.Width, rectangle1.Height);
                    Dtp.Location = new Point(rectangle1.X, rectangle1.Y);
                    if (e.RowIndex > 0)
                    {
                        IdRecPedido = dgvPedidos.Rows[e.RowIndex].Cells["IdPedido"].Value.ToString();
                        IdRecItem = dgvPedidos.Rows[e.RowIndex].Cells["RecIdItem"].Value.ToString();
                    }
                    Dtp.CloseUp += new EventHandler(dateTimePicker1_CloseUp);
                }
            }
           
        }

        private void Dtp_OnTextChange(object sender, EventArgs e)
        {
            dgvPedidos.CurrentCell.Value = Dtp.Text.ToString();
        }

        void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            DateTime NuevaFecha = Dtp.Value;
            negociosFunciones.UpdateFechaPedido(NuevaFecha, IdRecPedido,IdRecItem);
            Dtp.Visible = false;
        }

        private void dgvPedidos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
                combo.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {  
            ComboBox cb = (ComboBox)sender;
            string item = cb.Text;
            string Senasa = string.Empty;
            string Embalaje = string.Empty;
            string Transporte = string.Empty;
            if (item != null)
            {
                if (SenasaColumn == true)
                {
                    if (item == "Si")
                    {
                        Senasa = "Si";
                    }
                    if (item == "No")
                    {
                        Senasa = "No";
                    }
                }

                if (EmbalajeColumn == true )
                {
                    if (item == "Si")
                    {
                        Embalaje = "Si";
                    }
                    if (item == "No")
                    {
                        Embalaje = "No";
                    }
                }

                if (TransporteColumn == true)
                {
                    if (item == "Si")
                    {
                        Transporte = "0";
                    }
                    if (item == "No")
                    {
                        Transporte = "1";
                    }
                }
            }
            negociosFunciones.InsertSenasaEmbalaje(IdRecItem.ToString(), Senasa, Embalaje, Transporte);
            SenasaColumn = false;
            EmbalajeColumn = false;
            TransporteColumn = false;
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                IdRecItem = dgvPedidos.Rows[e.RowIndex].Cells["RecIdItem"].Value.ToString();
            }

            if (e.ColumnIndex == 11)
            {
                SenasaColumn = true;
            }
            if (e.ColumnIndex == 12)
            {
                EmbalajeColumn = true;
            }
            if (e.ColumnIndex == 17)
            {
                TransporteColumn = true;
            }
            if (e.ColumnIndex == 15)
            {
                frmInfo frmInfo = new frmInfo(IdRecItem);
                frmInfo.ShowDialog();
                btnBuscar_Click(sender, e);
                Form1_Load_1(sender, e);
            }
            if (e.ColumnIndex == 14)
            {
                frmProduccion frmProduccion = new frmProduccion(IdRecItem);
                frmProduccion.ShowDialog();
                btnBuscar_Click(sender, e);
                Form1_Load_1(sender, e);
            }
        }

        private void dgvPedidos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                IdRecItem = dgvPedidos.Rows[e.RowIndex].Cells["RecIdItem"].Value.ToString();
                IdRecPedido = dgvPedidos.Rows[e.RowIndex].Cells["IdPedido"].Value.ToString();
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Color", new System.EventHandler(this.color_Click)));
                m.MenuItems.Add(new MenuItem("Detalle", new System.EventHandler(this.detalle_Click)));

                int currentMouseOverRow = dgvPedidos.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dgvPedidos, dgvPedidos.PointToClient(Cursor.Position));

            }
        }

        private void color_Click(Object sender, EventArgs e)
        {
            frmColor frmColor = new frmColor(IdRecItem);
            frmColor.ShowDialog();
            RecargarTabla();
            Form1_Load_1(sender, e);
        }

        private void detalle_Click(Object sender, EventArgs e)
        {
            frmDetalle frmDetalle = new frmDetalle(IdRecPedido);
            frmDetalle.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.CustomFormat = "dd/MM/yyyy ";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = null;
            string Flete = string.Empty;
            string Empresa = txtEmpresas.Text;
            string Pedido = txtPedido.Text;
            if (cmbFlete.SelectedItem != null)
            {
                Flete = cmbFlete.SelectedItem.ToString();
            }
            string MedidaInterna = txtMedidaInterna.Text;
            Fecha = dtpFecha.Value;

            dt = negociosFunciones.GetPedidosFiltros(Empresa, Fecha, Pedido, Flete, MedidaInterna);
            dgvPedidos.DataSource = dt;
            Form1_Load_1(sender, e);
        }

        private void dgvPedidos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                string color = row["Color"].ToString();
                if (color != "")
                {
                    dgvPedidos.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromName(color);
                }

                i++;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvPedidos.DataSource = null;

            DataTable dt = new DataTable();
            dt = negociosFunciones.getPedidos();
            dgvPedidos.DataSource = dt;
            Form1_Load_1(sender, e);

            txtEmpresas.Text = "";
            txtMedidaInterna.Text = "";
            txtPedido.Text = "";
        }

        private void dgvPedidos_Sorted(object sender, EventArgs e)
        {

            button1_Click(sender, e);
        }

        private void rbtAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtAscendente.Checked == true)
            {
                dt = dt.AsEnumerable().OrderBy(x => x.Field<DateTime>("DEADLINE")).CopyToDataTable();
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = dt;
                button1_Click(sender, e);
            }
            else
            {
                dt = negociosFunciones.getPedidos();
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = dt;
                button1_Click(sender, e);
            }
        }

        private void rbtDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtDescendente.Checked == true)
            {
                dt = dt.AsEnumerable().OrderByDescending(x => x.Field<DateTime>("DEADLINE")).CopyToDataTable();
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = dt;
                button1_Click(sender, e);
            }
            else
            {
                dt = negociosFunciones.getPedidos();
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = dt;
                button1_Click(sender, e);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModificadorDePedidos
{
    public partial class frmDetalle : Form
    {
        public string RecIdPedido { get; set; }
        Negocios.NegociosFunciones NegociosFunciones = new Negocios.NegociosFunciones();
        public frmDetalle(string RecIdPedido)
        {
            InitializeComponent();
            this.RecIdPedido = RecIdPedido;

            DataTable dt = new DataTable();
            dt = NegociosFunciones.SelectDetallePedido(RecIdPedido);
            dgvDetalles.DataSource = dt;
            dgvDetalles.AutoGenerateColumns = false;
        }
    }
}

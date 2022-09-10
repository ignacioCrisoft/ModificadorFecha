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
    public partial class frmProduccion : Form
    {
        public string IdRecItem { get; set; }
        Negocios.NegociosFunciones negociosFunciones = new Negocios.NegociosFunciones();
        public frmProduccion(string IdRecItem)
        {
            InitializeComponent();
            this.IdRecItem = IdRecItem;
            string Produccion = negociosFunciones.GetProduccion(this.IdRecItem);
            txtProduccion.Text = Produccion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string produccion = txtProduccion.Text;
                negociosFunciones.UpdateProduccion(IdRecItem, produccion);
                this.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

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
    public partial class frmInfo : Form
    {
        public string RecId { get; set; }
        Negocios.NegociosFunciones NegociosFunciones = new Negocios.NegociosFunciones();
        public frmInfo(string RecId)
        {
            InitializeComponent();
            this.RecId = RecId;
            string Info = NegociosFunciones.GetInfo(this.RecId);
            txtInfo.Text = Info;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Info = txtInfo.Text;
            if(NegociosFunciones.UpdateInfo(RecId, Info))
            {
                this.Close();
            }
            else
            {
                string text = "La información no pudo ser guardada.";
                MessageBox.Show(text);
            }
        }
    }
}

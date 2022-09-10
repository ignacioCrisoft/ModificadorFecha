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
    public partial class frmColor : Form
    {
        Negocios.NegociosFunciones NegociosFunciones = new Negocios.NegociosFunciones();
        public string RecIdItem { get; set; }
        public frmColor(string RecIdItem)
        {
            InitializeComponent();
            this.RecIdItem = RecIdItem;

            cmbColores.DataSource = typeof(Color).GetProperties()
            .Where(x => x.PropertyType == typeof(Color))
            .Select(x => x.GetValue(null)).ToList();

            cmbColores.MaxDropDownItems = 10;
            cmbColores.IntegralHeight = false;
            cmbColores.DrawMode = DrawMode.OwnerDrawFixed;
            cmbColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColores.DrawItem += cmbColores_DrawItem;
        }

        private void cmbColores_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cmbColores.GetItemText(cmbColores.Items[e.Index]);
                var color = (Color)cmbColores.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cmbColores.Font, r2,
                    cmbColores.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorInicial = cmbColores.SelectedValue.ToString();
            string ColorFinal = new string(colorInicial.SkipWhile(c => c != '[')
                           .Skip(1)
                           .TakeWhile(c => c != ']')
                           .ToArray()).Trim();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string colorInicial = cmbColores.SelectedValue.ToString();
            string ColorFinal = new string(colorInicial.SkipWhile(c => c != '[')
                           .Skip(1)
                           .TakeWhile(c => c != ']')
                           .ToArray()).Trim();

            if(NegociosFunciones.InsertColor(ColorFinal, RecIdItem))
            {
                this.Close();
            }
            else
            {
                string text = "El color no pudo ser guardado";
                MessageBox.Show(text);
            }
        }
    }
}

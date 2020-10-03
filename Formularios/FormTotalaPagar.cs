using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1_AlexOmarMartinezRamos.Formularios
{
    public partial class FormTotalaPagar : Form
    {
        public FormTotalaPagar()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtCantidad.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingrese Cantidad");
                TxtCantidad.Focus();
                return;
            }
            if(TxtPrecio.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Precio");
                TxtPrecio.Focus();
                return;
            }

            double c, p, t;

            c = Convert.ToDouble(TxtCantidad.Text);
            p = Convert.ToDouble(TxtPrecio.Text);

            t = c * p;

            TxtTotal.Text = t.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtCantidad.Clear();
            TxtPrecio.Clear();
            TxtTotal.Clear();
            TxtCantidad.Focus();
        }
    }
}

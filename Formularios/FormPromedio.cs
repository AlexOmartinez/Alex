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
    public partial class FormPromedio : Form
    {
        public FormPromedio()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtCalificacion1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {
            if (TxtCalificacion1.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingresar la Calificacion 1");
                TxtCalificacion1.Focus();
                return;
            }
            if (TxtCalificacion2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Calificacion 2");
                TxtCalificacion2.Focus();
                return;
            }
            if (TxtCalificacion3.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Calificacion 3");
                TxtCalificacion3.Focus();
                return;
            }
            if (TxtCalificacion4.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Calificacion 4");
                TxtCalificacion4.Focus();
                return;
            }
            Double r,c1, c2, c3, c4;

            c1 = Convert.ToDouble(TxtCalificacion1.Text);
            c2 = Convert.ToDouble(TxtCalificacion2.Text);
            c3 = Convert.ToDouble(TxtCalificacion3.Text);
            c4 = Convert.ToDouble(TxtCalificacion4.Text);

            r = (c1 + c2 + c3 + c4) / 4;

            TxtResultado.Text = r.ToString();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtCalificacion1.Clear();
            TxtCalificacion2.Clear();
            TxtCalificacion3.Clear();
            TxtCalificacion4.Clear();
            TxtResultado.Clear();
            TxtCalificacion1.Focus();
        }
    }
}

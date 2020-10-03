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
    public partial class FormMillasaMetros : Form
    {
        public FormMillasaMetros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (TxtMillas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Millas");
                TxtMillas.Focus();
                return;
            }
            double r, m;

            m = Convert.ToDouble(TxtMillas.Text);

            r = m * 1609.34;

            TxtMetros.Text = r.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtMillas.Clear();
            TxtMetros.Clear();
            TxtMillas.Focus();
        }

        private void TxtMetros_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtMillas_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

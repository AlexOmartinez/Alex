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
    public partial class FormMillasaKilometros : Form
    {
        public FormMillasaKilometros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMillasaKilometros_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (TxtMillas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar Millas");
                TxtMillas.Focus();
                return;
            }
            Double r,m;

            m = Convert.ToDouble(TxtMillas.Text);

            r = m * 1.60934;

            TxtKilometros.Text = r.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtMillas.Clear();
            TxtKilometros.Clear();
        }
    }
}

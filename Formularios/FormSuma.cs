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
    public partial class FormSuma : Form
    {
        public FormSuma()
        {
            InitializeComponent();
        }

        private void FormSuma_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            if (TxtPrimerNumero.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar el Primer Numero");
                TxtPrimerNumero.Focus();
                return;
            }
            if (TxtSegundoNumero.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Segundo Numero");
                TxtSegundoNumero.Focus();
                return;
            }
            if (TxtTercerNumero.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Tercer Numero");
                TxtTercerNumero.Focus();
                return;
            }

            double r,a, b, c;
            a = Convert.ToDouble(TxtPrimerNumero.Text);
            b = Convert.ToDouble(TxtSegundoNumero.Text);
            c = Convert.ToDouble(TxtTercerNumero.Text);

            r = a + b + c;

            TxtResultado.Text = r.ToString();

        }

        private void TxtSegundoNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtTercerNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPrimerNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtPrimerNumero.Clear();
            TxtSegundoNumero.Clear();
            TxtTercerNumero.Clear();
            TxtResultado.Clear();
            TxtPrimerNumero.Focus();
        }
    }
}

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
    public partial class FormLempirasaEuros : Form
    {
        public FormLempirasaEuros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtLempiras.Clear();
            TxtEuros.Clear();
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (TxtLempiras.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingrese Lempiras");
                TxtLempiras.Focus();
                return;

            }
            double r, l;

            l = Convert.ToDouble(TxtLempiras.Text);

            r = l * 0.035;

            TxtEuros.Text = r.ToString();
        }
    }
}

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
    public partial class FormGalonesaLitros : Form
    {
        public FormGalonesaLitros()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtGalones.Clear();
            TxtLitros.Clear();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (TxtGalones.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingrese Galones");
                TxtGalones.Focus();
                return;
            }
            double g,l;

            g = Convert.ToDouble(TxtGalones.Text);

            l = g * 3.785411784;

            TxtLitros.Text = l.ToString();
        }
    }
}

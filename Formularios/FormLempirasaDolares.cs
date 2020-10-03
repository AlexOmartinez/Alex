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
    public partial class FormLempirasaDolares : Form
    {
        public FormLempirasaDolares()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLempirasaDolares_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtLempiras.Clear();
            TxtDolares.Clear();
        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            if (TxtLempiras.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingrese Lempiras");
                TxtLempiras.Focus();
                return;
            }
            double r, l;

            l = Convert.ToDouble(TxtLempiras.Text);

            r = l * 0.041;

            TxtDolares.Text = r.ToString();
        }
    }
}

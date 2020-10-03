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
    public partial class FormSalario : Form
    {
        public FormSalario()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtDiasTrabajados.Clear();
            TxtPrecioporDia.Clear();
            TxtTotalaPagar.Clear();
            TxtDiasTrabajados.Focus();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (TxtDiasTrabajados.Text.Trim().Length==0)
            {
                MessageBox.Show("Ingrese Dias Trabajados");
                TxtDiasTrabajados.Focus();
                return;
            }
            if (TxtPrecioporDia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Precio por Dia");
                TxtPrecioporDia.Focus();
                return;
            }
            double dt, pd, tp;

            dt = Convert.ToDouble(TxtDiasTrabajados.Text);
            pd = Convert.ToDouble(TxtPrecioporDia.Text);

            tp = dt * pd;

            TxtTotalaPagar.Text = tp.ToString();


        }


    }
}

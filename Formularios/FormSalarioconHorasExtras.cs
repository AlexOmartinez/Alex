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
    public partial class FormSalarioconHorasExtras : Form
    {
        public FormSalarioconHorasExtras()
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
            TxtHorasExtras.Clear();
            TxtValorHoraExtra.Clear();
            TxtSalario.Clear();
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
                MessageBox.Show("Ingrese Precio por dia");
                TxtPrecioporDia.Focus();
                return;
            }
            if (TxtHorasExtras.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Horas Extras");
                TxtHorasExtras.Focus();
                return;
            }
            if (TxtValorHoraExtra.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese Valor Hora Extra");
                TxtValorHoraExtra.Focus();
                return;
            }
            double dt, pd, he, vhe, st;

            dt = Convert.ToDouble(TxtDiasTrabajados.Text);
            pd = Convert.ToDouble(TxtPrecioporDia.Text);
            he = Convert.ToDouble(TxtHorasExtras.Text);
            vhe = Convert.ToDouble(TxtValorHoraExtra.Text);

            st = (dt * pd) + (he * vhe);

            TxtSalario.Text =st.ToString();
        }
    }
}

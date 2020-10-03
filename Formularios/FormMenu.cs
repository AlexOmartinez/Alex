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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Formularios.FormSuma Suma = new Formularios.FormSuma();
            Suma.ShowDialog();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPromedio_Click(object sender, EventArgs e)
        {
            Formularios.FormPromedio Promedio = new Formularios.FormPromedio();
            Promedio.ShowDialog();
        }

        private void BtnMillasaMetros_Click(object sender, EventArgs e)
        {
            Formularios.FormMillasaMetros MillasaMetros = new Formularios.FormMillasaMetros();
            MillasaMetros.ShowDialog();
        }

        private void BtnMillasaKilometros_Click(object sender, EventArgs e)
        {
            Formularios.FormMillasaKilometros MillasaKilometros = new Formularios.FormMillasaKilometros();
            MillasaKilometros.ShowDialog();
        }

        private void BtnLempirasaDolares_Click(object sender, EventArgs e)
        {
            Formularios.FormLempirasaDolares LempirasaDolares = new Formularios.FormLempirasaDolares();
            LempirasaDolares.ShowDialog();
        }

        private void BtnLempirasaEuros_Click(object sender, EventArgs e)
        {
            Formularios.FormLempirasaEuros lempirasaEuros = new Formularios.FormLempirasaEuros();
            lempirasaEuros.ShowDialog();
        }

        private void BtnTotalaPagar_Click(object sender, EventArgs e)
        {
            Formularios.FormTotalaPagar TotalaPagar = new Formularios.FormTotalaPagar();
            TotalaPagar.ShowDialog();
        }

        private void BtnSalario_Click(object sender, EventArgs e)
        {
            Formularios.FormSalario Salario = new Formularios.FormSalario();
            Salario.ShowDialog();
        }

        private void BtnSalarioconHorasExtras_Click(object sender, EventArgs e)
        {
            Formularios.FormSalarioconHorasExtras SalarioconHorasExtras = new Formularios.FormSalarioconHorasExtras();
            SalarioconHorasExtras.ShowDialog();
        }

        private void BtnGalonesaLitros_Click(object sender, EventArgs e)
        {
            Formularios.FormGalonesaLitros GalonesaLitros = new Formularios.FormGalonesaLitros();
            GalonesaLitros.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L8_forms_JDTG_1067123
{
    public partial class Form: UserControl
    {
        public Form()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Seleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CMB1.SelectedIndex)
            {
                //sumatoria
                case 0:
                    MessageBox.Show("Hola super humano vamos a seleccionar la pestaña de sumatoria");
                    tabControl1.SelectedTab = tabPage1;
                    Info_sumatoria.Text = "Se realizará la suma de los números \nde 1 hasta el que usted ingrese";
                    TXT_suma.Text = "0";
                    break;
                //Tabla de multiplicar
                case 1:
                    MessageBox.Show("Hola super humano vamos a seleccionar la pestaña de tablas");
                    tabControl1.SelectedTab = tabPage2;
                    Info_tabla.Text = "Se mostrará la tabla de multiplicación \ndel número que usted ingrese";
                    TXT_tabla.Text = "0";
                    break;
                case 2:
                    MessageBox.Show("Hola super humano vamos a seleccionar la pestaña de numero perfecto");
                    tabControl1.SelectedTab = tabPage3;
                    Info_nper.Text = "Deberá ingresar un número y se evaluará si es perfecto o no. \nUn número perfecto es aquel" +
                                     " cuyos divisores al sumarse es igual al número evaluado";
                    TXT_nper.Text = "0";
                    break;
            }
        }

        private void TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_suma_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = Convert.ToInt32(TXT_suma.Text);
                int suma = 0;

                for (int i1 = 0; i1 <= n1; i1++)
                {
                    suma += i1;
                }
                TXT_resul_sum.Text = "El resultado de la sumatoria es: " + suma.ToString();
            }
            catch { TXT_resul_sum.Text = "Ingrese un número"; }
        }

        private void BTN_tabla_Click(object sender, EventArgs e)
        {
            try
            {
                int n2 = Convert.ToInt32(TXT_tabla.Text);
                int mult = 0;
                string cadena = "", resultados = "";

                for (int i2 = 0; i2 <= 10; i2++)
                {
                    mult = n2 * i2;
                    resultados = $"{n2} * {i2} = {mult} \t";
                    cadena += resultados;
                }
                TXT_resul_tabla.Text = cadena;
            }
            catch { TXT_resul_tabla.Text = "Ingrese un número"; }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void TXT_resul_tabla_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_nper_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n3 = Convert.ToInt32(TXT_nper.Text);
                int i3 = 2, suma = 0;

                while (i3 <= n3)
                {
                    if (n3 % i3 == 0)
                    {
                        suma = suma + (n3 / i3);
                    }
                    i3 = i3 + 1;
                }
                if (suma == n3)
                {
                    TXT_resul_nper.Text = "El número que ingresó es pefecto";
                }
                else
                {
                    TXT_resul_nper.Text = "El nuúmero que ingresó no es perfecto";
                }
            }
            catch { TXT_resul_nper.Text = "Ingrese un número";  }
        }

        private void LBL_seleccion_programa_Click(object sender, EventArgs e)
        {

        }
    }
}

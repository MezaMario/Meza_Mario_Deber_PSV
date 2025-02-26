using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculador
{
    public partial class CalCul : Form
    {
        public CalCul()
        {

            InitializeComponent();
        }

        private void btn_Calcu_Click(object sender, EventArgs e)
        {
            calcularOperacion();

        }

        Matematica mat;

        private void calcularOperacion()
        {
            mat = new Matematica(int.Parse(num1.Text), int.Parse(num2.Text));
            if (Suuma.Checked)
            {
                MessageBox.Show("La suma es: " + mat.Sumar());
            }
            if (Reesta.Checked)
            {
                MessageBox.Show("La resta es: " + mat.Restar());
            }
            if (Multi.Checked)
            {
                MessageBox.Show("La multiplicacion es: " + mat.Multiplicar());
            }
            if (Divi.Checked)
            {
                MessageBox.Show("La division es: " + mat.Dividir());
            }
            if (modul.Checked)
            {
                MessageBox.Show("El modulo es: " + mat.Divide());
            }
        }

        private void persobt_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Show();
        }
    }
}

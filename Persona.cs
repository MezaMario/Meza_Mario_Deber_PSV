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
    public partial class Persona : Form
    {
        Crud crud = new Crud();
        public Persona()
        {
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string apellido = Apellido.Text;
            int cedula = Convert.ToInt32(Cedula.Text);
            int edad = Convert.ToInt32(Edad.Text);
            string ciudad = Ciudad.Text;

            ingreso persona = new ingreso(nombre, apellido, cedula, edad, ciudad);
            crud.agregar(persona);
            MessageBox.Show("Persona registrada");
        }

        private void mostrarl_Click(object sender, EventArgs e)
        {
            foreach (ingreso persona in crud.lista)
            {
                MessageBox.Show("Nombre: " + persona.nombre + "\nApellido: " + persona.apellido + "\nCedula: " + persona.cedula + "\nEdad: " + persona.edad + "\nCiudad: " + persona.ciudad);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Proyecto
{
    //se declara de forma global y se borra del boton
    //persona variable = nueva persona clasenombre

    public partial class Form1 : Form
    {
        Persona persona = new Persona();
        public Form1()
        {
            InitializeComponent();
            //para centrar el programa en la pantalla al correrlo
            this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            
            persona.Dpi = textBoxDPI.Text;

            persona.Nombre = textBoxNombre.Text;

            persona.Apellido = textBoxApellido.Text;

            persona.FechaNacimiento = dateTimePickerFechaNac.Value;

        }

        private void Mostrar()
        {
            labelDPI.Text = persona.Dpi; //to uper
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelFechaNacimiento.Text = persona.FechaNacimiento.ToString();
            int edad = persona.edad();
            labelEdad.Text = edad.ToString();

            //muestra visibles los label ya que los ocultamosen propiedades
            labelDPI.Visible = true;
            labelNombre.Visible = true;
            labelApellido.Visible = true;
            labelFechaNacimiento.Visible = true;
            labelEdad.Visible = true;
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();  

        }

        private void buttonPrimerMayuscula_Click(object sender, EventArgs e)
        {
            persona.PrimeraMayuscula();
            String nombre = persona.normalizarnombre();
            String apellido = persona.normalizarApellido();
            labelNombre.Text = nombre;
            labelApellido.Text = apellido;
            
        }

        private void dateTimePickerFechaNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Borrar datos ingresados en la caja de texto
            textBoxDPI.Text=string.Empty;
            textBoxNombre.Text=string.Empty;    
            textBoxApellido.Text=string.Empty;  
            dateTimePickerFechaNac.Text=string.Empty;   

            //Borrar datos mostrados en labels
            labelDPI.Text=string.Empty;
            labelNombre.Text = string.Empty;
            labelApellido.Text=string .Empty;
            labelFechaNacimiento.Text=string .Empty;    
            labelEdad.Text = string .Empty;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo_Proyecto
{
    internal class Persona
    {
        //campos
        //hay un private aunque no se vea :)
        //privados para cumplir con el encapsulado
        string dpi;
        string nombre;
        string apellido;
        DateTime fechaNacimiento;


        //Encapsulado
        public string Dpi { get => dpi; set => dpi = value; }

        public string Nombre { get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        //Métodos: Acciones que se realizan

        //Constructor de la clase:
        //Codigo que se ejecuta al crearse un objeto de esta clase
        //por ejemplo inicializar variables
        public Persona()
        {
            dpi = "";
            nombre = "";
            apellido = "";
            //inicializar con la fecha de hoy
            fechaNacimiento = DateTime.Now;
        }

        public void PrimeraMayuscula()
        {
            if (nombre.Length > 0)
            {
                StringBuilder nombreMayuscula =  new StringBuilder(nombre);
                nombreMayuscula[0] = Char.ToUpper(nombreMayuscula[0]);
                nombre = nombreMayuscula.ToString();

            }
            if (apellido.Length > 0)
            {
                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = Char.ToUpper(apellidoMayuscula[0]);
                apellido = apellidoMayuscula.ToString();
            }
        }

        public int edad()
        {
            //Calcular edad 
            DateTime FechaActual = DateTime.Today;

            //Calcular la diferencia en anios
            int edad = FechaActual.Year - fechaNacimiento.Year;

            //Ajustar fecha

            if (fechaNacimiento.Date > FechaActual.AddYears(-edad))
            {
                edad--;
            }
           
            return edad;
        }
        public string normalizarnombre()
        {
            // Eliminar espacios en blanco extra al inicio y al final
            nombre = nombre.Trim();

            // Eliminar cualquier símbolo que no sea una letra

            //nombre = new string(nombre.Where(char.IsLetterOrDigit).ToArray());

            nombre = new string(nombre.Where(c => char.IsLetter(c) || c == ' ').ToArray());



            // Dividir el nombre en palabras para capitalizar la primera letra de cada una
            var palabras = nombre.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < palabras.Length; i++)
            {
                // Capitaliza la primera letra de cada palabra y convierte a minúsculas el resto de la palabra
                palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
            }

            /*
            El filtro char.IsLetter(c) || c == ' ' asegura que solo se conserven letras
            y espacios. Luego, Split y Join se utilizan para separar y luego reconectar 
            las palabras, asegurando que los espacios entre las palabras se mantengan.
             */

            nombre = string.Join(" ", palabras);

            return nombre;
        }

        public string normalizarApellido() {
            // Eliminar espacios en blanco extra al inicio y al final
            apellido = apellido.Trim();

            // Eliminar cualquier símbolo que no sea una letra o espacio
            apellido = new string(apellido.Where(c => char.IsLetter(c) || c == ' ').ToArray());

            // Dividir el apellido en palabras para capitalizar la primera letra de cada una
            var palabras = apellido.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Capitalizar la primera letra de cada palabra y convertir a minúsculas el resto de la palabra
            for (int i = 0; i < palabras.Length; i++)
            {
                palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
            }

            // Reconstruir el apellido completo con las palabras normalizadas
            apellido = string.Join(" ", palabras);

            return apellido;
        }
    }
    
}

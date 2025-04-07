using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Promocion
{
    internal class Cursos
    {
        //Creamos una List de Ingresantes para cada curso
        static List<Ingresante> cSharp = new List<Ingresante>();
        static List<Ingresante> cMas = new List<Ingresante>();
        static List<Ingresante> javascript = new List<Ingresante>();

        public static List<Ingresante> CSharp
        {
            get { return cSharp; }
            set
            {
                cSharp = value;
            }
        }

        public static List<Ingresante> CMas
        {
            get { return cMas; }
            set
            {
                cMas = value;
            }
        }

        public static List<Ingresante> JavaScript
        {
            get { return javascript; }
            set
            {
                javascript = value;
            }
        }

        //Contamos los inscriptos en cada lista para no superar la capacidad
        public static string ContarIngresantes()
        {
            string cursoLleno = "";

            if (CSharp.Count >= 40)
            {
                cursoLleno += "C# ";
            }
            if (CMas.Count >= 40)
            {
                cursoLleno += "C++ ";
            }
            if (JavaScript.Count >= 40)
            {
                cursoLleno += "JavaScript ";
            }
            return cursoLleno;
        }

        //Mensaje para serialización exitosa
        public static void MensajeSerializacion()
        {
            MessageBox.Show("Serialización realizada con éxito.");
        }

    }
}

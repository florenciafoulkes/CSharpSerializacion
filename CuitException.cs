using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Promocion
{
    internal class ExcepcionPersonalizada : Exception
    {
        //Constructor
        public ExcepcionPersonalizada() { }

        //Sobreescritura de la propiedad Message para retornar un mensaje específico
        public override string Message => "CUIT inválido.";

        //Método estático para llamar a un mensaje personalizado que se muestra como MessageBox
        public static void Mensaje(string x)
        {
            MessageBox.Show(x);
        }

    }
}

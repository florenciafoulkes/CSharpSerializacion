using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Promocion
{
    internal class Funciones
    {
        //Calcula el dígito verificador dado un CUIT completo o sin él
        private static int CalcularDigitoCuit(string cuit)
        {
            //Factores de multiplicación para cada dígito del CUIT
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;


            //Multiplicación y suma de los dígitos del CUIT
            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }

            var resto = total % 11;

            //Retorna true si el dígito verificador corresponde
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }

        //Valido el cuit verificando que el código sea igual al dígito del CUIT
        public static bool ValidarCuit(string cuit)
        {
            try
            {
                if (cuit == null) // Si el CUIT es nulo lanzamos una referencia a valor nulo
                {
                    throw new NullReferenceException();
                }

                cuit = cuit.Replace("-", string.Empty);
                if (cuit.Length != 11) // Si no cumple el mín de caracteres lanzamos excepcion personalizada
                {
                    throw new ExcepcionPersonalizada();
                }
                else
                {
                    int calculado = CalcularDigitoCuit(cuit);
                    int digito = int.Parse(cuit.Substring(10));
                    return calculado == digito;
                }
            }
            catch (NullReferenceException nex) // Manejamos la excepción nula
            {
                MessageBox.Show("Debe ingresar un CUIT.");
                return false;
            }
            catch (ExcepcionPersonalizada ex) // Manejamos la excepción personalizada
            {
                ExcepcionPersonalizada.Mensaje(ex.Message);
                return false;
            }
            // Este bloque de catch no debería lanzarse ya que el maskedTextBox no lo permitiría
            catch (FormatException ex) // Manejamos excepción de formato de texto
            {
                MessageBox.Show("CUIT inválido");
                return false;
            }

        }


        //Consulta para revisar los datos ingresados antes de cargarlos
        public static bool Consulta(Form actual, string mensaje)
        {
            if (MessageBox.Show(actual, mensaje, "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Convierto un objeto Ingresante a una cadena de texto
        public static string IngresanteToString(Ingresante ing)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{ing.Nombre} | {ing.Direccion} | {ing.Cuit} | {ing.Pais} | {ing.CursosToString()}");

            return sb.ToString();

        }

        //Agrego el Ingresante al archivo .txt

        public static void AgregarAlArchivo(Ingresante ing, string archivo)
        {
            StreamWriter sw = null;
            string directorio = Directory.GetCurrentDirectory() + archivo;

            try
            {
                sw = new StreamWriter(directorio, true);
                sw.WriteLine(IngresanteToString(ing));
                sw.Close();
                sw.Dispose();
            }
            catch (IOException ex) // Manejo de excepcion si falla la escritura
            {
                ExcepcionPersonalizada.Mensaje("Error al escribir en el archivo.");
            }
            catch (UnauthorizedAccessException ex) // Manejo de excpecion ante falta de permisos
            {
                ExcepcionPersonalizada.Mensaje("No tiene permisos de acceder al archivo.");
            }
            finally // Si o si cerramos y soltamos el archivo
            {
                if (sw != null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }
        }

        //Métodos para cargar un Ingresante a través de la función anterior según curso seleccionado
        public static void AggCShar(Ingresante ing)
        {
            if (CargarTabla(ing, "C#"))
            {
                AgregarAlArchivo(ing, "\\CSharp.txt");
                MessageBox.Show("Ingresante cargado exitosamente en C#.");
            }
            else
            {
                MessageBox.Show("Error al cargar ingresante, intente nuevamente.");
            }

        }
        public static void AggCMas(Ingresante ing)
        {
            if (CargarTabla(ing, "C++"))
            {
                AgregarAlArchivo(ing, "\\CMas.txt");
                MessageBox.Show("Ingresante cargado exitosamente en C++.");
            }
            else
            {
                MessageBox.Show("Error al cargar ingresante, intente nuevamente.");
            }
            
        }
        public static void AggJS(Ingresante ing)
        {
            if (CargarTabla(ing, "JavaScript"))
            {
                AgregarAlArchivo(ing, "\\JavaScript.txt");
                MessageBox.Show("Ingresante cargado exitosamente en JavaScript.");
            }
            else
            {
                MessageBox.Show("Error al cargar ingresante, intente nuevamente.");
            }
            
        }

        // Leemos archivos para validar que el Ingresante no sea duplicado, retorna como array de string
        public static string[] LeerArchivo(string directorio)
        {
            try
            {
                string[] lineas;

                lineas = File.ReadAllLines(directorio);
                return lineas;
            }
            catch (FileNotFoundException ex) // Excepcion en caso de que no se ecuentre
            {
                ExcepcionPersonalizada.Mensaje("No se encontró el archivo.");
                string[] vacio = { "" };
                return vacio;
            }
            catch (IOException ex) // Error al leer
            {
                ExcepcionPersonalizada.Mensaje("Error al leer el archivo.");
                string[] vacio = { "" };
                return vacio;
            }
        }

        // Validamos según CUIT y curso si el Ingresante ya fue cargado
        public static bool ValidarIngresante(Ingresante ing)
        {
            int bandera = 0; // Iniciamos una bandera

            string directorio = Directory.GetCurrentDirectory() + "\\CSharp.txt";
            if (File.Exists(directorio))
            {
                string[] lineas = LeerArchivo(directorio);
                foreach (string line in lineas)
                {
                    if (line.Contains(ing.Cuit.ToString()) && ing.CursosToString().Contains("C#"))
                    {
                        bandera++; // Si ya fue cargado, la bandera cambia
                    }
                }

            }

            directorio = Directory.GetCurrentDirectory() + "\\CMas.txt";
            if (File.Exists(directorio))
            {
                string[] lineas = LeerArchivo(directorio);
                foreach (string line in lineas)
                {
                    if (line.Contains(ing.Cuit.ToString()) && ing.CursosToString().Contains("C++"))
                    {
                        bandera++; // Si ya fue cargado, la bandera cambia
                    }
                }

            }

            directorio = Directory.GetCurrentDirectory() + "\\JavaScript.txt";
            if (File.Exists(directorio))
            {
                string[] lineas = LeerArchivo(directorio);
                foreach (string line in lineas)
                {
                    if (line.Contains(ing.Cuit.ToString()) && ing.CursosToString().Contains("JavaScript"))
                    {
                        bandera++; // Si ya fue cargado, la bandera cambia
                    }
                }

            }
            if (bandera == 0) // Si es 0 no se está duplicando en ningun curso
            {
                return true;
            }
            else { return false; }
        }

        public static bool CargarTabla(Ingresante ing, string curso)
        {
            string servidor = ConfigurationManager.AppSettings["servidor"];
            string nombreBase = ConfigurationManager.AppSettings["base"];
            string conexion = $"Data Source={servidor};Initial Catalog={nombreBase};Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    
                    string query = ($"INSERT INTO dbo.Ingresantes (Nombre,Direccion,Edad,CUIT,Genero,Pais,Cursos) VALUES(@nombre, @direccion, @edad, @cuit, @genero, @pais, @curso)");
                    SqlCommand command = new SqlCommand(query,con);
                    command.Parameters.AddWithValue("@nombre", ing.Nombre);
                    command.Parameters.AddWithValue("@direccion", ing.Direccion);
                    command.Parameters.AddWithValue("@edad", ing.Edad);
                    command.Parameters.AddWithValue("@cuit", ing.Cuit);
                    command.Parameters.AddWithValue("@genero", ing.Genero);
                    command.Parameters.AddWithValue("@pais", ing.Pais);
                    command.Parameters.AddWithValue("@curso", curso);

                    command.ExecuteNonQuery();
                    con.Close();
                    con.Dispose();
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error en la conexión. {ex.ToString()}");
                    return false;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
        }

    }
}

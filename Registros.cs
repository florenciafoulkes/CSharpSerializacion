using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TP_Promocion
{
    public partial class Registros : Form
    {
        //Constructor de la clase
        public Registros()
        {
            InitializeComponent();
        }

        // Evento que se dispara al crear un Nuevo Registro desde el Menú
        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoRegistro nuevoRegistro = new NuevoRegistro(); // Creamos el Form1 que contiene el registro

            nuevoRegistro.MdiParent = this; // El nuevo registro es hijo del actual

            nuevoRegistro.Show(); // Mostramos el nuevo registro
        }

        //Serialización XML
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string directorio = Directory.GetCurrentDirectory() + "\\CSharp.txt";
                if (File.Exists(directorio))
                {
                    using (StreamWriter sw = new StreamWriter("CSharp.xml"))
                    {
                        XmlSerializer xmlS = new XmlSerializer(typeof(Ingresante));
                        foreach (Ingresante ing in Cursos.CSharp)
                        {
                            xmlS.Serialize(sw, ing);
                        }
                        sw.Close();
                        sw.Dispose();
                    }
                    Cursos.MensajeSerializacion();
                }
                else { throw new FileNotFoundException(); }
            }
            catch (FileNotFoundException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al serializar, el archivo no existe.");
            }
            catch (IOException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al manejar el archivo.");
            }

        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string directorio = Directory.GetCurrentDirectory() + "\\CMas.txt";
                if (File.Exists(directorio))
                {
                    using (StreamWriter sw = new StreamWriter("CMas.xml"))
                    {
                        XmlSerializer xmlS = new XmlSerializer(typeof(Ingresante));
                        foreach (Ingresante ing in Cursos.CMas)
                        {
                            xmlS.Serialize(sw, ing);
                        }
                        sw.Close();
                        sw.Dispose();
                    }
                    Cursos.MensajeSerializacion();
                }
                else { throw new FileNotFoundException(); }
            }
            catch (FileNotFoundException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al serializar, el archivo no existe.");
            }
            catch (IOException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al manejar el archivo.");
            }
        }

        private void javaScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string directorio = Directory.GetCurrentDirectory() + "\\JavaScript.txt";
                if (File.Exists(directorio))
                {
                    using (StreamWriter sw = new StreamWriter("JavaScript.xml"))
                    {
                        XmlSerializer xmlS = new XmlSerializer(typeof(Ingresante));
                        foreach (Ingresante ing in Cursos.JavaScript)
                        {
                            xmlS.Serialize(sw, ing);
                        }
                        sw.Close();
                        sw.Dispose();
                    }
                    Cursos.MensajeSerializacion();
                }
                else { throw new FileNotFoundException(); }
            }
            catch (FileNotFoundException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al serializar, el archivo no existe.");
            }
            catch (IOException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al manejar el archivo.");
            }

        }

        //Serialización Json
        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                string directorio = Directory.GetCurrentDirectory() + "\\CSharp.txt";
                if (File.Exists(directorio))
                {
                    string jsonString = "";

                    JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                    jsonString = JsonSerializer.Serialize(Cursos.CSharp, options);

                    File.WriteAllText("CSharp.json", jsonString);
                    Cursos.MensajeSerializacion();

                }
                else { throw new FileNotFoundException(); }
            }
            catch (FileNotFoundException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al serializar, el archivo no existe.");
            }
            catch (IOException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al manejar el archivo.");
            }
            catch (JsonException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error en la serialización JSON");
            }

        }

        private void cToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                string directorio = Directory.GetCurrentDirectory() + "\\CMas.txt";
                if (File.Exists(directorio))
                {
                    string jsonString = "";

                    JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                    jsonString = JsonSerializer.Serialize(Cursos.CMas, options);

                    File.WriteAllText("CMas.json", jsonString);
                    Cursos.MensajeSerializacion();

                }
                else { throw new FileNotFoundException(); }
            }
            catch (FileNotFoundException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al serializar, el archivo no existe.");
            }
            catch (IOException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al manejar el archivo.");
            }
            catch (JsonException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error en la serialización JSON");
            }
        }

        private void javaScriptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string directorio = Directory.GetCurrentDirectory() + "\\JavaScript.txt";
                if (File.Exists(directorio))
                {
                    string jsonString = "";

                    JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
                    jsonString = JsonSerializer.Serialize(Cursos.JavaScript, options);

                    File.WriteAllText("JavaScript.json", jsonString);
                    Cursos.MensajeSerializacion();

                }
                else { throw new FileNotFoundException(); }
            }
            catch (FileNotFoundException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al serializar, el archivo no existe.");
            }
            catch (IOException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error al manejar el archivo.");
            }
            catch (JsonException ex)
            {
                ExcepcionPersonalizada.Mensaje("Error en la serialización JSON");
            }
        }
    }
}

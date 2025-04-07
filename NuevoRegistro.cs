using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Promocion
{
    public partial class NuevoRegistro : Form
    {
        public NuevoRegistro()
        {
            InitializeComponent();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            string direccion = "";
            string nombre = "";
            int edad = (int)numericUpDownEdad.Value; // Obtener el valor ingresado en NumericUpDown
            string cuit = maskedTextBoxCuit.Text.Trim(); // Obtener el CUIT de MaskedTextBox

            try
            {
                if (Funciones.ValidarCuit(cuit)) // Validamos el cuit
                {
                    string ingresar = "";

                    // Revisamos que todos los campos se hayan completado

                    if (textBoxNombre.Text == "")
                    {
                        ingresar += "- Nombre\n"; // Si está vacío se suma al string de errores
                    }
                    else
                    {
                        nombre = textBoxNombre.Text.Trim();
                    }

                    if (textBoxDireccion.Text == "")
                    {
                        ingresar += "- Dirección\n"; // Si está vacío se suma al string de errores
                    }
                    else
                    {
                        direccion = textBoxDireccion.Text.Trim();
                    }

                    if (edad < 18 || edad > 100) // Verificamos ya que pueden ingresarse valores por teclado
                    {
                        ingresar += "- Edad fuera de rango.";
                    }

                    string genero = "";
                    if (radioButtonFemenino.Checked) genero = radioButtonFemenino.Text.Trim();
                    if (radioButtonMasculino.Checked) genero = radioButtonMasculino.Text.Trim();
                    if (radioButtonNB.Checked) genero = radioButtonNB.Text.Trim();

                    string[] cursos = new string[3];
                    if (checkBoxCSharp.Checked)
                    {
                        cursos[0] = checkBoxCSharp.Text.Trim();
                    }
                    if (checkBoxCMas.Checked)
                    {
                        cursos[1] = checkBoxCMas.Text.Trim();
                    }
                    if (checkBoxJS.Checked)
                    {
                        cursos[2] = checkBoxJS.Text.Trim();
                    }
                    if (cursos[0] == null && cursos[1] == null && cursos[2] == null)
                    {
                        ingresar += "- Cursos\n";  // Si está vacío se suma al string de errores
                    }

                    string pais = "";
                    if (listBoxPais.SelectedItem == null)
                    {
                        ingresar += "- País\n";  // Si está vacío se suma al string de errores
                    }
                    else
                    {
                        pais = listBoxPais.Text.Trim();
                    }

                    //Creamos un Ingresante de prueba con estos datos para verificar que no sea duplicado
                    Ingresante prueba = new Ingresante(cursos, direccion, edad, genero, nombre, pais, cuit);
                    if (!Funciones.ValidarIngresante(prueba))
                    {
                        // Avisamos que el Ingresante ya fue cargado previamente
                        ingresar += "- El ingresante ya fue cargado en uno de los cursos solicitados.";
                    }

                    //Contamos la cantidad de Ingresantes en las listas para verificar la capacidad disponible
                    if (Cursos.ContarIngresantes() != "")
                    {
                        ingresar += "- Se alcanzó el límite de ingresantes en: " + Cursos.ContarIngresantes();
                    }

                    if (ingresar != "")  // Si hay errores, mostramos el mensaje y no guardamos.
                    {
                        MessageBox.Show("Falta ingresar: \n" + ingresar);

                    }
                    else // Si no hay errores, revisamos los datos
                    {
                        Ingresante ing = new Ingresante(cursos, direccion, edad, genero, nombre, pais, cuit);

                        if (Funciones.Consulta(this, "Datos ingresante: \n" + ing.Mostrar()))
                        {
                            //Cargamos el Ingresante a sus listas de Cursos y archivo.txt
                            if (checkBoxCSharp.Checked)
                            {
                                Funciones.AggCShar(ing);
                                Cursos.CSharp.Add(ing);
                            }
                            if (checkBoxCMas.Checked)
                            {
                                Funciones.AggCMas(ing);
                                Cursos.CMas.Add(ing);
                            }
                            if (checkBoxJS.Checked)
                            {
                                Funciones.AggJS(ing);
                                Cursos.JavaScript.Add(ing);
                            }

                            this.Vaciar(); // Limpiamos el formulario

                        }
                        else // Si los datos no eran correctos, revisar
                        {
                            MessageBox.Show("Revise los datos y vuelva a intentar.");
                        }
                    }

                }
                else // Si el CUIT es inválido lanza una Excepción personalizada
                {
                    throw new ExcepcionPersonalizada();
                }
            }
            catch (ExcepcionPersonalizada ex) // Manejo de la excepción
            {
                ExcepcionPersonalizada.Mensaje(ex.Message); // Mensaje de error
            }
        }

        //Funcion para vaciar el Form una vez que se agregó un nuevo Ingresante
        internal void Vaciar()
        {
            textBoxDireccion.Text = "";
            textBoxNombre.Text = "";
            numericUpDownEdad.Value = 18;
            maskedTextBoxCuit.Text = "";
            radioButtonFemenino.Checked = true;
            radioButtonMasculino.Checked = false;
            radioButtonNB.Checked = false;
            checkBoxCSharp.Checked = false;
            checkBoxCMas.Checked = false;
            checkBoxJS.Checked = false;
            listBoxPais.Text = "";
        }

        // Controlamos el ingreso de caracteres en el textBox Nombre
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == 08 || e.KeyChar == 32))
            {
                e.Handled = true;
            }

        }

        // Controlamos el ingreso de caracteres en el textBox Direccion
        private void textBoxDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 08 || e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }
    }
}

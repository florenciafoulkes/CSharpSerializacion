using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Promocion
{
    public class Ingresante
    {
        //Campos privados
        string nombre;
        string direccion;
        int edad;
        string cuit;
        string genero;
        string pais;
        string[] cursos;

        //Propiedades públicas
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Pais { get => pais; set => pais = value; }
        public string[] Cursos { get => cursos; set => cursos = value; }

        public Ingresante() { } // Creamos un constructor vacío para poder serializar y deserializar

        // Constructor completo
        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais, string cuit)
        {
            Cursos = cursos;
            Direccion = direccion;
            Edad = edad;
            Genero = genero;
            Nombre = nombre;
            Pais = pais;
            Cuit = cuit;
        }

        // Convertimos a String el Ingresante y cursos selccionados para mostrar en MessageBox de consulta
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Nombre}\n{Genero}\n{Direccion}\n{Cuit}\n{Pais}\nCursos seleccionados:\n" + CursosToString());
            return sb.ToString();

        }

        // Convierte el arreglo de cursos a una cadena de texto
        public string CursosToString()
        {
            string c = "";
            for (int i = 0; i < 3; i++)
            {
                if (Cursos[i] != null)
                {
                    c += Cursos[i] + " | ";
                }
            }
            return c;
        }

    }
}

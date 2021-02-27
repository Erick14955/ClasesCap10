using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesCap10.Ejercicio_2
{
    public class Estudiantes_escuela
    {
            private string nombre;
            private int edad;
            private string telefono;
            private string direccion;
            private double promedio;

            public int Edad
            {
                get
                {
                    return edad;
                }
                set
                {
                    if (value <= 0)
                        edad = 1;
                    else
                        edad = value;
                }
            }

            public double Promedio
            {
                get
                {
                    return promedio;
                }
                set
                {
                    if (value <= 0)
                        promedio = 1;
                    else
                        promedio = value;
                }
            }

            public Estudiantes_escuela(string Nombre, int Edad, string Telefono, string Direccion, double Promedio)
            {
                nombre = Nombre;
                edad = Edad;
                telefono = Telefono;
                direccion = Direccion;
                promedio = Promedio;
            }
    }
}

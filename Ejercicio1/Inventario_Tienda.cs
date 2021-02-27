using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesCap10.Ejercicio1
{
    class Inventario_Tienda
    {
        public class Inventario
        {
            private int codigo_producto;
            private string nombre_producto;
            private int precio;
            private int cantidad;
            public int Precio
            {
                get
                {
                    return precio;
                }
                set
                {
                    if (value <= 0)
                        precio = 1;
                    else
                        precio = value;
                }
            }

            public int Cantidad
            {
                get
                {
                    return cantidad;
                }
                set
                {
                    if (value <= 0)
                        cantidad = 1;
                    else
                        cantidad = value;
                }
            }

            public int Codigo_producto
            {
                get
                {
                    return codigo_producto;
                }
                set
                {
                    if (value <= 0)
                        codigo_producto = 1;
                    else
                        codigo_producto = value;
                }
            }

            public Inventario(int codigo, string nombre, int preci, int cant)
            {
                codigo_producto = codigo;
                nombre_producto = nombre;
                precio = preci;
                cantidad = cant;
            }
        }
    }
}

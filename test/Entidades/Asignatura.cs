using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Entidades
{
    internal class Asignatura
    {
        public string NombreAsignatura { get; set; }

        public Asignatura()
        {
            NombreAsignatura = string.Empty;


        }
        public Asignatura(string nombreAsignatura)
        {
            NombreAsignatura = nombreAsignatura;
        }
        public override string ToString()
        {
            return NombreAsignatura; 
        }
    }

}


/*
 *      public Producto()
        {
            ProductoNro = 0;
            Nombre = string.Empty;
            Precio = 0;
            Activo = true;
        }
        public Producto(int productoNro, string nombre, double precio)
        {
            ProductoNro = productoNro;
            Nombre = nombre;
            Precio = precio;
            Activo = true;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
*/

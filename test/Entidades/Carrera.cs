using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.Entidades
{
    internal class Carrera
    {
        public string Nombre { get; set; }

        public string Titulo { get; set; }

        public List<DetalleCarrera> Carreras { get; set; }

        public Carrera()
        {
            Carreras = new List<DetalleCarrera>();
        }
        public void AgregarCarrera(DetalleCarrera carrera)
        {
            Carreras.Add(carrera);

        }

        public void QuitarDetalle(int posicion) 
        {
            Carreras.RemoveAt(posicion); 
        
        
        
        }



    }
    
}

//     public List<DetallePresupuesto> Detalles { get; set; }
//public Presupuesto()
//{
 //   Detalles = new List<DetallePresupuesto>();
//}
//public void AgregarDetalle(DetallePresupuesto detalle)
//{
//    Detalles.Add(detalle);
//}
//public void QuitarDetalle(int posicion)
//{
//    Detalles.RemoveAt(posicion);
//}
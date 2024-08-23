using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._8.Clases
{
    internal class Atencion
    {
        public DateTime Fecha {  get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }

        public Atencion()
        {
        }

        public Atencion(DateTime fecha, string descripcion, double importe)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Importe = importe;
        }
        public override string ToString()
        {
            return $"Atención: Fecha:{Fecha}, Descripción: {Descripcion}, Importe: {Importe}";
        }
    }
}

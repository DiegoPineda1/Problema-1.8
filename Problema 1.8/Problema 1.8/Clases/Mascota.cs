using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problema_1._8.Clases.Enum;

namespace Problema_1._8.Clases
{
    internal class Mascota
    {
        public string Nombre {  get; set; }
        public int Edad { get; set; }
        public Tipo Tipo {  get; set; }
        public Atencion Atencion { get; set; }

        public Mascota()
        {
            Atencion = new Atencion();
        }

        public Mascota(string nombre, int edad, Tipo tipo)
        {
            Nombre = nombre;
            Edad = edad;
            Tipo = tipo;
            Atencion = new Atencion();
        }
        public override string ToString()
        {
            return $"Nombre Mascota: {Nombre}, Edad Mascota: {Edad}, Tipo: {Tipo}";
        }
    }
}

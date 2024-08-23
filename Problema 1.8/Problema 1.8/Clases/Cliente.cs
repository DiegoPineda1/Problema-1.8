using Problema_1._8.Clases.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._8.Clases
{
    internal class Cliente
    {
        public int Codigo { get; set; }
        public string Nombre {  get; set; }
        public Sexo Sexo {  get; set; }
        public Mascota Mascota { get; set; }

        public Cliente(int codigo, string nombre, Sexo sexo,string NombreAnimal,int EdadAnimal,Tipo tipoAnimal)
        {
            Codigo = codigo;
            Nombre = nombre;
            Sexo = sexo;
            Mascota = new Mascota(NombreAnimal,EdadAnimal,tipoAnimal);
        }
        public override string ToString()
        {

            return $"Codigo: {Codigo}, Nombre: {Nombre}, Sexo: {Sexo}, {Mascota.ToString()}";
        }
    }
}

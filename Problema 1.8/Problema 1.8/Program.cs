using Problema_1._8.Clases;
using Problema_1._8.Clases.Enum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿Desea Ser Cliente?");
        Console.WriteLine("Si:0 y No:1");
        int n1 = Convert.ToInt32(Console.ReadLine());

        if (n1 == 0)
        {
            Console.WriteLine("Escriba su DNI");
            int DNI = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su Nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Escriba su Sexo");
            Console.WriteLine("Masculino: 0, Femenino: 1, Otros: 2");
            Sexo sexo = (Sexo)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nombre de su mascota");
            string NombreMascota = Console.ReadLine();

            Console.WriteLine("Edad de su mascota");
            int edadMascota = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tipo de su mascota");
            Console.WriteLine("Perro: 1, Gato: 2, Araña: 3, Iguana: 4");
            Tipo tipo = (Tipo)Convert.ToInt32(Console.ReadLine());


            Console.Clear();
            Cliente cliente = new Cliente(DNI, nombre, sexo, NombreMascota, edadMascota, tipo);
            Console.WriteLine(cliente.ToString());


            Console.WriteLine("Espere Al Diagnóstico...");
            System.Threading.Thread.Sleep(10000);


            Console.WriteLine("Diagnóstico: Su mascota está en buenas condiciones.");

        }
        else
        {
            Console.WriteLine("Muchas Gracias");
        }
    }
}








        
       
using Problema_1._8.Clases;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente = new Cliente(1,"Diego Pineda",Problema_1._8.Clases.Enum.Sexo.Masculino,"Polo",12,Tipo.Perro);
        cliente.Mascota.Atencion = new Atencion(new DateTime(2024, 8, 24), "Cortar el pelo", 2455);
        Console.WriteLine(cliente.ToString());


    }
}
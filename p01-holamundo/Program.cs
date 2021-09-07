using System;

namespace p01_holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fecha= DateTime.Now;
            Console.WriteLine("Hola mundo\n");
            Console.WriteLine("Dame tu nombre?");
            nombre=Console.ReadLine();
            Console.WriteLine($"{nombre} Bienvenido a C#\n");
            Console.WriteLine($"Hoy es {fecha :d} y son las {fecha:t}");
            Console.WriteLine("Hasta pronto");
        }
    }
}

using System;

namespace p2_areacirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            float radio=0;
            double area=0;
            Console.WriteLine("Calculando el area de un circulo");
            Console.WriteLine("Dame el radio?");
            radio=float.Parse(Console.ReadLine());
            area=Math.PI * Math.Pow(radio,2);
            Console.WriteLine($"El area del circulo es {area}");
        }
    }
}

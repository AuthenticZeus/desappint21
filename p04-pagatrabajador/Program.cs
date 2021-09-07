﻿using System;

namespace p04_pagatrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, salida;
            int horas;
            float pago, pagobruto, impuesto, pagoneto;
            const float TASA=0.3f;

            Console.WriteLine("Calculando la paga de un trabajador\n");
            Console.Write("Dame tu nombre:      "); nombre= Console.ReadLine();
            Console.Write("Horas de trabajadas: "); horas=int.Parse(Console.ReadLine());
            Console.Write("Pago por hora:       "); pago=float.Parse(Console.ReadLine());

            pagobruto= horas*pago;
            impuesto= pagobruto *TASA;
            pagoneto= pagobruto-impuesto;

            salida=$"El trabajador {nombre}, trabajo {horas} horas, con un pago de {pago}\n" + $"Pago bruto: {pagobruto}\nImpuesto: {impuesto}\nPago neto: {pagoneto}";
            Console.WriteLine(salida);
        }
    }
}

using System;

namespace p12_vectorinvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM =16;
            int [] A= new int [TAM];
            int [] A= new int [TAM];

            for( int i=0;i<A.Length;i++){
                A[i]= rnd.Next(1,100);
                B[15-i]=A[i];
            }
            Console.WriteLine("\nElementos de A: \n"); imprime(A);
            Console.WriteLine("\nElementos de B: \n"); imprime(B);   


        }
         static void imprime(int[] v){
            for(int i=0;i<v.Length;i++){
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
         }
    }
}

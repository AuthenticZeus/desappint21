using System;

namespace p08_vectorpromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector=  {10, 20 , 30 ,40 ,50, 60, 70, 80, 90, 100,
                            10, 20 , 30 ,40 ,50, 60, 70, 80, 90, 100,
                            10, 20 , 30 ,40 ,50, 60, 70, 80, 90, 100,
                            10, 20 , 30 ,40 ,50, 60, 70, 80, 90, 100,
                            10, 20 , 30 ,40 ,50, 60, 70, 80, 90, 100};
            int suma,nmp;
            float promedio=0.0f;
            suma=nmp=0;
            for( int i=0; i< vector.Lenght;i++){
                Console.Write(4"{vector [i]}");
                suma = suma + vector [i];
            }
            promedio = suma/vector.Lenght;
            Console.WriteLine($"\nLa suma es {suma} y el promedio es {promedio}\n");

            for(int i=0; i<vector.Lenght;i++){
                if(vector[i]>promedio){
                    Console.Write($"{vector[i]");
                    nmp= nmp + 1;
                }
                

            }
        }
    }
}

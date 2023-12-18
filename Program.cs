using System.Runtime.Intrinsics.X86;

namespace edu.PR.Ejercicio3._1312
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[,] numero = new int[10, 10];


            int valor = 100;


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    numero[i, j] = valor;
                    valor--;
                }
            }


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(numero[i, j] + " ");
                }
                Console.WriteLine();
            }


            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }






        }



    }
}

using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite um numero para fazer a tabuada: ");
                int Numero = int.Parse(Console.ReadLine());

                for (int i = 1; i < 11; i++)
                {
                    int Resultado = Numero * i;
                    Console.WriteLine(Numero + " X " + i + " = " + Resultado);
                }
            }catch(Exception Error)
            {
                Console.Write("Detalhe: " + Error);
            }
        }
    }
}

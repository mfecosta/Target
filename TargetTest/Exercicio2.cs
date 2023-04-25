using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetTest
{
    class Exercicio2
    {

        public void PertenceFibonacci()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            bool encontrado = false;
            int a = 0, b = 1, c = 0;

            Console.WriteLine("Sequência de Fibonacci:");

            for (int i = 0; i < 20; i++) // calcula os primeiros 20 termos
            {
                if (i <= 1)
                {
                    c = i;
                }
                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }

                Console.Write("{0} ", c);

                if (c == numero) // verifica se o número foi encontrado
                {
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("\nO número {0} pertence à sequência de Fibonacci.", numero);
            }
            else
            {
                Console.WriteLine("\nO número {0} não pertence à sequência de Fibonacci.", numero);
            }


        }

        
    }
}



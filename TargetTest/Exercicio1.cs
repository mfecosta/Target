using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetTest
{
    class Exercicio1
    {
        public int ValorSoma()
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;

            }
            Console.WriteLine("O valor da variável SOMA é: " + soma);
            return soma;



        }
    }
}

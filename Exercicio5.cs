using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetTest
{
    class Exercicio5
    {
        public void InverterString()
        {
            Console.Write("Qual a frase a ser invertida: ");
            string texto = Console.ReadLine();

            // Convertendo a string em um array de caracteres
            char[] caracteres = texto.ToCharArray();

            // Invertendo a ordem
            for (int i = 0; i < caracteres.Length / 2; i++)
            {
                char temp = caracteres[i];
                caracteres[i] = caracteres[caracteres.Length - 1 - i];
                caracteres[caracteres.Length - 1 - i] = temp;
            }

            // Convertendo o array de caracteres de volta para uma string
            string textoInvertido = new string(caracteres);

            
            Console.WriteLine("String invertida: " + textoInvertido);
        }
    }
}

using System;

namespace TargetTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1 exercicio1 = new Exercicio1();
            Exercicio2 exercicio2 = new Exercicio2();
            Exercicio3 exercicio3 = new Exercicio3();
            Exercicio4 exercicio4 = new Exercicio4();
            Exercicio5 exercicio5 = new Exercicio5();
            
            

            Console.WriteLine("Qual exercício você irá executar ?");
            Console.WriteLine("Exercício - 1\n Exercício - 2\n Exercício - 3\n Exercício - 4\n Exercício - 5");
            int exercicio = int.Parse(Console.ReadLine());
            
            switch (exercicio)
            {
                
                case 1: exercicio1.ValorSoma();
                    break;
                case 2: exercicio2.PertenceFibonacci();
                    break;
                case 3: exercicio3.CalcularFaturamento();                  ;
                    break;
                case 4:
                    exercicio4.FaturamentoPercentual(); ;
                    break;
                case 5:
                    exercicio5.InverterString(); ;
                    break;
                default: Console.WriteLine("Escolha um valor na lista");
                    break;
            }
            
            
        }
    }
}

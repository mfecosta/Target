using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetTest
{
    class Exercicio4
    {
        public void FaturamentoPercentual()
        {
            // Definindo o valor total mensal da distribuidora
            double valorTotal = 180762.98;

            
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            // Fazendo o caculo do percentual de cada estado
            double percSp = (sp / valorTotal) * 100;
            double percRj = (rj / valorTotal) * 100;
            double percMg = (mg / valorTotal) * 100;
            double percEs = (es / valorTotal) * 100;
            double percOutros = (outros / valorTotal) * 100;

            
            Console.WriteLine("Percentual de representação por estado:");
            Console.WriteLine("SP: " + percSp.ToString("F2") + "%");
            Console.WriteLine("RJ: " + percRj.ToString("F2") + "%");
            Console.WriteLine("MG: " + percMg.ToString("F2") + "%");
            Console.WriteLine("ES: " + percEs.ToString("F2") + "%");
            Console.WriteLine("Outros: " + percOutros.ToString("F2") + "%");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TargetTest
{
    class Exercicio3
    {
        public void CalcularFaturamento()
        {
                XmlDocument xmlDocument = new XmlDocument();
                // Lê o arquivo XML
                xmlDocument.GetElementsByTagName(@"C:\Users\Marcelo\source\repos\TargetTest\TargetTest\Dados\dados");

                int[] faturamento = new int[31]; // Array que irá armazenar o faturamento diário do mês
                int somaFaturamento = 0; // Variável que irá armazenar a soma de todo o faturamento do mês
                int diasUteis = 0; // Variável que irá armazenar o número de dias úteis do mês

                // Fazendo loop para coletar o faturamento diário do mês e contar os dias úteis
                XmlNodeList nodes = xmlDocument.DocumentElement.SelectNodes("/valor/dia");
                foreach (XmlNode node in nodes)
                {
                    int dia = int.Parse(node.Attributes["numero"].Value);
                    int valor = int.Parse(node.InnerText);
                    if (valor > 0)
                    { // Se o valor for maior que 0, considera como um dia útil
                        faturamento[dia - 1] = valor;
                        diasUteis++;
                    }
                    somaFaturamento += valor;
                }

                // Cálculo da média mensal de faturamento considerando apenas os dias úteis
                double mediaFaturamento = (double)somaFaturamento / diasUteis;

                // Cálculo do menor e maior faturamento diário do mês
                int menorFaturamento = int.MaxValue;
                int maiorFaturamento = int.MinValue;
                for (int i = 0; i < 31; i++)
                {
                    if (faturamento[i] == 0)
                    { // Ignora os dias sem faturamento
                        continue;
                    }
                    if (faturamento[i] < menorFaturamento)
                    {
                        menorFaturamento = faturamento[i];
                    }
                    if (faturamento[i] > maiorFaturamento)
                    {
                        maiorFaturamento = faturamento[i];
                    }
                }

                // Cálculo do número de dias em que o faturamento diário foi superior à média mensal
                int diasAcimaDaMedia = 0;
                for (int i = 0; i < 31; i++)
                {
                    if (faturamento[i] > mediaFaturamento)
                    {
                        diasAcimaDaMedia++;
                    }
                }

                
                Console.WriteLine("Menor faturamento diário do mês: " + menorFaturamento);
                Console.WriteLine("Maior faturamento diário do mês: " + maiorFaturamento);
                Console.WriteLine("Número de dias com faturamento diário acima da média mensal: " + diasAcimaDaMedia);
            }
        }

    }



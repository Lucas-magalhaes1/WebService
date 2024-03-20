using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.CalculatorService;

namespace WebService
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CalculatorSoapClient client = new CalculatorSoapClient();

            int soma = client.Add(10, 5);
            Console.WriteLine("Soma: " + soma);

            int subtracao = client.Subtract(10, 5);
            Console.WriteLine("Subtração: " + subtracao);

            int multiplicacao = client.Multiply(10, 5);
            Console.WriteLine("Multiplicação: " + multiplicacao);

            int divisao = client.Divide(10, 5);
            Console.WriteLine("Divisão: " + divisao);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATVD
{
    public class exer2
    {
        public void Convercao()
        {
            Console.WriteLine("digite a cotação do dolar");
            double cotacao = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que vc tem pra cotação");
            double valor = double.Parse(Console.ReadLine());

            double convercao = cotacao * valor;
            Console.WriteLine(convercao);
        }
    }
}

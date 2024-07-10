using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATVD
{
    public class Exer6
    {
        public int Operacao { get; set; }
        public int num1 { get; set; }
        public int num2 { get; set; }
        public double resultado { get; set; }


        public void EscolheOperacao()
        {
            Console.WriteLine("Diga a operação a ser feita.\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
            Operacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga o numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga o numero 2");
            num2 = int.Parse(Console.ReadLine());



            if (Operacao == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine(resultado);
            }
            else if (Operacao == 2)
            {
                resultado = num1 - num2;
                Console.WriteLine(resultado);
            }
            else if (Operacao == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine(resultado);
            }
            else if (Operacao == 4)
            {
                resultado = num1 / num2;
                Console.WriteLine(resultado);
            }






        }

    }
}

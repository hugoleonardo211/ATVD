using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATVD
{
    public class Exer7
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int acao { get; set; }

        public void RealizarAcao()
        {
            Console.WriteLine("Escolha o primeiro numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo numero");
            num2 = int.Parse(Console.ReadLine());
            MostrarMenu();
            if (acao == 1)
            {
                VerificarMultiplo();
                RealizarAcao();
            }
            else if (acao == 2)
            {
                VerificarPar();
                RealizarAcao();
            }
            else if (acao == 3)
            {
                VerificarMedia();
                RealizarAcao();
            }
        }


        public void MostrarMenu()
        {
            Console.WriteLine("Menu\n1 - Verificar se um dos numeros lidos é ou não múltiplo do outro\n2");
            Console.WriteLine("- Verificar se os dois números lidos são pares\n3");
            Console.WriteLine("- Verificar se a média dos dois números é maior ou igual a 7\n4");
            Console.WriteLine("Sair");
            acao = int.Parse(Console.ReadLine());
        }

        public void VerificarMultiplo()
        {
            if (num1 >= num2)
            {
                if (num1 % num2 == 0)
                {
                    Console.WriteLine("Os numeros são multiplos");
                }
                else
                {
                    Console.WriteLine("Os numeros não são multiplos");
                }
            }
            else
            {
                if (num2 % num1 == 0)
                {
                    Console.WriteLine("Os numeros são multiplos");
                }
                else
                {
                    Console.WriteLine("Os numeros não são multiplos");
                }
            }
        }

        public void VerificarPar()
        {
            if (num1 % 2 == 0 && num2 % 2 == 0)
            {
                Console.WriteLine("Os dois numeros são pares");
            }
            else
            {
                Console.WriteLine("Os dois numeros não são pares");
            }
        }

        public void VerificarMedia()
        {
            if (num1 + num2 / 2 >= 7)
            {
                Console.WriteLine("A medida é maior que 7");
            }
            else
            {
                Console.WriteLine("A media não é maior que 7");
            }
        }
    }
}

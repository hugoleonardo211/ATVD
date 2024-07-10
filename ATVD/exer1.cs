using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATVD
{
    public class exer1
    {
        public int EstoqueMedio { get; set; }
        public void CalcularEstoque(int quantidade_min, int quantidade_max)
        {

            EstoqueMedio = (quantidade_min + quantidade_max) / 2;
            Console.WriteLine(EstoqueMedio);

        }
    }
}

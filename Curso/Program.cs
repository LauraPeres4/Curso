using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o total da anuidade do curso: ");
            double total = double.Parse(Console.ReadLine());
            double parcela = total / 12;

            Console.WriteLine("Informe o valor da matrícula: ");
            double mat = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor dos materiais: ");
            double matl = double.Parse(Console.ReadLine());

            int cont = 1;

            
            

            while (cont <= 12)
            {
                if (cont == 1)
                    Console.WriteLine("Mensalidade: " + cont + " Valor: " + (parcela + mat + matl).ToString("C"));
                else
                    Console.WriteLine("Mensalidade: " + cont + " Valor: " + (parcela));
                cont++;
            }

            Console.ReadKey();

        }
    }
}

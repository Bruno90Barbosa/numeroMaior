using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroMaior
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".......QUAL NÚMERO É O MAIOR?.......");
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("....................................");
            Console.WriteLine();


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("...................................................................");
                Console.WriteLine("O número " + num1 + " é maior que os números " + num2 + " e " + num3);
                Console.WriteLine("...................................................................");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("...................................................................");
                Console.WriteLine("O número " + num2 + " é maior que os números " + num1 + " e " + num3);
                Console.WriteLine("...................................................................");
            }
            else
            {
                Console.WriteLine("...................................................................");
                Console.WriteLine("O número " + num3 + " é maior que os números " + num1 + " e " + num2);
                Console.WriteLine("...................................................................");
            }

            Console.ReadLine();

        }
    }
}

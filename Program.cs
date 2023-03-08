using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1_PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exec 1
            int metro,cm,mm;
            Console.WriteLine("Digite o Número de metros");
            metro=int.Parse(Console.ReadLine());
            cm=metro*100;
            mm=metro* 1000;
            Console.WriteLine("A quantidade em cm é "+cm);
            Console.WriteLine("A quantidade em mm é "+mm);
            Console.ReadKey();
        }
    }
}

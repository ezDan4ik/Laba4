using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Laba4GIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {

                Console.WriteLine("Сюсюкало Д. - 1");
                Console.WriteLine("Дяченко М. - 2");
                Console.WriteLine("Мачульський А. - 3");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        ezdan4ik ezdan4ik = new ezdan4ik();
                        ezdan4ik.Main();
                        break;
                    case 2:
                        dito dito = new dito();
                        dito.Main();
                        break;
                    case 3:
                        holly holly = new holly();
                        holly.Main();
                        break;
                }
            } while (choice != 0);
        }
    }
}

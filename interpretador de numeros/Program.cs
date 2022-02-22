/* formato:

   __  __        __   __  __   __   __
|  __| __| |__| |__  |__    | |__| |__|
| |__  __|    |  __| |__|   | |__|  __|

*/

using System;

namespace interpretador_de_numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] NumerosEntrada = new string[]
            {
                " __\n|__ \n __|" ,//5
                " __\n|__ \n|__|" ,//6
                " __\n   |\n   |" ,//7
                " __\n|__|\n|__|" ,//8
                " __\n|__|\n __|",//9
                " \n | \n |" , //1
                " __ \n __| \n|__" ,//2
                " __\n __| \n __|" ,//3
                " \n|__| \n   |" ,//4

                 " __\n __| \n __|" ,//3
                 " \n|__| \n   |" ,//4
                 " __\n   |\n   |" ,//7
                 " __\n|__|\n|__|" ,//8
                 " \n | \n |" , //1
                 " __ \n __| \n|__" ,//2
                 " __\n|__ \n __|" ,//5
                 " __\n|__ \n|__|" ,//6
                 " __\n|__|\n __|",//9

                " __\n __| \n __|" ,//3
                " __ \n __| \n|__" ,//2
                " __\n|__ \n __|" ,//5
                " __\n|__ \n|__|" ,//6
                " __\n|__|\n __|",//9
                " \n|__| \n   |" ,//4
                " __\n   |\n   |" ,//7
                " __\n|__|\n|__|" ,//8
                " \n | \n |" , //1
              
                " __\n|__|\n|__|",//0
                " __ \n __| \n|__" ,//2
                " __\n|__ \n __|" ,//5
                " __\n|__ \n|__|" ,//6
                " __\n   |\n   |" ,//7
                " __\n|__|\n|__|" ,//8
                " \n | \n |" , //1
                " __\n|__|\n __|",//9
                " \n|__| \n   |" ,//4
            };

            foreach (var item in NumerosEntrada)
            {
                if (item == " __\n|__|\n|__|")
                {
                    Console.WriteLine("0");
                }

                if (item == " \n | \n |")
                {
                    Console.WriteLine("1");
                }

                if (item == " __ \n __| \n|__")
                {
                    Console.WriteLine("2");
                }

                if (item == " __\n __| \n __|")
                {
                    Console.WriteLine("3");
                }

                if (item == " \n|__| \n   |")
                {
                    Console.WriteLine("4");
                }

                if (item == " __\n|__ \n __|")
                {
                    Console.WriteLine("5");
                }

                if (item == " __\n|__ \n|__|")
                {
                    Console.WriteLine("6");
                }

                if (item == " __\n   |\n   |")
                {
                    Console.WriteLine("7");
                }

                if (item == " __\n|__|\n|__|")
                {
                    Console.WriteLine("8");
                }

                if (item == " __\n|__|\n __|")
                {
                    Console.WriteLine("9");
                }

            }



            


        }
    }
}

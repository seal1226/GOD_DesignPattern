using Bridge.Task;
using System;

namespace Bridge
{
    class Program
    {
        private static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImpl("Hellow, Japan"));
            Display d2 = new Display(new StringDisplayImpl("Hello, World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, しーるちゃん"));

            d1.Disp();
            d2.Disp();
            d3.Disp();
            d3.MultiDisp(5);

            Console.WriteLine("課題");


            RandomDisplay d4 = new RandomDisplay(new StringDisplayImpl("何回出力されるかな？"));
            d4.RandomDisp(5);

            Display d5 = new Display(new FileDisplayImpl("./README.md"));
            d5.Disp();

            IncreaseDisplay d6 = new IncreaseDisplay(new CharDisplayImpl('-', '#', '-'));
            d6.IncreaseDisp(6);
        }
    }
}

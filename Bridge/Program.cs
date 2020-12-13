namespace Bridge
{
    class Program
    {
        private static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplay("Hellow, Japan"));
            Display d2 = new Display(new StringDisplay("Hello, World."));
            CountDisplay d3 = new CountDisplay(new StringDisplay("Hello, しーるちゃん"));

            d1.Disp();
            d2.Disp();
            d3.Disp();
            d3.MultiDisplay(5);
        }
    }
}

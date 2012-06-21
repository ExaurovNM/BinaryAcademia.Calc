using BinaryAcademia.Calc;

namespace Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new System.Random();
            double a = random.Next(1, 100);
            double b = random.Next(1, 100);
            var consoleOutput = new ConsoleOutput();
            var driveOutput = new DriveOutput();
            var calc = new Calc();

            consoleOutput.Out(a,b,calc.Add(a,b),'+');
            consoleOutput.Out(a, b, calc.Difference(a, b), '-');
            consoleOutput.Out(a, b, calc.Multiplication(a, b), '*');
            consoleOutput.Out(a, b, calc.Division(a, b), '/');
            System.Console.ReadKey();
        }
    }
}

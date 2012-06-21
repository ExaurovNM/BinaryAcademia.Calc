using System;

namespace BinaryAcademia.Calc
{
    public interface IOutput
    {
        void Out(double a, double b, double resault, char sign);
    }

    public class ConsoleOutput: IOutput
    {
        public void Out(double a, double b, double result, char sign)
        {
            string str;
            if (System.Double.IsNaN(result))
                str ="division by zero";
            else
                str = a.ToString() + sign.ToString() + b.ToString() + "=" + result.ToString();
            Console.WriteLine(str);
        }
    }

    public class DriveOutput : IOutput
    {
        public void Out(double a, double b, double result, char sign)
        {
            string str;
            if (System.Double.IsNaN(result))
                str = "division by zero";
            else
                str = a.ToString() + sign.ToString() + b.ToString() + "=" + result.ToString()+'\n';
            System.IO.File.WriteAllText("WriteText.txt", str);
        }
    }
}

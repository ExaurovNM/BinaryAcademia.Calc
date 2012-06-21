namespace BinaryAcademia.Calc
{
    public class Calc
    {

        public double Add(double a, double b)
        {
            return a+b;
        }
        public double Multiplication(double a, double b)
        {
            return a*b;
        }
        public double Difference(double a, double b)
        {
            return a - b;
        }
        public double Division(double a, double b)
        {
            if (b < 1e-10 && b > -1e-10) 
                return System.Double.NaN;
            return a/b;
        }
    }
} ;

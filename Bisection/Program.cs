using System;
namespace Bisection
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double intervalBegin;
            double intervalEnd;
            double middle;
            double precision;
            double power;
           // double constant;
            double a;
            double b;
            double c;
            double d;
            double e;

            Console.Write("Enter begining of interval: ");
            intervalBegin = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter end of interval: ");
            intervalEnd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter precision of method: ");
            precision = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The power of the equation: ");
            power = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Coefficient values of a: of ax^4+bx^3+cx^2+dx+e: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Coefficient values of b: of ax^4+bx^3+cx^2+dx+e: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Coefficient values of c: of ax^4+bx^3+cx^2+dx+e: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Coefficient values of d: of ax^4+bx^3+cx^2+dx+e: ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of the constant");
            e = Convert.ToDouble(Console.ReadLine());

            if (Function(intervalBegin,power,a,b,c,d,e) * Function(intervalEnd,power,a,b,c,d,e) > 0.0D)
            {
                Console.Write("Function has same signs at ends of interval");
                return;
            }
           
            while (Math.Abs(intervalBegin - intervalEnd) > precision)
            {
                middle = (intervalBegin + intervalEnd) / 2.0D;
                Console.WriteLine("X: " + middle);
                if (Function(intervalBegin,power,a,b,c,d,e) * Function(middle,power,a,b,c,d,e) < 0.0D)
                {
                    intervalEnd = middle;
                }
                else
                {
                    intervalBegin = middle;
                }
            }
            Console.ReadKey(); 
        }
        static double Function(double x,double Power, double A,double B,double C, double D, double E)
        {
            if (Power == 4)
            {
                return A * (x * x * x * x) + B * (x * x * x) + C * (x * x) + D * (x) + E;
            }
            else if (Power == 3)
            {
                return B * (x * x * x) + C * (x * x) + D * (x) + E;
            }
            else if (Power == 2)
            {
                return C * (x * x) + D * (x) + E;
            }

            else if (Power == 2)
            {
                return C * (x * x) + D * (x) + E;
            }
            else 
            {
                return D * (x) + E;
            }
          
            
        }
    }
}
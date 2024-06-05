using NUnitDemonstration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemonstration
{
    public static class Triangle
    {
        public static string ValidTriangle(int firstAngle, int secondAngle, int
        thirdAngle)
        {
            string result;
            if ((firstAngle + secondAngle + thirdAngle) == 180)
            {
                result = "The triangle is valid.";
            }
            else
            {
                result = "The triangle is NOT valid.";
            }
            return result;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        int firstAngle = 60;
        int secondAngle = 60;
        int thirdAngle = 60;
        string result = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
        Console.WriteLine(result);
    }
}

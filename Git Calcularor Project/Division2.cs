using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Calcularor_Project
{
    internal class Division2
    {
        public double Divide1(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return double.NaN; // Return Not-a-Number to indicate an error
            }
            return num1 / num2;
        }
    }
}

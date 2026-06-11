using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Calcularor_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Addition addition = new Addition();  
           double A =  addition .Add(5, 10);
            Console.WriteLine("The result of addition is: " + A);

            Substraction substraction = new Substraction(); 
             double B =   substraction .Subtract(10, 5);
            Console.WriteLine("The result of substraction is: " + B);

            division division = new division(); 
             double C =  division .Divide(10, 5);
            Console.WriteLine("The result of division is: " + C);
        }
    } 
}

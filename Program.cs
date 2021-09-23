using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_converting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of celsius: ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
            int Kelvin = Convert.ToInt32(Console.ReadLine());
            int Fahrenheit = Convert.ToInt32(Console.ReadLine());
    
        }
    }
}

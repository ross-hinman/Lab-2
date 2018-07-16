using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {

        static void Main(string[] args)
        {
            double length;
            double width;
            double height;
            string answer = "y";


            while (answer == "y")
            { 
                Console.WriteLine("Enter Length: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Width: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Height: ");
                height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Area: " + length * width);
                Console.WriteLine("Perimeter: " + (length + width)*2);
                Console.WriteLine("Volume: " + length * width * height);
                Console.WriteLine("Continue? (y/n)");
                answer = (Console.ReadLine());
                answer = answer.ToLower();
            }
        }
       

        }  
    }


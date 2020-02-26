using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMonteiroAssignment2
{
    class Program
    {
        /// <summary>
        /// program that lets the user enter three integers and determines if they make a triangle and what type of 
        /// triangle they make
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Welcome To Triangle Solver!");
                Console.WriteLine();
                Console.WriteLine("1. Enter Triangle Dimensions:");
                Console.WriteLine("2. Exit:");
                string userChoice = Console.ReadLine();
                
                if(userChoice.Trim() == "1")
                {
                    EnterDimensions();
                }
                else if(userChoice.Trim() == "2")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input: press any key to restart");
                    Console.ReadKey();
                }
                Console.Clear();

            }
        }

        /// <summary>
        /// asks user for 3 integers and uses analyze method to find out if they make a triangle
        /// </summary>
        private static void EnterDimensions()
        {
            
                    Console.WriteLine("Please Enter Three Sides of a Triangle");
                    Console.WriteLine();
                    if(int.TryParse(Console.ReadLine(), out int side1))
                    {
                        if (int.TryParse(Console.ReadLine(), out int side2))
                        {
                            if (int.TryParse(Console.ReadLine(), out int side3))
                            {
                                Console.WriteLine(TriangleSolver.Analyze(side1, side2, side3));
                                Console.WriteLine("Press any key to restart");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("Invalid input: must enter an integer:");
                                Console.WriteLine("Press any key to restart");
                                Console.ReadKey();
                    }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input: must enter an integer:");
                            Console.WriteLine("Press any key to restart");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input: must enter an integer:");
                        Console.WriteLine("Press any key to restart");
                        Console.ReadKey();
                    }        
                
        }
    }
}

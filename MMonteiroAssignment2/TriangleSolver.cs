using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMonteiroAssignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            string response = "Input values do not make a triangle";
            //check if three sides make triangle at all
            if(side1 < 1 || side2 < 1 || side3 < 1)
            {
                response = "all sides must be greater than 0";
            }
            else if(side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                if(side1 == side2 && side2 == side3 && side1 == side3)
                {
                    response = "This is a valid equalateral triangle";
                }
                else if(side1 != side2 && side2 != side3 && side1 != side3)
                {
                    response = "This is a valid scalene triangle";
                }
                else
                {
                    response = "This is a valid isoceles triangle";
                }
            }

            return response;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_5
{
    // Class: IGME 201.01
    // Author: Judy Derrick
    // Purpose: PE8 Q5 - More About Variables
    // Restrictions: None
    static internal class Program
    {
        // Method: Main
        // Purpose: given a formula, write a console application to calculate z
        //          with following ranges for x and y
        // Restrictions: None
        static void Main(string[] args)
        {
            //double[,,] array;
            double z;
            double x = -1;
            double y = 1;

            while (x <= 1 && y <= 4)
            {
                z = 3.0*Math.Pow(y, 2) + 2*x - 1;
                // Console.WriteLine("x: " + x + ", y: " + y + ", z: " + z);

                // add {x, y, z} to array

                x += 0.1;
                y += 0.1;
            }

        }
    }
}

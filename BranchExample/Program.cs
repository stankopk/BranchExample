﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchExample
{
    internal class Program
    {

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int GreaterNumber(int a, int b)
        {
            if(a > b)
            {
                return a;
            }
            else
            {
                return b;
            }   
        }

        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            Console.Write(a + b);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fizzbuzz.Main
{
    public class Extension
    {
        public string[] fizzbuzz(int lower, int higher)
        {
            //TODO: Extension: Implement a function that will create a list of strings containing the numbers from the lower number to the higher number
            /* 
                Where a number is a multiple of three (3, 6, 9, etc) the array should contain the string "Fizz" instead of a number.
                Where a number is a multiple of five (5, 10, etc) the array should contain the string "Buzz" instead of a number.
                Where a number is a multiple of both five AND three (15, 30, etc) the array should contain the string "Fizzbuzz" instead of a number.
            * */

            List<string> nums = new List<string>();
            for (int i = lower; i <= higher; i++)
            {
                string output = "";

                if (i % 3 == 0) output = "Fizz";
                if (i % 5 == 0) output = "Buzz";
                if (i % 15 == 0) output = "Fizzbuzz";

                if (output == "") output += $"{i}";
                nums.Add(output);
            }


            return nums.ToArray();
        }
    }
}

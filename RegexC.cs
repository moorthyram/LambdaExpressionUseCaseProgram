﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LambdaExpressionUseCaseProgram
{
    public class RegexC
    {
        public static void RegexPattern()
        {
            String FirstName;

            Regex nameregex = new Regex("^([A-Z]{1}[a-z]{2}([a-z]+)?)$");


            Console.WriteLine("Enter the First Name");
            var name = Console.ReadLine();
            Match matchfirstname = nameregex.Match(name);
            if (matchfirstname.Success)
            {
                FirstName = name;
                Console.WriteLine("Its valid name");
            }

            else
            {
                Console.WriteLine("Its Invalid name, Enter first letter capital and enter small letters");
            }
        }
    }
}

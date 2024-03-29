﻿using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Calculator
{
    public class Menu :UserMethod
    {
       public void Selection()
        {
            Calculation calculation = new Calculation();
            int input = 0;

            while (true)
            {
                Console.WriteLine("Welcome to the Calculator!");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. List of all Calculations");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.WriteLine("Choose an option");
                
                input=Convert.ToInt32(Console.ReadLine());
                
                switch (input)
                {
                    case 1:
                        (double num1, double num2) = UsersInput();                        
                        Addition(num1, num2);                         
                        break;
                    case 2:
                        (num1, num2) = UsersInput();
                        Subtraction(num1, num2);
                        break; 
                    case 3:
                        (num1, num2) = UsersInput();
                        Multiplication(num1, num2);
                        break;
                    case 4:
                        (num1, num2) = UsersInput();
                        if (num2 == 0)
                        {
                            Console.WriteLine("Division by 0 not possible");
                        }
                        else
                        {
                            Division(num1, num2);
                        }
                        break;
                    case 5:
                        PrintAllCalculations();
                        break; 
                    case 6:
                        break;



              


                }
            }
        }
    }
}

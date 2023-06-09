using Calculator.Data;
using Calculator.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculation : DatabaseMethod
    {

        public double Addition(double num1,double num2)
        {
            string method = "+";
            double result= num1 + num2;
            SaveCalculations(num1, num2, method, result);
            return result;
        }
        public double Subtraction (double num1,double num2)
        {
            string method = "-";
            double result= num1 - num2;
            SaveCalculations (num1, num2, method, result);
            return result;
        }
        public double Multiplication (double num1,double num2)
        {
            string method = "*";
            double result= num1 * num2;
            SaveCalculations(num1, num2, method, result);
            return result;
        }
        public double Division (double num1,double num2)
        {
            string method = "/";
            double result= num1 / num2;
            SaveCalculations(num1, num2, method, result);   
            return result;
        }
    }
}

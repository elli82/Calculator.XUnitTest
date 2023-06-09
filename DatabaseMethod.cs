using Calculator.Data;
using Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class DatabaseMethod
    {
        
            public void SaveCalculations(double num1, double num2, string method, double result)     //metod för att spara uträkningar i databasen
            {
                Context dbContext = new Context();  // skapar ett objekt av databasen
                Result calculation = new Result()   // skapar ett objekt av resultaten
                {
                    Nr1 = num1,
                    Nr2 = num2,
                    Method = method,
                    Results = result
                };
                dbContext.Add(calculation);     //lägger till i db
                dbContext.SaveChanges();        //sparar i db
            }
    }
}

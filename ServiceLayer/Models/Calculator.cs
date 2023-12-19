using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Models
{
    public class Calculator
    {
        public double  GetCalculation(string mode,double num1,double num2)
        { 
            double result=default(double);
            switch (mode)
            {
                    case "+":
                    result=num1+num2;
                    break;
                    case "-":
                    result=num1-num2;
                    break;
                     case "*":
                    result=num1*num2;
                    break;
                    case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error,cannot divide to 0");
                    }
                    else
                    {
                        result = num2 / num1;
                    }
                    
                    break;
                    case "%":
                    result=num1%num2;
                    break;

                    default:
                    Console.WriteLine("Erorr");
                    break;
            }
            return result;
         }
        public void  FinalCalculation()
        {
            Calculator calculator = new ();
            Console.WriteLine("Enter the mode");
            string mode=Console.ReadLine();
            Console.WriteLine("Enter the first num");
            double num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second num");
            double num2=int.Parse(Console.ReadLine());
            double result=calculator.GetCalculation(mode,num1,num2);
            Console.WriteLine($"The result is {result}");
        }
    }
}

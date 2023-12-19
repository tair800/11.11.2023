

namespace ServiceLayer.Models
{
    public class Factorial
    {
        public  static long  CalculateFactorial(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Number must be non negative");
            }
            if(number == 0)
            {
                return 1;
            }
            return number * CalculateFactorial(number - 1);
        }
        public void GetFactorial()
        {
            int number = 5;
            long factorial = CalculateFactorial(number);
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }
    }
}

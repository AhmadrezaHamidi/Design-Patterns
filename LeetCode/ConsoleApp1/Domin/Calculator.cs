using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Domin
{
    public static class Calculator
    {
        public static int SumTOArrayes(int[] numbers, int[] number2)
        {
            try
            {
                if (numbers.Length != number2.Length)
                    throw new ArgumentException();

                var numberOne = Convert.ToInt32(string.Join(null, numbers.Select(number => number.ToString())));
                var numberTwo = Convert.ToInt32(string.Join(null, numbers.Select(number => number.ToString())));

                return numberOne + numberTwo;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          
        }
    }
}

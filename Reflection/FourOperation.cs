using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class FourOperation
    {
        private int _number1;
        private int _number2;

        public FourOperation(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;

        }

        public int plus(int number1, int number2)
        {
            return number1 + number2;
        }

        public int subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public int divide(int number1, int number2)
        {
            return number1 / number2;
        }

        //******************************************
        //********** With Referance Types **********

        public int plus2(int sayi1, int sayi2)
        {
            return _number1 + _number2;
        }

        public int substract2(int sayi1, int sayi2)
        {
            return _number1 - _number2;
        }

        public int multiply2(int sayi1, int sayi2)
        {
            return _number1 * _number2;
        }

        public int divide2(int sayi1, int sayi2)
        {
            return _number1 / _number2;
        }
    }
}

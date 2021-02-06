using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //dortIslem.Topla2();
            //dortIslem.Topla(2, 3);

            var type = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem) Activator.CreateInstance(type,6,7);
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2(6,7));

            var instance = Activator.CreateInstance(type, 6, 7);

            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null));

            //MethodInfo methodInfo = instance.GetType().GetMethod("plus2");

            //Console.WriteLine(methodInfo.Invoke(instance,null));

            var methods = type.GetMethods();
            Console.WriteLine("------------------");
            foreach (var info in methods)
            {
                Console.WriteLine("Method name : {0}",info.Name);
                foreach (var parameter in info.GetParameters())
                {
                    Console.WriteLine("Parameter Name : {0}",parameter.Name);
                }
                Console.WriteLine("-----------------------");
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}",attribute.GetType().Name);
                }
            }

            Console.ReadLine();


        }
    }

    public class DortIslem
    {
        private int _number1;
        private int _number2;
        
        public DortIslem(int number1, int number2)
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

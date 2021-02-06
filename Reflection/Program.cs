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
            //FourOperation fourOperation = new FourOperation(2, 3);
            //fourOperation.plus2();
            //fourOperation.plus(2, 3);

            var type = typeof(FourOperation);

            //FourOperation fourOperation = (FourOperation) Activator.CreateInstance(type,6,7);
            //Console.WriteLine(fourOperation.plus(4, 5));
            //Console.WriteLine(fourOperation.plus2(6,7));

            var instance = Activator.CreateInstance(type, 6, 7);

            //Console.WriteLine(instance.GetType().GetMethod("plus2").Invoke(instance,null));

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

    
}

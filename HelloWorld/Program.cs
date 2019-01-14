using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Byte Min and Max");
            Console.WriteLine("{0},{1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Int Min and Max");
            Console.WriteLine("{0}, {1}",int.MinValue,int.MaxValue);
            Console.WriteLine("Float Min and Max");
            Console.WriteLine("{0}, {1}",float.MinValue,float.MaxValue);
            Console.WriteLine("Double Min and Max");
            Console.WriteLine("{0}, {1}",double.MinValue,double.MaxValue);
        }
    }
}

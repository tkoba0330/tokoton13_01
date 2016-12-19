using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodai
{
    class X {  internal static void SayMyName() { Console.WriteLine("I am Kodai."); } }
}

namespace Shima
{
    class X {  internal static void SayMyName() { Console.WriteLine("I am Shima."); } }
}



namespace tokoton13_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Kodai.X.SayMyName();
            Shima.X.SayMyName();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CSharp_console
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Input a calculation method like 1+2^(3-4)*5/10=↙\nPlease:");
            string myInput = Console.ReadLine();
            Calc myTest = new Calc();
            char[] ch1 = myInput.ToCharArray(0, myInput.Length);
            ch1.CopyTo(myTest.calc, 0);
            //Console.WriteLine(myTest.calc.Length);
            Console.WriteLine("The result is \n{0}",myTest.fun1());
            Console.ReadKey();

            //char[] ch = { '1', '.', '2' };
            ////   string[] s = ch.ToString(); ;
            //System.Text.StringBuilder sb = new System.Text.StringBuilder();
            //sb.Append(ch);
            //string s = sb.ToString();
            //double a = Convert.ToDouble(s);
            //Console.WriteLine(a);

            //JumpOutWhile();
            //Console.ReadKey();
        }

        //private static void JumpOutWhile()
        //{
        //    int i = 0;
        //    while (true)
        //    {
        //        i++;

        //        if (i % 9 == 0)
        //        {
        //            continue;
        //        }

        //        if (i == 50)
        //        {
        //            break;
        //        }

        //        if (i == 100)
        //        {
        //            //跳出while所在的方法
        //            //但是前面在i=50时，已经跳出while循环 => 不会执行该句
        //            return;
        //        }

        //        Console.WriteLine(i);
        //    }
        //}
    }
}

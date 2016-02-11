using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_console
{
    public class Calc
    {
        public char[] calc=new char[64];
        public int n = 0;
        double t = 0;
          
        public double fun1()
        {
            t = fun2();
            while ((calc[n] == '+') || (calc[n] == '-'))
            {
                switch (calc[n])
                {
                    case '+': n++; t += fun2(); break;
                    case '-': n++; t -= fun2(); break;
                }
            }
            return t;
        }

        private double fun2()
        {
            t = fun3();
            while ((calc[n] == '*') || (calc[n] == '/'))
            {
                switch (calc[n])
                {
                    case '*': n++; t *= fun3(); break;
                    case '/': n++; t /= fun3(); break;
                }
            }
            return t;
        }

        private double fun3()
        {
            t = fun4();
            while (calc[n] == '^')
            {
                n++; t = Math.Pow(t, fun4());
            }
            return t;
        }

        private double fun4()
        {
            char[] num = new char[16];
            int i = 0;
            if (calc[n] == '(')
            {
                n++; t = fun1(); n++;
            }
            else if (fun5())
            {
                while (fun5())
                {
                    num[i++] = calc[n++];
                }
                num[i] = '\0';
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append(num);
                string s = sb.ToString();
                t = Convert.ToDouble(s);     //将num转换成t
            }
            return t;
        }

        private bool fun5()
        {
            //if (n == 0)
            //{
            //    if (((calc[n] >= '0' && calc[n] <= '9') || (calc[n] == '.')))
            //        return true; //是与数字相关的，如数字字符、小数点、正负号，返回1
            //}
            //else
            //{
            //    if ((calc[n] == '.')||(n > 0 && (calc[n - 1] == '+' || calc[n - 1] == '-' || calc[n - 1] == '*' || calc[n - 1] == '/' || calc[n - 1] == '^' || calc[n - 1] == '(')))
            //        return true;
            //}
            //return false;
            if (((calc[n] >= '0' && calc[n] <= '9') || (calc[n] == '.')) || (n > 0 && (calc[n - 1] == '+' || calc[n - 1] == '-' || calc[n - 1] == '*' || calc[n - 1] == '/' || calc[n - 1] == '^' || calc[n - 1] == '(')))
                return true; //是与数字相关的，如数字字符、小数点、正负号，返回1
            else
                return false; //加、减、乘、除、乘方时，返回0
        }
    }
}

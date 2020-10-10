using System;

namespace Computer
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            Console.WriteLine("请输入要进行运算的数");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入要进行运算的运算符");
            char c = Char.Parse(Console.ReadLine());
            bool e;
             e= calculate.Equals(a, b);
            if (e == true)
            {
                Console.WriteLine("a与b相等");
            }
            else
                Console.WriteLine("a与b不相等");
            double result = 0;
            if (c == '+')
            {
               result=calculate.Add(a, b);              
                Console.WriteLine("result=" + result);
            }
            else if (c == '-')
            {
               result=calculate.Differ(a, b);
                Console.WriteLine("result=" + result);
            }
            else if (c == '*')
            {
                result = calculate.Ride(a, b);
                Console.WriteLine("result=" + result);
            }
            else if (c == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("除数不能为0");
                    return;
                }
                result = calculate.Divide(a, b);
                Console.WriteLine("result=" + result);
            }
            else
            {
                Console.WriteLine("输入字符无法识别，请输入'+','-','*','/'字符");
            }

        }
    }
    class Calculate
    {
       public bool Equals(double a,double b)
        {
            if (a == b)
                return true;
            else
                return false;
        }
      public  double Add(double a,double b)
        {
            
            return a + b;
        }
  
        public double Differ(double a, double b)
        {
            return a - b;
        }
        public double Ride(double a, double b)
        {
            return a*b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}

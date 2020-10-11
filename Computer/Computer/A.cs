using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    //数字运算类
    class A:Calculate
    {
        public double Add(double a, double b)
        {

            return a + b;
        }
        public double Differ(double a, double b)
        {
            return a - b;
        }
        public double Ride(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }
        public double Quyu(double a,double b)
        {
            return a % b;
        }
        public int Yu(int a,int b)
        {
            return a&b;
        }
    }
}

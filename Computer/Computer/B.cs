using System;
using System.Collections.Generic;
using System.Text;

namespace Computer
{
    //字符运算类
    class B:Calculate
    {
        public string Add(string a, string b)
        {
            return a + b;
        }
        public string Differ(string a, string b)
        {
            int num = 0;
            string str = string.Empty;
            string[] s = new string[a.Length];
            string[] m = new string[b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                s[i] = a.Substring(i, 1);
            }
            for (int i = 0; i < b.Length; i++)
            {
                m[i] = b.Substring(i, 1);
            }
            for (int i = 0; i < a.Length; i++)
            {
                num = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (s[i] == m[j])
                    {
                        num++;
                    }
                }
                if (num == 0)
                {
                    str += s[i];
                }
            }
            return str;
        }
    }
}

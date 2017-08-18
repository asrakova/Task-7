using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Math.Pow(2, n - 1).ToString()) + 1;
            string[] code = new string[k];
            for (int i = 0; i < n; i++)
                code[0] += '0';
            code[1] = "1";
            for (int i = 1; i < n; i++)
                code[1] += '0';

            int[] t = new int[n + 1];
            t[1] = 1;
            for (int i = 2; i < k; i++)
            {
                t[n] = t[n] + 1;
                for (int j = n; j > 0; j--)
                {
                    if (t[j] == 2)
                    {
                        t[j - 1] = t[j - 1] + 1;
                        t[j] = 0;
                    }
                    code[i] = t[j].ToString() + code[i];
                }
            }

            for (int i = 0; i < k; i++)
                Console.WriteLine(code[i]);
            Console.ReadLine();
        }
    }
}

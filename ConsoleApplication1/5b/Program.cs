using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5b
{
    class Program
    {
        static void Main(string[] args)
        {
            Checkpalindrome();
            Console.WriteLine();
            MaxAndMin();
            Console.WriteLine();
            UpLow();
            Console.WriteLine("\n");
            DrawX();
        }

        static bool Checkpalindrome()
        {
            Console.WriteLine("Input string here: ");
            string s = Console.ReadLine();
            int n = s.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (s[i] != s[n - i - 1])
                {
                    Console.WriteLine("false");
                    return false;
                }
            }
            Console.WriteLine("true");
            return true; 
        }

        static char MaxAndMin()
        {
            Console.WriteLine("Input nums here: ");
            string x = Console.ReadLine();
            int n = x.Length;
            char max = x[0];
            char min = x[0];
            
            for (int i = 1; i < n; i++)
            {
                if (max < x[i])
                    max = x[i];
                if (min > x[i])
                    min = x[i];
            }
            Console.WriteLine("Max is: " + max);
            Console.WriteLine("Min is: " + min);
            return max;
            return min;
        }

        static void UpLow()
        {
            Console.WriteLine("Change string here: ");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++ )
            {
                int e = s[i];
                if (s[i] >= 65 && s[i] <= 90)
                {
                    e = e + 32;
                    Console.Write((char)e + "\t" );
                }

                else if (s[i] >= 97 && s[i] <= 122)
                {
                    e = e - 32;
                    Console.Write((char)e + "\t");
                }

                else
                {
                    Console.WriteLine("You typed string wrong");
                }
            }   
        }

        static void HLine(int H, char c)
        {
            for (int i = 0; i < H; i++)
            {
                Console.Write(c);
            }
        }

        static void DrawX()
        {
            Console.WriteLine("Input height: ");
            int H = Convert.ToInt32(Console.ReadLine());
            int b;
            if (H % 2 == 1)
            {
                b = H - 2;
            }
            else
            {
                b = H - 1;
            }
            int a = 0;
            for (int i = 0; i < H / 2; i++)
            {
                HLine(a, ' '); HLine(1, 'x'); HLine(b, ' '); HLine(1, 'x'); Console.WriteLine();
                a++;
                b = b - 2;
            }
            int c = H / 2 - 1;
            int d = 1;
            for (int i = 0; i < H / 2; i++)
            {
                HLine(c, ' '); HLine(1, 'x'); HLine(d, ' '); HLine(1, 'x'); Console.WriteLine();
                c--;
                d = d + 2;
            }
        }
    }
}

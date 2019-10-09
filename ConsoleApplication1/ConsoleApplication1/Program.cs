using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Print_a_2_z_v1();
            Console.WriteLine("\n");
            Print_a_2_z_v2();
            Console.WriteLine("\n");
            Print_z_2_a_v1();
            Console.WriteLine("\n");
            Print_z_2_a_v2();
            Console.WriteLine("\n");
            Print_A_2_Z();
            Console.WriteLine("\n");
            Console.WriteLine("input charater here: ");
            char i = Convert.ToChar(Console.ReadLine());
            Console.Write((int)i);
            Console.WriteLine("\n");
            CheckUpOrLow();
            Console.WriteLine("\n");
            ChangeUpOrLow();
        }

        static void Print_a_2_z_v1()
        {
            for (char i = 'a'; i <= 'z';  i++)
            {
                Console.Write(i + "\t");
            }
        }

        static void Print_a_2_z_v2()
        {
            for (short i = 97; i <= 122; i++)
            {
                Console.Write((char)i + "\t");
            }
        }

        static void Print_a_2_z_v3()
        {
            string s = "abcdefghịklmnopqrstuvwxyz";
            for (int i = 0; i <= s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }

        static void Print_a_2_z_v4()
        {
            char c = 'a';
            do
            {
                Console.WriteLine(c);
                c++;
            } while (c <= 'z');
        }

        static void Print_z_2_a_v1()
        {
            for (short i = 122; i>=97; i--)
            {
                Console.Write((char)i + "\t");
            }
        }

        static void Print_z_2_a_v2()
        {
            for (char i = 'z'; i >= 'a'; i--)
            {
                Console.Write(i + "\t");
            }
        }

        static void Print_A_2_Z()
        {
            for (short i = 65; i<=90; i++)
            {
                Console.Write((char)i + "\t");
            }
        }

        static void CheckUpOrLow()
        {
            Console.WriteLine("check char here: ");
            char c = Convert.ToChar(Console.ReadLine());
            if ((int)c >= 65 && (int)c <= 90)
                Console.WriteLine("this char is upper case !");
            else if ((int)c >= 97 && (int)c <= 122)
                Console.WriteLine("this char is lower case !");
            else
                Console.WriteLine("You typed char wrong");
        }

        static void ChangeUpOrLow()
        {
            Console.WriteLine("change char here: ");
            char c = Convert.ToChar(Console.ReadLine());
            if ((int)c >= 65 && (int)c <= 90)
            {
                int e = Convert.ToInt32(c);
                e = e + 32;
                Console.WriteLine((char)e);
            }
                
            else if ((int)c >= 97 && (int)c <= 122) 
            {
                int e = Convert.ToInt32(c);
                e = e - 32;
                Console.WriteLine((char)e);
            }

            else
            {
                Console.WriteLine("You typed char wrong");
            }
                
        }
    }
}

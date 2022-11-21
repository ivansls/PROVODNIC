using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROVODNIC_2._0._1
{
    internal class Class1
    {
        public static string put = "C:\\";
        public static string dop_put = "C:\\";
        public static List<string> dop_list = new List<string>();
        public static List<string> list = new List<string>();
        public static List<int> num = new List<int>();
        public static int coun = -1;
        public static void show()
        {
            //List<string> list = new List<string>();
            int columns = 0;
            str ppp = new str();
            Class1 cllass = new Class1();
            int windows = 0;
            List<string> i = new List<string>();
            //int windows = 0;
            string[] Drives = Directory.GetDirectories(Class1.put);  //Environment.GetLogicalDrives();
            string[] Failel = Directory.GetFiles(Class1.put);
            /*foreach (string file in Drives)
            {
                Console.WriteLine("  " + file);
                list.Add(file);
                num.Add(columns++);
            }*/

            foreach (string n in Drives)
            {
                i.Add(n);
            } 
            foreach (string j in Failel)
            {
                i.Add(j);
            }

            foreach (string file in i)
            {
                Console.WriteLine("  " + file);
                list.Add(file);
                num.Add(columns++);
            }

            /*foreach (string file1 in list)
            {
                //var indexOfIntegerValue = list.IndexOf(file1);
                Console.WriteLine("  " + file1);
            }*/
            /*if (key.Key == ConsoleKey.Enter)
            {
                cllass.put = "D:\\";
            }
*/
            /*else if (windows == 1 & ppp.posicion == indexOfIntegerValue & key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                //if (ppp.posicion == indexOfIntegerValue & key.Key == ConsoleKey.Enter)

                Console.WriteLine("asd");

            }*//*
        }*/
            //Console.WriteLine("  " + list + "\n");

        }
    }


    public class str
    {
        bool isListenning = true;
        public int posicion = 1;
        Class1 cllass = new Class1();
        void Cursor(ConsoleKeyInfo key)
        {
            //int posicion = 1;
            if (key.Key == ConsoleKey.UpArrow & posicion != 0)
            {
                posicion--;

            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                posicion++;
            }
            else if (key.Key == ConsoleKey.Enter)
            {
                int index = Class1.list[posicion].IndexOf(".") + 1;
                string piece = Class1.list[posicion].Substring(index);
                //var indexOfIntegerValue = Class1.list.IndexOf(Class1.list[posicion]);
                //Console.Clear();
                if (piece == Class1.list[posicion])
                {
                    Class1.put = Class1.list[posicion];
                    Class1.dop_list.Add(Class1.put);
                }
                else if (piece != "")
                {
                    Process.Start(new ProcessStartInfo { FileName = Class1.list[posicion], UseShellExecute = true });

                }
                //Console.WriteLine(Class1.list[posicion]);
                /*else if (piece != "")
                {
                    Process.Start(new ProcessStartInfo { FileName = Class1.put, UseShellExecute = true });
                }*/
                Class1.list.Clear();
            }
            else if (key.Key == ConsoleKey.F1)
            {
                Class1.put = Class1.dop_put;
                Class1.list.Clear();
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                isListenning = false;
            }
            int c = 0;
            void Clear()
            {
                foreach (var item in Class1.num)
                {
                    Console.SetCursorPosition(0, c);
                    Console.WriteLine("                                                                                     ");
                    c++;
                }
            }

            //Clear();
            Console.Clear();
        }

        public void star()
        {
            Class1.show();
            while (isListenning == true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Cursor(key);
                Class1.show();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine();
                Console.SetCursorPosition(0, posicion);
                Console.WriteLine("->");
            }
        }
    }
}

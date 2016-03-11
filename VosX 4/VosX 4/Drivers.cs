using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOSX
{
    static class Drivers
    {
        public static class System
        {


        }

        public static class Interface
        {
            public static void WriteLine(string str, string color = "white")
            {
                color = color.ToLower();
                if (color == "white")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (color == "green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (color == "yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (color == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine(str);
                Console.ForegroundColor = ConsoleColor.White;
            }


            public static void Write(string str, string color = "white")
            {
                color = color.ToLower();
                if (color == "white")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (color == "green")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (color == "yellow")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (color == "red")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write(str);
                Console.ForegroundColor = ConsoleColor.White;
            }

            public static void Clear()
            {
                Console.Clear();
            }

        }

        public class FileSystem
        {


        }

    }
}

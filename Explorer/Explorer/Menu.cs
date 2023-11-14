using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer
{
    internal class Menu
    {

        public static void Name(string path)
        {
            //Console.SetCursorPosition(50, 0);
            Console.WriteLine($"{path} \n________________________________________________________________________________________________________________________");
        }

        public static int MenuStr(int pos, int min, int max)
        {
            
            ConsoleKeyInfo key;

            Console.SetCursorPosition(0, min);
            Console.Write("->");

            do
            {
                Console.SetCursorPosition(0, pos);
                key = Console.ReadKey();
                Console.WriteLine("  ");
                if (key.Key == ConsoleKey.UpArrow)
                {
                    pos--;
                    if (pos < min)
                    {
                        pos = max;
                    }

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos++;
                    if (pos > max)
                    {
                        pos = min;
                    }

                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    return -1;
                }
                Console.SetCursorPosition(0, pos);
                Console.Write("->");
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}

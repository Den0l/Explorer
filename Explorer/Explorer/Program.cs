using System;
using System.Diagnostics;
using Explorer;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

namespace Explorer
{
    internal class Program
    {
        static void Main() 
        {
            int MinValue = 2;
            int MaxValue = 5;
            int pos = 2;
            string path = "";
            string path1 = "";
           

            do
            {
                Console.Clear();
                Menu.Name(path);
                MaxValue = Exp.ShowDisk(MaxValue)+1;
                pos = Menu.MenuStr(pos, MinValue, MaxValue);
                path = Exp.ChoiceDisk(pos, path);
                Console.Clear();
                do
                {
                    Console.Clear();
                    Menu.Name(path);
                    Exp.ExploreDrive(pos, path);
                    MaxValue = Exp.Max(MaxValue) + 1;
                    pos = Menu.MenuStr(pos, MinValue, MaxValue);
                    if (pos == -1)
                    {
                        path = "";
                        pos = 2;
                        MinValue = 2;
                        MaxValue = 5;
                        break;
                    }

                    if (System.IO.Directory.Exists(path))
                    {
                        path1 = path;
                        path = Exp.NewPath(path, pos);
                    }
                    if (System.IO.File.Exists(path))
                    {
                        Exp.OpenFile(path);
                        path = path1;
                        continue;
                    }
                   
                    Console.Clear();
                } while (true);
            }while (true);
        }
    }
}

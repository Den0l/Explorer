using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorer
{
    internal class Exp
    {
        static public DriveInfo[] Disk = DriveInfo.GetDrives();
        
        static public List<string> disk = new List<string>();
        static private FileInfo File;
        static private int i = 2;
        static public string[] files;
        public static int ShowDisk(int max)
        {
            foreach (var d in Disk)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine($"  {d.Name} {d.TotalFreeSpace / (1024*1024*1024)} GB свободно из {d.TotalSize / (1024 * 1024 * 1024)} GB");
                i++;
                disk.Add(d.Name);
            }
            i = 2;
            return max = Disk.Length;

        }

        public  static string ChoiceDisk(int pos, string path)
        {
            return path = disk[pos-2];
        }

        public static void ExploreDrive(int pos, string path)
        {
           
            File = new FileInfo(path);
            files = Directory.GetFileSystemEntries(path); 
            int i = 2;

            foreach (string file in files)
            {
                Console.SetCursorPosition(2, i);
                Console.WriteLine(Path.GetFileName(file));
                Console.SetCursorPosition(50, i);
                Console.WriteLine(Directory.GetCreationTime(file));
                i++;
            }



        }


        static public void OpenFile(string path)
        {
                Process.Start(new ProcessStartInfo{FileName = path, UseShellExecute = true});
        }

        static public string NewPath(string path, int pos)
        {
            if(System.IO.Directory.Exists(path))
            {
            return path = files[pos - 2];   
            }
            return path;
        }

        static public int Max(int MaxValue)
        {
            return MaxValue = files.Length;
        }

    }
}

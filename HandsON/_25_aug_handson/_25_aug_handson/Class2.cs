using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_aug_handson
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\INDIA\source\repos\C-Sharp-Handson\HandsON\_25_aug_Handson";
            Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();

            //File.Create(fname);
            //Console.WriteLine("file created successfully...");
            //Console.WriteLine("Enter your file contents");
            //string con = Console.ReadLine();
            //string[] contents = new string[2];
            //contents[0] = con;
            //File.WriteAllLines(fname, contents);
            //Console.WriteLine("file created successfully with contents...");

            File.Copy(fname, "copiedFile.txt");
            //string newpath = @"C:\Users\INDIA\source\repos\C-Sharp-Handson\HandsON\";
            //File.Copy(newpath,"DiffCopy.txt");
            //Console.WriteLine("Copied file succesfully");
            File.Move(fname, "MovedFile.txt");
            //Console.WriteLine(" Moved File Succesfully");
            //File.Delete(fname);

            FileInfo fileInfo = new FileInfo(fname);
            Console.WriteLine("--------------");
            Console.WriteLine(fileInfo.FullName + "  Full Name");
            Console.WriteLine("--------------");
            Console.WriteLine(fileInfo.Extension + " Extension");
            Console.WriteLine("--------------");
            Console.WriteLine(fileInfo.DirectoryName + " DirectoryName");
            Console.WriteLine("--------------");
            Console.WriteLine(fileInfo.CreationTime);



        }
    }
}

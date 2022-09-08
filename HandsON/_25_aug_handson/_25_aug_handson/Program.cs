using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_aug_handson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                do
                {

                    Console.WriteLine("1.Create\n 2.Append\n 3.Truncate\n");
                    int x = Convert.ToInt32(Console.ReadLine());
                    string path = "C:\\Users\\INDIA\\source\\repos\\C-Sharp-Handson\\HandsON\\_25_aug_Handson";
                    Console.WriteLine("Enter the file name");
                    string fname = Console.ReadLine();


                    fname = string.Concat(path, fname);
                    Console.WriteLine("--------------------------------");
                    // file creation path
                    switch (x)
                    {
                        case 1:



                            FileStream f = new FileStream(fname, FileMode.Create);
                            StreamWriter s = new StreamWriter(f);

                            s.WriteLine("hello c#");
                            s.Close();
                            f.Close();
                            Console.WriteLine("File created successfully...");
                            break;    //create

                        case 2:
                            Console.WriteLine("-----------------");

                            FileStream fs = new FileStream(fname, FileMode.Append);
                            StreamWriter ss = new StreamWriter(fs);

                            ss.WriteLine("hi Beautiful");
                            ss.Close();
                            fs.Close();
                            Console.WriteLine(" append  successfully...");
                            break;//append
                        case 3:
                            Console.WriteLine("-----------------------");
                            FileStream fs1 = new FileStream(fname, FileMode.Truncate);
                            StreamWriter ss1 = new StreamWriter(fs1);


                            ss1.Close();
                            fs1.Close();
                            Console.WriteLine(" truncate  successfully...");
                            break;//truncate



                    }
                } while (true);

            }
        }
    }
}

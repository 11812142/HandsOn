using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReusableLibrary1
{
    public class Class6
    {
        public static void MakeFile()
        {
            //verbatim =@"path";
            string path = @"C:\\Users\\INDIA\\source\\repos\\HandsON\\_24_aug_handson\\first.File.txt";
            File.Create(path);
        }
    }
}

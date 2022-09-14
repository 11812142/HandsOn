using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace GitProject
{
    class Program
    {
        static void Main(string[] args)
        {
 
            string data = File.ReadAllText("F:\\Mphasis\\Git\\Git Project\\EmpData.txt");
            Console.WriteLine(data);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public delegate void StringLengthDelegate();
    public delegate string GreetDelegate(string s);
    public delegate string StringConcatenateDelegate (string str1, string str2);
    public delegate string FirstCapitalDelegate(string s2);
    public class Length
    {
        public void StringLength()
        {
            string name = "Magician";
            int lengthofname = name.Length;

            Console.WriteLine("The name of string : " + name + "\n" + "Length of string name : " + lengthofname);
            Console.ReadKey();

        }
        public string User(string s)
        {
            Console.WriteLine( "Hello" + s);
            return s;
        }
        public string Concatenate(string str1,string str2)
        {
            
            Console.WriteLine("1st String : " + str1 + "\n" + "2nd String: " + str2);
            Console.WriteLine("Concatenation of 2 String: " + str1+" "+str2);
            return str1 + str2;
        }

        public string FirstCapital(string s2)
        {
            Console.WriteLine("String before Uppercase: " +s2);
            if(s2.Length == 0)
                Console.WriteLine("Empty String");
            else if(s2.Length == 1)
                Console.WriteLine("1st letter of String is Capital Now: " + char.ToUpper(s2[0]));
            else
                Console.WriteLine("1st letter of String is Capital Now: " + char.ToUpper(s2[0]) + s2.Substring(1));
            return s2;
        }



    }
}

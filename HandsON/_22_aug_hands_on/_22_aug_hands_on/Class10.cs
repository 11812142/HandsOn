using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_aug_hands_on
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            //Create a dictionary having key as integer type and value as string type
            Dictionary<int, string> dictCity = new Dictionary<int, string>();

            //Add items to the dictionary using Add method
            dictCity.Add(1, "India");
            dictCity.Add(2, "USA");
            dictCity.Add(3, "UK");
            dictCity.Add(4, "Russia");
            dictCity.Add(5, "Germany");

            foreach (KeyValuePair<int, string> dictItem in dictCity)
            {
                Console.WriteLine("Key : {0} , Value, {1}", dictItem.Key, dictItem.Value);//Prints dictionary items
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_aug_hands_on
{
    internal class Class15
    {
        //m-1
        public static void printFirstRepeating(int[] arr)
        {
            int min = -1;

            // Creates an empty hashset
            HashSet<int> set = new HashSet<int>();

            // Traverse the input array from right to left
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                // If element is already in hash set, update min
                if (set.Contains(arr[i]))
                {
                    min = i;
                }

                else // Else add element to hash set
                {
                    set.Add(arr[i]);
                }

            }

            // Print the result
            if (min != -1)
            {
                Console.WriteLine("The first repeating element is " + arr[min]);
            }
            else
            {
                Console.WriteLine("There are no repeating elements");
            }
            Console.ReadLine();

        }


        // Driver method to test above method

        public static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 5, 3, 4, 3, 5, 6 };
            printFirstRepeating(arr);

        }



    }
}


//m-2
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DriverCode
//{

//    class GFG
//    {
//        static void Main(string[] args)
//        {
//            int testcases; // Taking testcase as input
//            testcases = Convert.ToInt32(Console.ReadLine());
//            while (testcases-- > 0) // Looping through all testcases
//            {

//                int n = Convert.ToInt32(Console.ReadLine());
//                var ip = Console.ReadLine().Trim().Split(' ');
//                int[] arr = new int[n];
//                for (int i = 0; i < n; i++)
//                {
//                    arr[i] = int.Parse(ip[i]);
//                }
//                Solution obj = new Solution();
//                var res = obj.firstRepeated(arr, n);
//                Console.WriteLine(res);
//            }
//        }
//    }
//}


//// } Driver Code Ends


//// User function Template for C#

//class Solution
//{
//    // Function to return the position of the first repeating element.
//    public
//      int firstRepeated(int[] arr, int n)
//    {
//        // Your code here
//        {
//            var map = new Dictionary<int, int>();
//            var set = new SortedSet<int>();
//            for (int i = 0; i < n; i++)
//            {
//                if (!map.ContainsKey(arr[i]))
//                {
//                    map[arr[i]] = i + 1;
//                }
//                else
//                {
//                    set.Add(map[arr[i]]);
//                }
//            }
//            foreach (int i in set)
//            {
//                return i;
//            }
//            return -1;
//        }

//    }
//}





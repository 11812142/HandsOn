using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private int categoryid;
        public int ID
        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        private string categoryname;
        public string Name
        {
            get { return categoryname; }
            set { categoryname = value; }
        }
        private string description;
        public string Desc
        {
            get { return description; }
            set { description = value; }

        }
        public List<Product> product;
        public List<Product> prod
        {
            get { return product; }
            set
            {
                product = value;
            }
        }
        static int cnt = 0;
        public void AddProdut()
        {
            cnt++;
            Console.WriteLine("Product added {0}", cnt);
        }
        public void DeleteProduct()
        {
            cnt--;
            Console.WriteLine("Product added {0}", cnt);
        }
        public Class1()
        {

        }
        public void AddCategory(int id, string name, string desc)
        {
            categoryid = id;
            categoryname = name;
            description = desc;
        }
        public void Display()
        {
            Console.WriteLine(categoryid);
            Console.WriteLine(categoryname);
            Console.WriteLine(description);
            foreach (var item in product)
            {
                Console.WriteLine(item.Productid);
                Console.WriteLine(item.Productname);

            }
        }
    }
}

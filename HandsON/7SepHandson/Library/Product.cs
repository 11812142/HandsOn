using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public delegate void q4(Product p);
    public class Product
    {
        private int _productid;

        public int ProductId
        {
            get { return _productid; }
            set { _productid = value; }
        }

        private string _productname;

        public string ProductName
        {
            get { return _productname; }
            set { _productname = value; }
        }
        public void Display(Product p)
        {
            Console.WriteLine($"Product id is {p.ProductId} and name is {p.ProductName}");
        }

    }
}


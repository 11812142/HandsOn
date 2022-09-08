using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Product
    {
        private int productid;
        public int Productid
        {
            get { return productid; }
            set { productid = value; }
        }
        private string productname;
        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }
        private int qtysold;
        public int Qtysold
        {
            get { return qtysold; }
            set { qtysold = value; }
        }
        private int quanInhand;
        public int QuanInhand
        {
            get { return quanInhand; }
            set
            {
                quanInhand = value;
            }
        }
        private int unitprice;
        public int Unitprice
        {
            get { return unitprice; }
            set
            {
                unitprice = value;
            }
        }
        private string unit;
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
            }
        }

        public void Reorder()
        {
            int reorder;
            reorder = qtysold;

        }
        public void AddProduct(int id, string name)
        {
            productid = id;
            productname = name;

        }
    }
}


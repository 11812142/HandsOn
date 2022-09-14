using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Product
    {
		private int _productId;

		public int ProductID
		{
			get { return _productId; }
			set { _productId = value; }
		}

		private string _productName;

		public string ProductName
		{
			get { return _productName; }
			set { _productName = value; }
		}
        

        
    }
}

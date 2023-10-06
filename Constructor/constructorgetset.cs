using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class constructorgetset
    {
		public constructorgetset(string name,double price,int quantity)
		{
			Name = name;
			Price = price;	
			Quantity = quantity;	

		}
		private string Name;

		public string  name
		{
			get { return Name; }
			set { Name = value; }
		}
		//////////////////////////////
		private double Price;

		public double price
		{
			get { return Price; }
			set { Price = value; }
		}
		///////////////////////////////
		private int Quantity;

		public int quantity
		{
			get { return Quantity; }
			set { Quantity = value; }
		}


	}
}

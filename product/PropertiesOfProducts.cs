using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product
{
    internal class propertiesOfproducts
        {
            private int productId;

            public int ProductId
            {
                get { return productId; }
                set { productId = value; }
            }
            ///////////////////////////////////
            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            ////////////////////////////////////
            private float price;

            public float Price
            {
                get { return price; }
                set { price = value; }
            }
            ////////////////////////////////////
            private string UnitOfMeasurment;

            public string UoM
            {
                get { return UnitOfMeasurment; }
                set { UnitOfMeasurment = value; }
            }
            ////////////////////////////////////
            private double quantity;

            public double Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }

        }
    }
 
  
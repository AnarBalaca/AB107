using System;
namespace AB107HomeClassTask
{
	public class Product
	{


        public Product(int no, string name, double price, int count)
        {
            this.no = no;
            this.name = name;
            Price = price;
            Count = count;
        }


		private double _price;
		private int _count;

		public int no;
		public string name;

        public double Price { get { return _price; }
			set
			{
				if (value >0 && value< 999.99)
				{
					_price = value;
				}
			}
		}



        public int Count
        {
            get { return _count; }
            set
            {
                if (value > 0 && value < 999.99)
                {
                    _count = value;
                }
            }
        }






    }
}


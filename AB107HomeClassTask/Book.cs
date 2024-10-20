using System;
namespace AB107HomeClassTask
{
	public class Book : Product
	{
		public string genre;

        public Book(int no, string name, double price, int count , string genre) : base(no, name, price, count)
        {
            this.genre = genre;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{name} No{no} Price:{Price} Count:{Count} Genre{genre}");
        }

    }
}


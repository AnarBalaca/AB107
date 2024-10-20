using System;
namespace AB107HomeClassTask
{
	public class Library
	{
		Book[] books = { };



		public void AddBook(Book book)
		{
			Array.Resize(ref books, books.Length + 1 );
			books[^1] = book;
		}


		public Book[] GetFilteredBooks(string genre)
		{
			Book[] foundedBooks = { };

			foreach (var book in books)
			{
				if (book.genre == genre)
				{
					Array.Resize(ref foundedBooks, foundedBooks.Length + 1);
					foundedBooks[^1] = book;
				}

			}
	    	return foundedBooks;
		}


		public Book[] GetFilteredBooks(double minPrice , double MaxPrice)
		{

            Book[] foundedBooks = { };

            foreach (var book in books)
            {
                if (book.Price > minPrice && book.Price < MaxPrice)
                {
                    Array.Resize(ref foundedBooks, foundedBooks.Length + 1);
                    foundedBooks[^1] = book;
                }
            }
            return foundedBooks;
        }


		public void ShowAllBooks()
		{
			foreach (var book in books)
			{
				book.ShowInfo();
			}
		}

	}
}


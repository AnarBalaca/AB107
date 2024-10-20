using System.Xml.Linq;

namespace AB107HomeClassTask;

class Program
{
    static void Main(string[] args)
    {

        Menu();

       
    }


    static void Menu()
    {
        Library library = new Library();

        double price;
        int count;
        int no;
        string name;


        string genre;


        string choice;

        double minPrice;
        double maxPrice;



        bool f = false;
        do
        {




            Console.WriteLine("1.Add Book  2.Get Filtered Books(janra gore)  3.Get Filtered Books(qiymet araliqi)  4.Show All Books  0.EXIT");
            
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":


                    do
                    {
                        f = false;
                        Console.WriteLine("no daxil edin");
                        f = int.TryParse(Console.ReadLine(), out no);
                        if (f == false)
                        {
                            Console.WriteLine("wrong input");
                        }


                    } while (!f);

                    do
                    {
                        f = false;
                        Console.WriteLine("count daxil edin");

                        f = int.TryParse(Console.ReadLine(), out count);
                        if (f == false)
                        {
                            Console.WriteLine("wrong input");
                        }


                    } while (!f);


                    do
                    {
                        f = false;
                        Console.WriteLine("price daxil edin");

                        f = double.TryParse(Console.ReadLine(), out price);
                        if (f == false)
                        {
                            Console.WriteLine("wrong input");
                        }
                        

                    } while (!f);

                    Console.WriteLine("name daxil edin");

                    name = Console.ReadLine();

                    Console.WriteLine("genre daxil edin");

                    genre = Console.ReadLine();



                    Book book = new Book(no , name , price , count , genre);

                    library.AddBook(book);
                    f = false;
                    break;

                case "2":
                    genre = Console.ReadLine();
                    Book[] founded =library.GetFilteredBooks(genre);

                    foreach (var item in founded)
                    {
                        item.ShowInfo();
                    }

                    break;

                case "3":

                    do
                    {
                        f = false;
                        Console.WriteLine("min price daxil edin");

                        f = double.TryParse(Console.ReadLine(), out minPrice);
                        if (f == false)
                        {
                            Console.WriteLine("wrong input");
                        }


                    } while (!f);

                    do
                    {
                        f = false;
                        Console.WriteLine("max price daxil edin");

                        f = double.TryParse(Console.ReadLine(), out maxPrice);
                        if (f == false)
                        {
                            Console.WriteLine("wrong input");
                        }

                       

                    } while (!f);
                    Book[] foundedBooks = library.GetFilteredBooks(minPrice , maxPrice);

                    foreach (var item in foundedBooks)
                    {
                        item.ShowInfo();
                    }
                    f = false;
                    break;

                    

                case "4":
                    library.ShowAllBooks();
                    break;
                case "0":
                    f = true;
                    break;

                default:
                    break;
            }



        } while (!f);

    }
}






//Price -> (encapsulation)
//Count -> (encapsulation)
//No
//Name

//Book class
//===========
//string Genre
//Book classi Productdan miras alir. Book yaratmaq istedikde butun deyerleri daxil edilmeden (no, price, name, genre) yaradila bilmesin.
//ShowInfo() - kitabin butun melumatlarini ekranda gosterir

//Library class
//=============
//Book[] Books;

//void AddBook(Book book) - Book tipinden book qebul edir parameter olaraq ve onu
//Books arrayine elave edir.
//GetFilteredBooks(string genre) -> janr deyeri daxil edib hemin janra uygun kitablarin siyahisini geriye qaytarir.
//GetFilteredBooks(int minPrice, int maxPrice) -> minimum qiymet ve maksimum qiymet qebul edib bu qiymet araligindaki kitablarin siyahisini geriye qaytarir.
//void ShowAllBooks() - Books arrarindeki kitablari gosterir


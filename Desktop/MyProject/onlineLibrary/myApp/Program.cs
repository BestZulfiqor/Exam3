using System;
using Library;

class Program
{
	static void Main(string[] args)
	{
		Book book1 = new Book("Isbn11111", "Shohnoma", "Firdavsi", 900);
		Book book2 = new Book("Isbn22222", "Odina", "Sadriddin Ayni", 1917);
		Book book3 = new Book("Isbn33333", "Margi sudkhur", "Sadriddin Ayni", 1917);
		Book book4 = new Book("Isbn44444", "Tojikon", "Bobojon Ghafurov", 1960);
		Book book5 = new Book("Isbn44444", "Chehrai Mondagor", "Emomali Ramon", 2016);
		Library.Library library = new Library.Library("Kitobkhonai Milli", 5);
		library.AddBook(book1);
		library.AddBook(book2);
		library.AddBook(book3);
		library.AddBook(book4);
		library.AddBook(book5);
		library.FindBooksByAuthor("Sadriddin Ayni");
		library.ShowBooks();
	}
}
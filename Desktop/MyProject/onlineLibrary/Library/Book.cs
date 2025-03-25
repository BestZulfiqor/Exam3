using System.Drawing;
using System.Runtime.CompilerServices;

namespace Library;

public class Book
{
	private string ISBN;
	public string GetISBN(){
		return ISBN;
	}
	public void SetISBN(string ISBN){
		if (ISBN.Length >= 8 && ISBN.Length <= 10)
		{
			this.ISBN = ISBN;		
		}
		else Console.WriteLine("Error");
	}
	public string Author { get; set; }
	public string Title { get; set; }
	public int PublicationYear { get; set; }
	public Book(string ISBN,string Title, string Author, int PublicationYear){
		this.ISBN = ISBN;
		this.Title = Title;
		this.Author = Author;
		this.PublicationYear = PublicationYear;
	}
	public void ShowBook(){
		Console.WriteLine($"ISBN: {ISBN}, Author: {Author}, Title: {Title}, PublicationYear: {PublicationYear}");
	}
}

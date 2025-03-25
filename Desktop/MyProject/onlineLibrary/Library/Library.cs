namespace Library;

public class Library
{
	public string Name { get; set; }
	public Book[] Books { get; set; }
	public Book[] GetBooks(){
		return Books;
	}
	int index;
	public Library(string Name, int size){
		Books = new Book[size];
		this.Name = Name;
	}
	public void AddBook(Book book){
		if (index < Books.Length)
		{
			Books[index] = book;
			index++;
		}
		else System.Console.WriteLine("Error");
	}
	public void FindBooksByAuthor(string author){
		System.Console.WriteLine($"Книги автора {author}:");
		foreach (var book in Books)
		{
			if (book.Author == author)
			{
				book.ShowBook();
			}
		}
		System.Console.WriteLine();
	}
	public void ShowBooks(){
		System.Console.WriteLine("Все книги:");
		foreach (var book in Books)
		{
			book.ShowBook();
		}
		System.Console.WriteLine();
	}
}

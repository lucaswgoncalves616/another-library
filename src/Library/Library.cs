namespace Library;

public class Library
{
    private static List<Book> books = new List<Book>
    {
        new Book("Orgulho e Preconceito", "Jane Austen"),
        new Book("1984", "George Orwell"),
        new Book("O Sol é Para Todos", "Harper Lee"),
        new Book("Cem Anos de Solidão", "Gabriel García Márquez"),
        new Book("Harry Potter e a Pedra Filosofal", "J.K. Rowling"),
        new Book("A Menina que Roubava Livros", "Markus Zusak")
    };
    public List<Book> Books
    {
        get => books;
        set => books = value;
    }

    public static void AddNewBook(String title, String author)
    {
        books.Add(new Book(title, author));
    }
    
    
}
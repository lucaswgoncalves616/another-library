namespace Library;

public class Book : ILoanable
{
    public int BookId { get; set; }
    private static int bookNextId = 1;

    public static int BookNextId
    {
        get => bookNextId;
        set => bookNextId = value;
    }
    public String Title { get; set; }
    public String Author { get; set; }

    private bool isLoaned = false; 
    public bool IsLoaned
    {
        get => isLoaned;
        set => isLoaned = value;
    }

    public Book(string title, string author)
    {
        BookId = BookNextId++;
        Title = title;
        Author = author;
    }

    public void LoanBook(User user)
    {
        IsLoaned = true;
    }

    public void ReturnBook()
    {
        IsLoaned = false;
    }
    
    public override string ToString()
    {
        return $"ID: {BookId}" +
               $"\nTitulo: {Title}" +
               $"\nAutor: {Author}";
    }
}
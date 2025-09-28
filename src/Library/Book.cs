namespace Library;

public class Book : Loanable
{
    public String BookId { get; set; }
    public String Title { get; set; }
    public String Author { get; set; }

    private bool isLoaned = false; 
    public bool IsLoaned
    {
        get => isLoaned;
        set => isLoaned = value;
    }

    public Book(string bookId, string title, string author)
    {
        BookId = bookId;
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
}
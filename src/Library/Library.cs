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
        new Book("A Menina que Roubava Livros", "Markus Zusak"),
        new Book("Cem Anos de Solidão", "Gabriel García Márquez"),
        new Book("Orgulho e Preconceito", "Jane Austen"),
        new Book("Crime e Castigo", "Fiódor Dostoiévski"),
        new Book("O Hobbit", "J.R.R. Tolkien"),
        new Book("Dom Casmurro", "Machado de Assis")
    };
    public static List<Book> Books
    {
        get => books;
        set => books = value;
    }

    public static void AddNewBook(String title, String author)
    {
        books.Add(new Book(title, author));
    }

    public static void NewLoan(int bookId, int userId, String loanStartDate, String loanEndDate)
    {
        LoanRelation.NewLoanRelation(bookId, userId, loanStartDate, loanEndDate);
        
        int bookIndex ;
        foreach (Book book in books)
        {
            if (book.BookId == bookId)
            {
                book.LoanBook();
            }
        }
        
    }

    public static void EndLoan(int loanId) 
    {
        var loanListCopy = LoanRelation.GetLoanList().ToList();
        int loanIndex;
        
        foreach (LoanRelation loan in loanListCopy)
        {
            if (loan.LoanId == loanId)
            {
                LoanRelation.EndLoanRelation(loanId);
                foreach (Book book in books)
                {
                    if (book.BookId == LoanRelation.GetBookId(loanId))
                    {
                        book.ReturnBook();
                    }
                }
            }
        }
    }
    
    public static void showAllBooks()
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }
}
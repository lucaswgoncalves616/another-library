namespace Library;

public class Library
{
    private static List<Book> _books = new List<Book>
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
        get => _books;
        set => _books = value;
    }

    private static List<User> _users = new List<User>
    {
        new Teacher("Patrícia Santos", "patricia.santos@escola.edu"),
        new Teacher("Roberto Lima", "roberto.lima@escola.edu"),
        new Teacher("Adriana Melo", "adriana.melo@escola.edu"),

        new Student("Maria Silva", "maria.silva@hotmail.com"),
        new Student("Pedro Alves", "pedro.alves@hotmail.com"),
        new Student("Ana Costa", "ana.costa@hotmail.com")
    };

    public static List<User> Users
    {
        get => _users;
        set => _users = value;
    }
    
    public static User GetUserById(int userId)
    {
        foreach (User user in Users)
        {
            if (user.Id == userId)
            {
                return user;
            }
        }
        return null;
    }

    public static void AddNewBook(String title, String author)
    {
        _books.Add(new Book(title, author));
    }

    public static void NewLoan(int bookId, int userId, DateOnly loanStartDate, DateOnly loanEndDate)
    {
        int userid = userId;
        foreach (Book book in _books)
        {   
            if (book.BookId == bookId)
            {
                if (book.IsLoaned)
                {
                    Console.WriteLine("\nLivro Indisponivel");
                    break;
                }
                LoanRelation.NewLoanRelation(bookId, userId, loanStartDate, loanEndDate);
                IncreaseUserLoan(userId);
                book.LoanBook();
                Console.WriteLine("\nLivro emprestado com sucesso!");
                break;
            }
        }
    }

    public static void EndLoan(int loanId)
    {
        int bookId = LoanRelation.GetBookId(loanId);
        var loanListCopy = LoanRelation.GetLoanList().ToList();
        
        foreach (LoanRelation loan in loanListCopy)
        {
            if (loan.LoanId == loanId)
            {
                LoanRelation.EndLoanRelation(loanId);
            }
        }
        
        foreach (Book book in _books)
        {
            if (book.BookId == bookId)
            {
                book.ReturnBook();
                break;
            }
        }
        
        Console.WriteLine("\nLivro devolvido!");
    }
    
    public static void showAllBooks()
    {
        foreach (Book book in _books)
        {
            Console.WriteLine(book);
        }
    }

    public static bool CanUserLoan(User user)
    {
        if (user.Loans < user.getLoansLimit())
        {
            return true;
        }
        return false;
    }

    public static void IncreaseUserLoan(int userId)
    {
        User user = GetUserById(userId);
        user.Loans++;
    }
    
    public static void DecreaseUserLoan(int userId)
    {
        User user = GetUserById(userId);
        user.Loans--;
    }
}
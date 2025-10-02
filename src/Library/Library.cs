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

    public static void NewLoan(int bookId, int userId, DateOnly loanStartDate, DateOnly loanEndDate)
    {
        int userid = userId;
        foreach (Book book in books)
        {   
            // Continuar a partir aqui criando a lógica para pegar a quantidade de livros do objeto usuario :) ☝️👌
            
            if (book.BookId == bookId)
            {
                if (book.IsLoaned)
                {
                    Console.WriteLine("Livro Indisponivel");
                    break;
                }
                LoanRelation.NewLoanRelation(bookId, userId, loanStartDate, loanEndDate);
                book.LoanBook();
                Console.WriteLine("Livro emprestado com sucesso!");
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
        
        foreach (Book book in books)
        {
            if (book.BookId == bookId)
            {
                book.ReturnBook();
                break;
            }
        }
        Console.WriteLine("Livro devolvido!");
    }
    
    public static void showAllBooks()
    {
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }
}
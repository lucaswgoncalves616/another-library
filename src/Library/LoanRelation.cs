namespace Library;

public class LoanRelation
{
    public static List<LoanRelation> loans = new List<LoanRelation>();
    
    public int LoanId { get; set; }
    private static int loanNextId = 1;

    public static int LoanNextId
    {
        get => loanNextId;
        set => loanNextId = value;
    }
    
    public int BookId { get; set; }
    public int UserId { get; set; }
    public DateOnly LoanDate { get; set; }
    public DateOnly EndLoanDate { get; set; }

    public LoanRelation(int bookId, int userId, DateOnly loanDate, DateOnly endLoanDate)
    {
        LoanId = LoanNextId++;
        BookId = bookId;
        UserId = userId;
        LoanDate = loanDate;
        EndLoanDate = endLoanDate;
    }

    public static void NewLoanRelation(int bookId, int userId, DateOnly loanDate, DateOnly endLoanDate)
    {
        loans.Add(new LoanRelation(bookId, userId, loanDate, endLoanDate));
    }

    public static List<LoanRelation> GetLoanList()
    {
        return loans;
    }
    
    public static void EndLoanRelation(int loanId)
    {
        int loanIndex ;
        foreach (LoanRelation loan in loans)
        {
            if (loan.LoanId == loanId)
            {
                loanIndex = loans.IndexOf(loan);
                loans.RemoveAt(loanIndex);
                break;
            }
        }
    }

    public static int GetBookId(int loanId)
    {
        foreach (LoanRelation loan in loans)
        {
            if (loan.LoanId == loanId)
            {
                return loan.BookId;
            }
        }
        return 0;
    }

    public static int GetUserId(int loanId)
    {
        foreach (LoanRelation loan in loans)
        {
            if (loan.LoanId == loanId)
            {
                return loan.UserId;
            }
        }
        return 0;
    }
    
    public static void ShowAllLoans()
    {
        foreach (LoanRelation loan in loans)
        {
            Console.WriteLine(loan);
        }
    }

    public override string ToString()
    {
        return $"\nID Empréstimo: {LoanId}" +
               $"\nID do usuario: {UserId}" +
               $"\nID do livro: {BookId}" +
               $"\nData de empréstimo: {LoanDate}" +
               $"\nData de termino: {EndLoanDate}";
    }
}
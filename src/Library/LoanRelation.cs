namespace Library;

public class LoanRelation
{
    static List<LoanRelation> loans = new List<LoanRelation>();
    
    public int LoanId { get; set; }
    private static int loanNextId = 1;

    public static int LoanNextId
    {
        get => loanNextId;
        set => loanNextId = value;
    }
    
    public int BookId { get; set; }
    public int UserId { get; set; }
    public String LoanDate { get; set; }
    public String EndLoanDate { get; set; }

    public LoanRelation(int bookId, int userId, string loanDate, string endLoanDate)
    {
        LoanId = LoanNextId++;
        BookId = bookId;
        UserId = userId;
        LoanDate = loanDate;
        EndLoanDate = endLoanDate;
    }

    public static void NewLoanRelation(int bookId, int userId, String loanDate, String endLoanDate)
    {
        loans.Add(new LoanRelation(bookId, userId, loanDate, endLoanDate));
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
    

    public static void ShowAllLoans()
    {
        foreach (LoanRelation loan in loans)
        {
            Console.WriteLine(loan);
        }
    }

    public override string ToString()
    {
        return $"\nID: {LoanId}" +
               $"\nID do usuario: {UserId}" +
               $"\nID do livro: {BookId}" +
               $"\nData de empréstimo: {LoanDate}" +
               $"\nData de termino: {EndLoanDate}";
    }
}
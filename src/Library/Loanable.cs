namespace Library;

public interface ILoanable
{
    void LoanBook(User user);

    void ReturnBook();
}
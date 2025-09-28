namespace Library;

public interface Loanable
{
    void LoanBook(User user);

    void ReturnBook();
}
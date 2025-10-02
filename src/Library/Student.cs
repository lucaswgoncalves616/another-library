namespace Library;

public class Student : User
{
    public Student(string name, string email) : base(name, email)
    {
        
    }
    
    public override int getLoansLimit()
    {
        return 2;
    }
    
    public override string ToString()
    {
        return $"ID do aluno: {Id}" +
               $"\nNome: {Name}" +
               $"\nEmail: {Email}" +
               $"\nEmprestimos ativos: {Loans}\n";
    }
}
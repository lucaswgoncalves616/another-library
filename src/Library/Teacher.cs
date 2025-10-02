namespace Library;

public class Teacher : User
{  
    public Teacher(string name, string email) : base(name, email)
    {
        
    }

    public override int getLoansLimit()
    {
        return 5;
    }
    
    public override string ToString()
    {
        return $"ID do professor: {Id}" +
               $"\nNome: {Name}" +
               $"\nEmail: {Email}" +
               $"\nEmprestimos ativos: {Loans}\n";
    }
}
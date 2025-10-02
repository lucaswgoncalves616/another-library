namespace Library;

class Program
{
    static void Main(string[] args)
    {
        // Guarda a data atual em uma variavel e acrescenta 21 dias a variavel
        // para simular o fim do emprestimo do livro
        DateOnly dateToday = DateOnly.FromDateTime(System.DateTime.Now);
        DateOnly endDate = dateToday.AddDays(21);
        
        int response = 0;
        int userId = 0;
        int bookId;
        int endLoanId;
        while (response != 6)
        {
            Console.WriteLine("\nDigite a opção que deseja: " +
                              "\n1. Mostrar livros cadastrados" +
                              "\n2. Mostrar usuários cadastrados" +
                              "\n3. Mostrar emprestimos pendentes" +
                              "\n4. Emprestar livro" +
                              "\n5. Devolver livro" +
                              "\n6. Sair");
            response = Convert.ToInt32(Console.ReadLine());
            
            switch (response)
            {
                case 1: // Mostrar livros
                    Library.showAllBooks();
                    break;
                case 2: // Mostrar Usuarios
                    Console.WriteLine("\nUsuários cadastrados: ");
                    foreach (User user in Library.Users)
                    {
                        Console.WriteLine(user);
                    }
                    break;
                case 3: // Mostrar emprestimos
                    if (LoanRelation.loans.Count == 0)
                    {
                        Console.WriteLine("\nNenhum emprestimo pendente...");
                    } else
                    {
                        Console.WriteLine("\nEmprestimos pendentes: ");
                        LoanRelation.ShowAllLoans();
                    }
                    break;
                case 4: // Fazer novo emprestimo
                    Console.WriteLine("\nDigite o ID do Usuário que vai fazer o emprestimo:");
                    userId = Convert.ToInt32(Console.ReadLine());

                    if (!Library.CanUserLoan(Library.GetUserById(userId)))
                    {
                        Console.WriteLine("\nUsuário atingiu limite de emprestimo.");
                        break;
                    }
                    
                    Console.WriteLine("\nDigite o ID do livro que será emprestado:");
                    bookId = Convert.ToInt32(Console.ReadLine());
                    
                    Library.NewLoan(bookId, userId, dateToday, endDate);
                    break;
                case 5: // Remover emprestimo
                    if (LoanRelation.loans.Count == 0)
                    {
                        Console.WriteLine("\nNenhum emprestimo pendente...");
                    }
                    else
                    {
                        Console.WriteLine("\nDigite o ID do emprestimo que deseja encerrar: ");
                        endLoanId = Convert.ToInt32(Console.ReadLine());
                        
                        Library.DecreaseUserLoan(userId);
                        Library.EndLoan(endLoanId);
                    }
                    break;
            }
        }
        //Console.ReadKey();
    }
}

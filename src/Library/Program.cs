namespace Library;

class Program
{
    static void Main(string[] args)
    {
        DateOnly dateToday = DateOnly.FromDateTime(System.DateTime.Now);
        DateOnly endDate = dateToday.AddDays(21);
        
        
        List<User> students = new List<User>();
        List<User> teachers = new List<User>();

        teachers.Add(new Teacher("Patrícia Santos", "patricia.santos@escola.edu"));
        teachers.Add(new Teacher("Roberto Lima", "roberto.lima@escola.edu"));
        teachers.Add(new Teacher("Adriana Melo", "adriana.melo@escola.edu"));
        
        students.Add(new Student("Maria Silva", "maria.silva@hotmail.com"));
        students.Add(new Student("Pedro Alves", "pedro.alves@hotmail.com"));
        students.Add(new Student("Ana Costa", "ana.costa@hotmail.com"));
        
        int response = 0;
        int userId;
        int bookId;
        int endLoanId;
        while (response != 5)
        {
            Console.WriteLine("\nDigite a opção que deseja: " +
                              "\n1. Mostrar livros disponiveis" +
                              "\n2. Mostrar emprestimos pendentes" +
                              "\n3. Emprestar livro" +
                              "\n4. Devolver livro" +
                              "\n5. Sair");
            response = Convert.ToInt32(Console.ReadLine());
            
            switch (response)
            {
                case 1:
                    Library.showAllBooks();
                    break;
                case 2:
                    if (LoanRelation.loans.Count == 0)
                    {
                        Console.WriteLine("\nNenhum emprestimo pendente...");
                    } else
                    {
                        Console.WriteLine("\nEmprestimos pendentes: ");
                        LoanRelation.ShowAllLoans();
                    }
                    break;
                case 3:
                    Console.WriteLine("\nProfessores cadastrados: ");
                    foreach (User teacher in teachers)
                    {
                        Console.WriteLine(teacher);
                    }
                    
                    Console.WriteLine("Alunos cadastrados: \n");
                    foreach (User student in students)
                    {
                        Console.WriteLine(student);
                    }

                    Console.WriteLine("\nDigite o ID do Usuário que vai fazer o emprestimo:");
                    userId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nDigite o ID do livro que será emprestado:");
                    bookId = Convert.ToInt32(Console.ReadLine());
                    
                    Library.NewLoan(bookId, userId, dateToday, endDate);
                    LoanRelation.ShowAllLoans();
                    break;
                case 4:
                    if (LoanRelation.loans.Count == 0)
                    {
                        Console.WriteLine("\nNenhum emprestimo pendente...");
                    }
                    else
                    {
                        Console.WriteLine("\nDigite o ID do emprestimo que deseja encerrar: ");
                        endLoanId = Convert.ToInt32(Console.ReadLine());
                        
                        Library.EndLoan(endLoanId);
                    }
                    break;
            }
        }
        //Console.ReadKey();
    }
}

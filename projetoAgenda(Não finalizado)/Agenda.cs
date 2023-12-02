class Agenda
{
    List<Aluno> alunos = new List<Aluno>();
    List<Professor> prof = new List<Professor>();
    
    public void listarTodos()
    {
        Console.WriteLine("\nLista de contato de alunos\n");

        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine("Nome: " + aluno.getNome());
            Console.WriteLine("Idade: " + aluno.getIdade());
            Console.WriteLine("Email: " + aluno.getEmail());
            Console.WriteLine("CPF: " + aluno.getCPF());
            Console.WriteLine("Registro Matricula: " + aluno.getRegistroMatricula());
            Console.WriteLine("Curso: " + aluno.getCurso());            
        }

        Console.WriteLine("\nLista de contatados dos professores\n");

        foreach(Professor professor in prof)
        {
            Console.WriteLine("Nome: " + professor.getNome());
            Console.WriteLine("Idade: " + professor.getIdade());
            Console.WriteLine("Email: " + professor.getEmail());
            Console.WriteLine("CPF: " + professor.getCPF());
            Console.WriteLine("Numero Registro: " + professor.getNumeroRegistro());
            Console.WriteLine("Materia Lecionada: " + professor.getLecionaMateria());
        }
    }
    public void cadastrarAluno()
    {
        Aluno al = new Aluno();

        Console.WriteLine("Entre com o nome do aluno: ");
        al.setNome(Console.ReadLine()); 

        Console.WriteLine("Entre com a idade do aluno: ");
        al.setIdade(int.Parse(Console.ReadLine())); 

        Console.WriteLine("Entre com o email do aluno: ");
        al.setEmail(Console.ReadLine());

        Console.WriteLine("Entre com o CPF do aluno: ");
        al.setCPF(int.Parse(Console.ReadLine()));

        Console.WriteLine("Entre com o curso do aluno: ");
        al.setCurso(Console.ReadLine());

        Console.WriteLine("Entre com o registro de matricula do aluno: ");
        al.setRegistroMatricula(Console.ReadLine());

        alunos.Add(al);
        Console.WriteLine("Aluno cadastrado com sucesso");
    }

    public void editaAluno()
    {
        Console.WriteLine("Entre com o nome do aluno: 1 - sim | 2 - não");
        string nomeAluno = Console.ReadLine();
        Aluno al = null;

        foreach(Aluno ler in alunos){
            if(ler.getNome().Equals(nomeAluno))
            {
                al = ler;
            }
        }

        if (al != null)
        {
            Console.WriteLine("Deseja altera o nome do aluno: ");
            short escolha = short.Parse(Console.ReadLine());
            
            if(escolha == 1)
            {
                Console.WriteLine("Entre com o novo nome: ");
                string novoNome = Console.ReadLine();
                al.setNome(novoNome);

                Console.WriteLine("Edite a idade: ");
                int idade = int.Parse(Console.ReadLine()); 
                al.setIdade(idade);

                Console.WriteLine("Edite o email: ");
                string novoEmail = Console.ReadLine();
                al.setEmail(novoEmail);

                Console.WriteLine("Edite o CPF: ");
                int novoCPF = int.Parse(Console.ReadLine());
                al.setCPF(novoCPF);

                Console.WriteLine("Edite o Registro de matricula: ");
                string novaRegistroMatricula= Console.ReadLine();
                al.setRegistroMatricula(novaRegistroMatricula);

                Console.WriteLine("Edite o curso: ");
                string novoCurso = Console.ReadLine();
                al.setCurso(novoCurso);
            }
            else
            {
                Console.WriteLine("Aluno não foi alterado!");
            }
        }
    }
    public void DeletaAluno()
    {
        Console.WriteLine("Entre com o nome do aluno: ");
        string nome = Console.ReadLine();
        Aluno al = null;

        foreach(Aluno a in alunos)
        {
            if(a.getNome().Equals(nome))
            {
                al = a;
            }
        }
        if(al != null)
        {
            Console.WriteLine($"Aluno {al} deletado com sucesso!");
        }
    }

    public void cadastraProfessor()
    {
        Professor fessor = new Professor();

        Console.WriteLine("Entre com o nome do aluno: ");
        fessor.setNome(Console.ReadLine()); 

        Console.WriteLine("Entre com a idade do aluno: ");
        fessor.setIdade(int.Parse(Console.ReadLine())); 

        Console.WriteLine("Entre com o email do aluno: ");
        fessor.setEmail(Console.ReadLine());

        Console.WriteLine("Entre com o CPF do aluno: ");
        fessor.setCPF(int.Parse(Console.ReadLine()));

        Console.WriteLine("Entre com a materia do professor: ");
        fessor.setLecionaMateria(Console.ReadLine());

        Console.WriteLine("Entre com o numero de registro do professor: ");
        fessor.setNumeroRegistro(int.Parse(Console.ReadLine()));

        prof.Add(fessor);
        Console.WriteLine("Professor cadastrado com sucesso");
    }

    public void editarProfessor()
    {
        Console.WriteLine("Entre com o nome do Professor: ");
        string nome = Console.ReadLine();
        Professor fessor = null;

        foreach(Professor p in prof)
        {
            if(p.getNome().Equals(nome))
            {
                fessor = p;
            }
        }

        if(fessor != null)
        {
            Console.WriteLine("Deseja alterar o cadastro do aluno: 1 - sim | 2 - não");
            short entrada = short.Parse(Console.ReadLine());

            if(entrada == 1)
            {
                Console.WriteLine("Entre com o novo nome: ");
                string novoNome = Console.ReadLine();
                fessor.setNome(novoNome);

                Console.WriteLine("Edite a idade: ");
                int idade = int.Parse(Console.ReadLine()); 
                fessor.setIdade(idade);

                Console.WriteLine("Edite o email: ");
                string novoEmail = Console.ReadLine();
                fessor.setEmail(novoEmail);

                Console.WriteLine("Edite o CPF: ");
                int novoCPF = int.Parse(Console.ReadLine());
                fessor.setCPF(novoCPF);

                Console.WriteLine("Edite o Registro de matricula: ");
                int novaRegistroMatricula= int.Parse(Console.ReadLine());
                fessor.setNumeroRegistro(novaRegistroMatricula);

                Console.WriteLine("Edite o curso: ");
                string novoCurso = Console.ReadLine();
                fessor.setLecionaMateria(novoCurso);
            }
            else
            {
                Console.WriteLine("Aluno não foi editado!");
            }
        }
    }

    public void DeletaProfessor()
    {
        Console.WriteLine("Entre com o nome do professor: ");
        string nome = Console.ReadLine();
        Professor fessor = null;

        foreach(Professor p in prof)
        {
            if(p.getNome().Equals(nome))
            {
                fessor = p;
            }
        }
        if(fessor != null)
        {
            Console.WriteLine($"Professor {fessor} deletado com sucesso!");
        }
    }
}

using Metodos;

Pessoa pessoa1 = new Pessoa("Marcos Miguel", 22);
pessoa1.Sobrenome = "Avelino";
pessoa1.Apresentar();

Pessoa pessoa2 = new Pessoa("Bruno Matheus", 29);
pessoa2.Sobrenome = "Avelino";
pessoa2.Apresentar();

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "English Course";

cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);

Console.WriteLine(cursoDeIngles.ObterQuantidadeDeAlunosMatriculados(cursoDeIngles.Alunos));
cursoDeIngles.ListarAlunos();

cursoDeIngles.RemoverAluno(pessoa1);

Console.WriteLine(cursoDeIngles.ObterQuantidadeDeAlunosMatriculados(cursoDeIngles.Alunos));
cursoDeIngles.ListarAlunos();



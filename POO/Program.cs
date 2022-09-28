using POO.Models;

Aluno aluno1 = new Aluno();
aluno1.Nome = "Marcos Miguel";
aluno1.Idade = 22;
aluno1.Email = "teste@teste.com";
aluno1.Nota = 10;

aluno1.Apresentar();

Professor prof = new Professor();
prof.Nome = "Leonardo Buta";
prof.Idade = 26;
prof.Email = "teste@teste.com";
prof.Salario = 3890.90;

prof.Apresentar();
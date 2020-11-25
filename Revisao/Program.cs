using System;

namespace Revisao
{
  class Program
  {
    static void Main(string[] args)
    {
      Aluno[] alunos = new Aluno[5];
      var indiceAluno = 0;
      string opcaoUsuario = obterOpcaoUsuario();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            Console.WriteLine("Informe o nome do aluno:");
            Aluno aluno = new Aluno();
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno:");

            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
              aluno.Nota = nota;
            }
            else
            {
              throw new ArgumentException("O valor da nota deve ser decimal.");
            }

            alunos[indiceAluno] = aluno;
            indiceAluno++;

            break;
          case "2":
            // listar alunos
            break;
          case "3":
            // gerar media geral
            break;
          default:
            throw new ArgumentOutOfRangeException();
        }
        opcaoUsuario = obterOpcaoUsuario();
      }
    }

    private static string obterOpcaoUsuario()
    {
      Console.WriteLine();
      Console.WriteLine("Informe a opçao desejada:");
      Console.WriteLine("1 - Inserir novo aluno:");
      Console.WriteLine("2 - Listar alunos:");
      Console.WriteLine("1 - Calcular média geral:");
      Console.WriteLine("X - Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine();
      Console.WriteLine();
      return opcaoUsuario;
    }
  }
}

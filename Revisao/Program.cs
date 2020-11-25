using System;

namespace Revisao
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Informe a opçao desejada:");
      Console.WriteLine("1 - Inserir novo aluno:");
      Console.WriteLine("2 - Listar alunos:");
      Console.WriteLine("1 - Calcular média geral:");
      Console.WriteLine("X - Sair");
      Console.WriteLine();

      string opcaoUsuario = Console.ReadLine();

      while (opcaoUsuario.ToUpper() != "X")
      {
        switch (opcaoUsuario)
        {
          case "1":
            // adicionar aluno
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
        Console.WriteLine("Informe a opçao desejada:");
        Console.WriteLine("1 - Inserir novo aluno:");
        Console.WriteLine("2 - Listar alunos:");
        Console.WriteLine("1 - Calcular média geral:");
        Console.WriteLine("X - Sair");
        Console.WriteLine();
      }
    }
  }
}

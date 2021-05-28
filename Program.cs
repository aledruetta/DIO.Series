using System;
using DIO.Series.ViewControl;

namespace DIO.Series
{
    class Program
    {

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        SeriesViewControl.InserirSerie();
                        break;
                    case "2":
                        SeriesViewControl.VisualizarSerie();
                        break;
                    case "3":
                        SeriesViewControl.ListarSeries();
                        break;
                    case "4":
                        SeriesViewControl.AtualizarSerie();
                        break;
                    case "5":
                        SeriesViewControl.ExcluirSerie();
                        break;
                    case "L":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Menu Séries");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir nova série");
            Console.WriteLine("2 - Visualizar série");
            Console.WriteLine("3 - Listar séries");
            Console.WriteLine("4 - Atualizar série");
            Console.WriteLine("5 - Excluir série");
            Console.WriteLine("L - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcaoUsuario;
        }
    }
}

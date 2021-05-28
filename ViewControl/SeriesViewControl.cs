using System;
using System.Collections.Generic;
using DIO.Series.Model;
using DIO.Series.Repository;

namespace DIO.Series.ViewControl
{
    public class SeriesViewControl
    {
        private static readonly IRepository<Serie> _repository = new SerieRepository();

        public static void VisualizarSerie()
        {
            Console.Write("Ingrese o Id da série: ");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine(_repository.Read(id));
        }

        public static void ExcluirSerie()
        {
            Console.Write("Ingrese o Id da série: ");
            var id = int.Parse(Console.ReadLine());

            Serie serie = _repository.Read(id);

            if (serie == null)
            {
                Console.WriteLine("O Id inserido não está cadastrado!");
            }
            else
            {
                _repository.Delete(serie);
                Console.WriteLine($"Série excluída: {serie}");
            }
        }

        public static void AtualizarSerie()
        {
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Serie serie = _repository.Read(id);

            if (serie == null)
            {
                Console.WriteLine("O Id inserido não está cadastrado!");
            }
            else
            {
                Console.Write("Título: ");
                serie.Titulo = Console.ReadLine();

                Console.Write("Descrição: ");
                serie.Descricao = Console.ReadLine();

                Console.Write("Gênero: ");
                serie.Genero = (Genero)int.Parse(Console.ReadLine());

                Console.Write("Ano: ");
                serie.Ano = int.Parse(Console.ReadLine());

                _repository.Update(serie);
            }
        }

        public static void InserirSerie()
        {
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());

            Console.Write("Título: ");
            var titulo = Console.ReadLine();

            Console.Write("Descrição: ");
            var descricao = Console.ReadLine();

            mostrarGeneros();
            Console.Write("Gênero: ");
            var genero = (Genero)int.Parse(Console.ReadLine()) - 1;

            Console.Write("Ano: ");
            var ano = int.Parse(Console.ReadLine());

            var serie = new Serie(id, genero, titulo, descricao, ano);

            _repository.Create(serie);
        }

        private static void mostrarGeneros()
        {
            int i = 0;
            foreach (var value in Enum.GetValues<Genero>())
            {
                Console.Write($"{++i} - ");
                Console.WriteLine(value);
            }
        }

        public static void ListarSeries()
        {
            List<Serie> lista = _repository.GetAll();
            foreach (var item in lista)
                Console.WriteLine(item);
        }
    }
}
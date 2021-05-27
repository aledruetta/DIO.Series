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
            _repository.Read(1234);
        }

        public static void ExcluirSerie()
        {
            Serie serie = _repository.Read(1234);
            _repository.Delete(serie);
        }

        public static void AtualizarSerie()
        {
            Serie serie = _repository.Read(1234);
            serie.Ano = 2007;
            _repository.Update(serie);
        }

        public static void InserirSerie()
        {
            Serie serie = new Serie(1234, Genero.Acao, "Título", "Descricao", 1980);
            _repository.Create(serie);
        }

        public static void ListarSeries()
        {
            List<Serie> lista = _repository.GetItemList();
            foreach (var item in lista)
                Console.WriteLine(item);
        }
    }
}
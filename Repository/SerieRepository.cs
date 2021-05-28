using System.Collections.Generic;
using DIO.Series.Model;

namespace DIO.Series.Repository
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> _series = new List<Serie>();

        public List<Serie> GetAll()
        {
            // Lista todas as séries que não tem sido excluídas
            return _series.FindAll(item => !item.Excluido);
        }

        public void Create(Serie item)
        {
            try
            {
                _series.Add(item);
            }
            catch (System.NullReferenceException)
            {
                throw;
            }
        }

        public Serie Read(int id)
        {
            Serie serie = _series.Find(item => item.Id == id);

            if (serie != null && !serie.Excluido)
                return serie;

            return null;
        }

        public void Update(Serie serie)
        {
            try
            {
                if (!serie.Excluido)
                {
                    int index = _series.FindIndex(item => item.Id == serie.Id);
                    _series[index] = serie;
                }
            }
            catch (System.NullReferenceException)
            {
                throw;
            }
        }

        public void Delete(Serie serie)
        {
            try
            {
                if (!serie.Excluido)
                {
                    int index = _series.FindIndex(item => item.Id == serie.Id);
                    _series[index].Excluir();
                }
            }
            catch (System.NullReferenceException)
            {
                throw;
            }
        }
    }
}
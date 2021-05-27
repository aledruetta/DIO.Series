using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series.Entities
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> _series = new List<Serie>();

        public List<Serie> GetItemList()
        {
            return _series;
        }

        public void Create(Serie item)
        {
            _series.Add(item);
        }

        public Serie Read(int id)
        {
            return _series.Find(item => item.Id == id);
        }

        public void Update(Serie item)
        {
            int index = _series.FindIndex(i => i.Id == item.Id);
            _series[index] = item;
        }

        public void Delete(Serie item)
        {
            int index = _series.FindIndex(i => i.Id == item.Id);
            _series[index].Excluir();
        }
    }
}
using System.Collections.Generic;
using Dio.Series.Interfaces;

namespace Dio.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSeries;

        public SerieRepositorio()
        {
            listaSeries = new List<Serie>();
        }

        public void Atualizar(int id, Serie entidade)
        {
            listaSeries[id] = entidade;
        }

        public void Exclui(int id)
        {
            listaSeries[id].Excluir();
        }

        public void Insere(Serie entidade)
        {
            listaSeries.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSeries[id];
        }
    }
}
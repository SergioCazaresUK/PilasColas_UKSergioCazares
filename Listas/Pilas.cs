using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> lista;
        public Pilas()
        {
            lista = new List<string>();
        }

        public void Agregar(string dato)
        {
            lista.Add(dato);
        }

        private bool ValidaVacio()
        {
            return (lista.Count == 0);
        }
    }
}

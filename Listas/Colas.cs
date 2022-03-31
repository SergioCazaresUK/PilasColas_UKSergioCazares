﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Colas
    {
        private List<string> lista;
        public Colas()
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

        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Lista Vacia");
            }
            lista.RemoveAt(0);
        }

        public string Imprimir()
        {
            string dato = string.Empty;

            if (ValidaVacio())
            {
                return "Lista Vacia";
            }

            int contador = lista.Count;
            for (int i = 0; i < contador; i++)
            {
                if (i > 0)
                {
                    dato += "\n";
                }
                dato += $"[{i}] - {lista[i]}";
            }
            return dato;
        }
    }
}

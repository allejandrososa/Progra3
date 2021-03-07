using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Clases.ArbolBinario
{
    class arbolBinario
    {
        protected Nodo raiz;

        public arbolBinario(Nodo a)
        {
            raiz = null;
        }


        public Nodo raizArbol()
        {
            return raiz;
    }
        bool esVacio()
        {
            return raiz == null;
        }

        public static Nodo nuevoArbol(Nodo ramaIzqda, object dato, Nodo ramaDrcha)
        {
            return new Nodo(ramaIzqda, dato, ramaDrcha);
        }

    }
    
}

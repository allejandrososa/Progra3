﻿using Clase3.Clases.ArbolBinario;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Clases.JuegoAnimal
{
    class AdivinaAnimal
    {
        private static Nodo raiz;

        public AdivinaAnimal()
        {
            raiz = new Nodo("Elefante");
        }

        public void jugar()
        {
            Nodo nodo = raiz;

            while (nodo != null) //iteracion del arbol
            {
                if (nodo.izquierda != null) //existe una pregunta
                {
                    Console.WriteLine(nodo.valorNodo());
                    nodo = (respuesta()) ? nodo.izquierda : nodo.derecha;
                }
                else
                {
                    Console.WriteLine($"Ya se, es un {nodo.valorNodo()}");
                    if (respuesta())
                    {
                        Console.WriteLine("Gane!!!!   :)");
                    }
                    else
                    {
                        animalNuevo(nodo);
                    }
                    nodo = null;
                    return;
                }// fin if
            }// fin while
        }// fin jugar

        public bool respuesta()
        {

            while (true)
            {
                String resp = Console.ReadLine().ToLower().Trim();
                if (resp.Equals("si")) return true;
                if (resp.Equals("no")) return false;
                Console.WriteLine("La respuesta debe ser SI o NO");
            }

        }//fin de respuesta

        private void animalNuevo(Nodo nodo)
        {
            String animalNodo = (String)nodo.valorNodo();
            Console.WriteLine("Cual es tu animal pues?");
            String nuevoA = Console.ReadLine();
            Console.WriteLine($"Que pregunta con respuesta si / no puedo hacer para poder decir que es un {nuevoA}");
            string pregunta = Console.ReadLine();
            Nodo nodo1 = new Nodo(animalNodo);
            Nodo nodo2 = new Nodo(nuevoA);
            Console.WriteLine($"Para un(a) {nuevoA} la respuesta es si / no ?");
            nodo.nuevoValor(pregunta + "?");

            if (respuesta())
            {
                nodo.izquierda = nodo2;
                nodo.derecha = nodo1;
            }
            else
            {
                nodo.izquierda = nodo1;
                nodo.derecha = nodo2;
            }

        }
    }
}

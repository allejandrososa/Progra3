using Clase3.Clases.ArbolBinario;
using Clase3.Clases.JuegoAnimal;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Clase3
{
    class Program
    {
        public static void preorden(Nodo r)
        {
            if (r != null)
            {
                r.visitar();
                preorden(r.subarbolDerecho());
                preorden(r.subarbolDerecho());
            }


        }

        public static void indorden(Nodo r)
        {
            if (r != null)
            {
                indorden(r.subarbolIzquierdo());
                r.visitar();
                indorden(r.subarbolDerecho());
            }
        }

        public static void postorden(Nodo r)
        {
            if (r != null)
            {
                postorden(r.subarbolIzquierdo());
                postorden(r.subarbolDerecho());
                r.visitar();
            }
        }

        public static void arbolInicial()
        {
            try
            {
                arbolBinario arbol;
                Nodo a1, a2, a;
                Stack pila = new Stack();
                a1 = arbolBinario.nuevoArbol(null, "Maria", null);
                a2 = arbolBinario.nuevoArbol(null, "fabrizio", null);
                a = arbolBinario.nuevoArbol(a1, "Gaby", a2);
                pila.Push(a); //apilar
                a1 = arbolBinario.nuevoArbol(null, "Andrea", null);
                a2 = arbolBinario.nuevoArbol(null, "Abel", null);
                a = arbolBinario.nuevoArbol(a1, "Monica", a2);
                pila.Push(a); //apilar

                a1 = (Nodo)pila.Pop();
                a2 = (Nodo)pila.Pop();

                a = arbolBinario.nuevoArbol(a1, "Hector", a2);
                arbol = new arbolBinario(a);
                int pausa;
                pausa = 0;

                Console.WriteLine("Preorden: ");
                preorden(a);
                Console.WriteLine("");
                Console.WriteLine("Postorden: ");
                postorden(a);
                Console.WriteLine("");
                Console.WriteLine("Inorden");
                indorden(a);

            }
            catch (Exception ex)
            {
                Console.WriteLine("ups, hubo un error!!" + ex.Message);
            }
        }

        static void juegoAnimales()
        {
            Console.WriteLine("Juguemos a adivinar animales");
            Boolean otroJuego = true;
            AdivinaAnimal juego = new AdivinaAnimal();

            do
            {
                juego.jugar();
                Console.WriteLine("Jugamos otra vez?");
                otroJuego = juego.respuesta();

            } while (otroJuego);
        }


        static void Main(string[] args)
        {

            juegoAnimales();

        }
    }
    
}

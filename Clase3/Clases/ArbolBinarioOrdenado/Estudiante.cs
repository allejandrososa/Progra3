using System;
using System.Collections.Generic;
using System.Text;

namespace Clase3.Clases.ArbolBinarioOrdenado
{
    class Estudiante : Comparador
    {
        public int numMat;
        public string nombre;
        public bool igualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool mayorIgualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return numMat >= p2.numMat;
        }

        public bool mayorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return numMat > p2.numMat;
        }

        public bool menorIgualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return numMat <= p2.numMat;
        }

        public bool menorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return numMat < p2.numMat;
        }
    }
}

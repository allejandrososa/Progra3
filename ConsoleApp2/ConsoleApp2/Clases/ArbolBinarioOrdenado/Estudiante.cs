

/**
 *
 * @author Ruldin
 */
public class Estudiante : Comparador {

    public int numMat;
    public string nombre;

    public bool igualQue(object q)
    {
        return true;
    }

    public bool mayorIgualQue(object q)
    {
         Estudiante p2 = (Estudiante)q;
            return numMat>=p2.numMat;
    }

    public bool mayorQue(object q)
    {
         Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre)>0;
    }

    public bool menorIgualQue(object q)
    {
        throw new System.NotImplementedException();
    }

    public bool menorQue(object q) {
         Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre)<0;
    }

}

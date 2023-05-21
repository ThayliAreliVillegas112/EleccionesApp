using System;



public class Candidato{
        
    private string? nombre;
    public string? Nombre{
        get {return nombre;}
        set {nombre = value;}
    } 

    private int numVotos;
    public int NumVotos{
        get {return numVotos;}
        set {numVotos = value;}
    }

    public Candidato (string nombre){
        this.nombre = nombre;
        // this.numVotos = numVotos;
    }

    public Candidato (){
        
    }
}

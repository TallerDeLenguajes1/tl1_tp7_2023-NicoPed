namespace EspacioCalculadora;

public class Calculadora
{
    private double dato=0.0;
    public void Sumar(double termino){
        dato = dato + termino;
    }
    public void Restar(double termino){
        dato -= termino;
    }
    public void Multiplicar(double termino){
        dato *= termino;
    }
    public void Dividir(double termino){
        if(termino != 0){
            dato = dato/termino;
        }
    }
    public void Limpiar(){
        dato = 0.0;
    }
    public double resultado{
        // get => dato;
        get {
            return dato;
        } 
    }
}


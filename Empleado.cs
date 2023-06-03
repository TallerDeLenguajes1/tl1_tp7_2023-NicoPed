
enum cargos{
    Auxiliar = 0,
    Administracion = 1,
    Ingeniero = 2,
    Especialista = 3,
    Investigador = 4,
}
enum Genero{
    Masculino = 0,
    Femenino = 1,
}
public class Empleado{

private string Nombre;
private string Apellido;
private DateTime FechaDeNacimiento;
private char EstadoCivil;
private Genero GeneroPersona;
private DateTime FechaDeIngreso;
private double SueldoBasico;

public int Antiguedad(){
    DateTime Today = DateTime.Today;
    return(Today.Subtract(FechaDeIngreso).Days / 365);
}
public int Edad(){
    DateTime Today = DateTime.Today;
    return(Today.Subtract(FechaDeNacimiento).Days / 365);
}
public int FaltaParaJubibilarse(){
    if (GeneroPersona == Genero.Masculino)
    {
        return(65 - Edad());
    }else if(GeneroPersona == Genero.Femenino)
    {
        return(60 - Edad());
    }else
    {
        return (-9999);
    }
}
}
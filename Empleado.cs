
enum cargos{
    Auxiliar = 0,
    Administracion = 1,
    Ingeniero = 2,
    Especialista = 3,
    Investigador = 4,
}

public class Empleado{

private string nombre;
private string apellido;
private DateTime fechaDeNacimiento;
private char estadoCivil;
private char generoPersona;
private DateTime fechaDeIngreso;
private double sueldoBasico;
private cargos cargo;

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    public char EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char GeneroPersona { get => generoPersona; set => generoPersona = value; }
    public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    internal cargos Cargo { get => cargo; set => cargo = value; }
public Empleado(){
    
}
public int Antiguedad(){
    DateTime Today = DateTime.Today;
    return(Today.Subtract(FechaDeIngreso).Days / 365);
}
public int Edad(){
    DateTime Today = DateTime.Today;
    return(Today.Subtract(FechaDeNacimiento).Days / 365);
}
public int FaltaParaJubibilarse(){
    if (GeneroPersona == 'M' || GeneroPersona == 'm')
    {
        return(65 - Edad());
    }else if(GeneroPersona == 'F' || GeneroPersona == 'f')
    {
        return(60 - Edad());
    }else
    {
        return (-9999);
    }
}
}
namespace Empleados;
enum Cargos{
    Auxiliar = 0,
    Administracion = 1,
    Ingeniero = 2,
    Especialista = 3,
    Investigador = 4,
}
enum EstadosCiviles{
    Soltero = 0,
    Casado = 1,
    Viudo = 2,
    Separado = 3,
    Divorciado =4,
}
public class Empleado{

    private string? nombre;
    private string? apellido;
    private DateTime fechaDeNacimiento;
    private EstadosCiviles estadoCivil;
    private char genero;
    private DateTime fechaDeIngreso;
    private double sueldoBasico;
    private Cargos cargo;

    public string? Nombre { get => nombre; set => nombre = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
    internal EstadosCiviles EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public char Genero { get => genero; set => genero = value; }
    public DateTime FechaDeIngreso { get => fechaDeIngreso; set => fechaDeIngreso = value; }
    public double SueldoBasico
    {
        get { return sueldoBasico; }
        set
        {
            if (value >= 0)
            {
            sueldoBasico = value;
            }
        }
    }
    internal Cargos Cargo { get => cargo; set => cargo = value; }

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
        if (Genero == 'M' || Genero == 'm')
        {
            return(65 - Edad());
        }else
        {
            return(60 - Edad());
        }
    }
    public double CalcularAdicional(){
        double adicional = SueldoBasico;
        int antiguedad = Antiguedad();
        if (antiguedad < 20)
        {
            adicional = adicional * 0.01 * antiguedad ;
        }else
        {
            adicional = adicional*0.25;
        }
        if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional += adicional * 0.50;
        }
        if (EstadoCivil == EstadosCiviles.Casado)
        {
            adicional += 15000;
        }
        return adicional;
    }
    public double SalarioEmpleado(){
        return (sueldoBasico + CalcularAdicional());
    }
}
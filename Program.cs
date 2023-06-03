using System;
using Empleados;
internal class Program
{
    const int cantEmpleados = 3;
    private static void Main(string[] args){
        var Employers = new List<Empleado>();
        double SalariosTotales;
        CargarEmpleados(Employers);
        SalariosTotales = TotalDeSalarios(Employers);
        Console.WriteLine($"La Percepcion total de los salarios es: {SalariosTotales}");
        
    }
private static double TotalDeSalarios(List<Empleado> listaEmpleados){
    double total = 0.0;
    for (int i = 0; i < listaEmpleados.Count; i++)
    {
        total += listaEmpleados[i].SalarioEmpleado();
    }
    return total;
}
private static void CargarEmpleados(List<Empleado> listaEmpleados){

    for (int i = 0; i < cantEmpleados; i++)
    {
        var nuevoEmpleado = new Empleado();
        nuevoEmpleado = crearEmplado();
        listaEmpleados.Add(nuevoEmpleado);
    }
}
    private static Empleado crearEmplado(){
        string? buffer; 
        EstadosCiviles auxEstadoCivil;
        cargos auxCargos;
        DateTime auxFecha;
        char auxGenero;
        double auxSueldo;
        var nuevoEmpleado = new Empleado();
        Console.Write("Nombre: ");
        nuevoEmpleado.Nombre = Console.ReadLine();
        Console.Write("Apellido: ");
        nuevoEmpleado.Apellido = Console.ReadLine();
        
        do
        {
            Console.Write("Fecha de nacimiento: "); 
            buffer = Console.ReadLine();
        } while (!DateTime.TryParse(buffer,out auxFecha));
        nuevoEmpleado.FechaDeNacimiento = auxFecha;
        
        do
        {
            Console.WriteLine("Estado Civil: (La primera con mayusculas y en masculino)");
            buffer = Console.ReadLine();
        } while (!Enum.TryParse(buffer, out auxEstadoCivil));
        nuevoEmpleado.EstadoCivil = auxEstadoCivil;
        
        do
        {
            Console.Write("Género: ");
            auxGenero = Console.ReadKey().KeyChar; 
        } while (auxGenero != 'M' || auxGenero != 'm' ||auxGenero != 'F' ||auxGenero != 'f');
        nuevoEmpleado.Genero = auxGenero;
        
        do
        {
            Console.Write("Fecha de ingreso a la empresa: "); 
            buffer = Console.ReadLine();
        } while (!DateTime.TryParse(buffer,out auxFecha));
        nuevoEmpleado.FechaDeIngreso = auxFecha;

        do
        {
            Console.Write("Sueldo Basico: "); 
            buffer = Console.ReadLine();
        } while (!double.TryParse(buffer, out auxSueldo));
        nuevoEmpleado.SueldoBasico = auxSueldo;

        do
        {
            Console.WriteLine("Cargo: (La primera con mayusculas y en masculino)");
            buffer = Console.ReadLine();
        } while (!Enum.TryParse(buffer, out auxCargos));
        nuevoEmpleado.Cargo = auxCargos;
        return nuevoEmpleado;
    }
}
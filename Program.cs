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
        Console.WriteLine("============================================================");
        Console.WriteLine($"La Percepcion total de los salarios es: {SalariosTotales}");
        Console.WriteLine("============================================================");
        Console.WriteLine("==========================Jubilacion=========================");
        ElMasViejuno(Employers);
        Console.WriteLine("============================================================");

    }
private static void ElMasViejuno(List<Empleado> listaEmpleados){
    int indiceDelMayor = 0;
    int MasProximo = 999;
    for (int i = 0; i < listaEmpleados.Count; i++)
    {
        if (listaEmpleados[i].FaltaParaJubilarse() <= MasProximo)
        {
            indiceDelMayor = i;
            MasProximo = listaEmpleados[i].FaltaParaJubilarse();
        }
    }
    MostrarDatosDeEmpleado(listaEmpleados[indiceDelMayor]);
}
private static void MostrarDatosDeEmpleado(Empleado employer){
    Console.WriteLine("Nombre: "+ employer.Nombre);
    Console.WriteLine("Apellido: "+ employer.Apellido);
    Console.WriteLine("Fecha de Nacimiento: "+ employer.FechaDeNacimiento.ToShortDateString());
    Console.WriteLine("Estado Civil: "+ employer.EstadoCivil);
    Console.WriteLine("Género: "+ employer.Genero);
    Console.WriteLine("Fecha De Ingreso En La Empresa: "+ employer.FechaDeIngreso.ToShortDateString());
    Console.WriteLine("Sueldo Basico: "+ employer.SueldoBasico);
    Console.WriteLine("Cargo: "+ employer.Cargo);

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
        Console.WriteLine("===================");
        var nuevoEmpleado = new Empleado();
        nuevoEmpleado = crearEmpleado();
        listaEmpleados.Add(nuevoEmpleado);
        Console.WriteLine("===================");
    }
}
    private static Empleado crearEmpleado(){
        string? buffer; 
        EstadosCiviles auxEstadoCivil;
        Cargos auxCargos;
        DateTime auxFecha;
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
            Console.WriteLine("Género: ");
            buffer = Console.ReadLine();
        } while (buffer != "M" && buffer != "m" && buffer != "F" && buffer != "f");
        nuevoEmpleado.Genero = buffer.ToUpper()[0];
        
        do
        {
            Console.WriteLine("Fecha de ingreso a la empresa: "); 
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
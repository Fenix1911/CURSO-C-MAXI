namespace ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        int sueldo;
        int facturadoEmpleado;
        int comision;
        int sueldoFinal;

        sueldo = 15000;
        Console.WriteLine("Ingrese el monto facturado por el empleado:");
        facturadoEmpleado = int.Parse(Console.ReadLine());
        comision = (facturadoEmpleado * 5) / 100;
        sueldoFinal = sueldo + comision;
        Console.WriteLine("El sueldo final del empleado es: " + sueldoFinal);
    }
}

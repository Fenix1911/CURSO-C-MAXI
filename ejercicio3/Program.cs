namespace ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        int distaciaCiudades;
        int velocidad;
        int tiempoAproximado;

        Console.WriteLine("Ingrese la distancia entre las dos ciudades (en km): ");
        distaciaCiudades = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la velocidad promedio del vehiculo (en km/h): ");
        velocidad = int.Parse(Console.ReadLine());
        tiempoAproximado = distaciaCiudades / velocidad;
        Console.WriteLine($"El tiempo aproximado de viaje es: {tiempoAproximado} horas");
    }
}




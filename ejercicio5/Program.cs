namespace ejercicio5;

class Program
{
    static void Main(string[] args)
    {
        int nota1, nota2, nota3, promedio;

        Console.WriteLine("Ingrese la primera nota:");
        nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda nota:");
        nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la tercera nota:");
        nota3 = int.Parse(Console.ReadLine());
        promedio = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine($"El promedio de las notas es: {promedio}");
    }
}

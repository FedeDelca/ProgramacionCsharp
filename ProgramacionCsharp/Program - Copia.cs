internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hola Mundo!!");

        int a = 10;
        int b = 20;

        Console.WriteLine(a);
        Console.WriteLine(b);

        int suma = a + b;

        Console.WriteLine(suma);

        string cadena = "Esto es una cadena de caracteres";

        Console.WriteLine(cadena);
        string cadena2 = "Esto es una cadena con los numeros a y b";
        Console.WriteLine(cadena2);
        string cadena3 = $"Esto es una cadena con los numeros {a} y {b}";

        Console.WriteLine(cadena3);
        string cadena4 = string.Format("Esto es una cadena con los numeros {0} y {1}", a, b);
        Console.WriteLine(cadena4);
    }
}
class tutorial
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj wyrażenie liczby do mnożenia: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        a = a * b;
        Console.WriteLine("Wynik: "+a);
    }
}
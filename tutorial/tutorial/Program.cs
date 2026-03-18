
Console.WriteLine("Podaj wyrażenie liczby do mnożenia: ");

float a = float.Parse(Console.ReadLine());
float b = float.Parse(Console.ReadLine());
a = a * b;

Console.WriteLine("Wynik: " + a);

int CalculateAverage(int[] values) {
    int win = 0;
    foreach (int i in values)
    {
        win += i;
    }

    return win / values.Length;
}
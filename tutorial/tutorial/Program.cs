
Console.WriteLine("Podaj wyrażenie liczby do mnożenia: ");

float a = float.Parse(Console.ReadLine());
float b = float.Parse(Console.ReadLine());
a *= b;

Console.WriteLine("Wynik: " + a);

Console.WriteLine("avg test: "+CalculateAverage(new []{1, 2, 3, 4, 5, 6}));

int CalculateAverage(int[] values) {
    int win = 0;
    foreach (int i in values)
    {
        win += i;
    }

    return win / values.Length;
}
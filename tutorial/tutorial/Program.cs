
Console.WriteLine("Podaj wyrażenie liczby do mnożenia: ");

float a = float.Parse(Console.ReadLine());
float b = float.Parse(Console.ReadLine());
a *= b;

Console.WriteLine("Wynik: " + a);

Console.WriteLine("avg test: "+CalculateAverage(new []{1, 2, 3, 4, 5, 6}));
Console.WriteLine("avg test: "+CalculateMin(new []{-234, -4212345, -3145323, - 5678543, -8574634}));

int CalculateAverage(int[] values) {
    int win = 0;
    foreach (int i in values)
    {
        win += i;
    }

    return win / values.Length;
}

int CalculateMin(int[] values) {
    int tmp = int.MaxValue;
    foreach (int i in values)
    {
        if (tmp>i)
        {
            tmp = i;
        }
    }
    return tmp;
}
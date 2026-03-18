
Console.WriteLine(":) Początek kodu");

Console.WriteLine("avg test: "+CalculateAverage(new []{1, 2, 3, 4, 5, 6}));

int CalculateAverage(int[] values) {
    int win = 0;
    foreach (int i in values)
    {
        win += i;
    }

    return win / values.Length;
}
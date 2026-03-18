
Console.WriteLine(":) Początek kodu");

Console.WriteLine("avg test: "+CalculateAverage(new []{1, 2, 3, 4, 5, 6}));
Console.WriteLine("avg test: "+CalculateMin(new []{-234, -4212345, -3145323, - 5678543, -8574634}));

int CalculateAverage(int[] values) {
    var win = 0;
    foreach (var i in values)
    {
        win += i;
    }

    return win / values.Length;
}

int CalculateMin(int[] values) {
    var tmp = int.MaxValue;
    foreach (var i in values)
    {
        if (tmp>i)
        {
            tmp = i;
        }
    }
    return tmp;
}
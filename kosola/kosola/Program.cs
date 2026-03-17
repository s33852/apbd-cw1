
Console.WriteLine("second line");
Console.WriteLine("new line");

int CalculateAverage(int[] values)
    {
    int sum = 0;

    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return sum/values.Length;
}

int CalculateMax(int[] values)
{
    return 1;
}

int CalculateMin(int[] values)
{
    {  return 0; }
}

Console.WriteLine("change");
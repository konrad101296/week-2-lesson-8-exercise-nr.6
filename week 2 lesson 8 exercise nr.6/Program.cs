double numerator = 1;
double fraction;
double sum = 0;
for (int i = 1; i <= 20; i++)
{
    fraction = numerator / i;
    sum += fraction;
}
Console.WriteLine($"result {sum}");
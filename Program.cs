double n;
double i = 2;

Console.WriteLine("Введите число n");
n = Convert.ToDouble(Console.ReadLine());

while (i <= n)
{
    if (i % 2 == 0)
        {
        Console.WriteLine(i);
        }

    i = i + 1;
}


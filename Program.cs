
//1 . программа, которая на вход принимает два числа и выдает max и min
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    int max = a;
    int min = b;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}
else if (a < b)
{
    int max = b;
    int min = a;
    Console.Write("max = ");
    Console.WriteLine(max);
    Console.Write("min = ");
    Console.WriteLine(min);
}


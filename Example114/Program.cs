Console.Write("Введите число для проверки кратности: ");
int num1 = int.Parse (Console.ReadLine());
Console.Write("Введите первое число для сравнения: ");
int even1 = int.Parse (Console.ReadLine());
Console.Write("Введите второе число для сравнения: ");
int even2 = int.Parse (Console.ReadLine());

if (num1 % even1 == 0 && num1 % even2 == 0)
{
    Console.WriteLine(num1 + " - является кратным" + " " + even1 + " и " + even2);
}
else
{
    Console.WriteLine(num1 + " - не является кратным" + " " + even1 + " и " + even2);
}


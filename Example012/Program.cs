Console.WriteLine("Write namber");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Write namber2");
int number2 = int.Parse(Console.ReadLine());
if(number2 * number2 == number)
{
  Console.Write($"{number} является квадратом {number2} ");
}
if(number * number == number2)
{
  Console.Write($"{number2} является квадратом {number}" );
}
else
{
  Console.Write($"{number} не является квадратом {number2} как и {number2} не является квадратом {number} ");    
}

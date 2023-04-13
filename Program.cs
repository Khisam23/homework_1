// Console.WriteLine("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());

// if (a > b){
//   System.Console.WriteLine("MAX = " + a);
//   System.Console.WriteLine("MIN = " + b);
// } else {
//   System.Console.WriteLine("MAX = " + b);
//   System.Console.WriteLine("MIN = " + a);
// }


Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите первое число: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите первое число: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c){
  System.Console.WriteLine($"Максимальное число: {a}");
} 
else if (b > a && b > c){
  System.Console.WriteLine($"Максимальное число: {b}");
}
else
{
  System.Console.WriteLine($"Максимальное число: {c}");
}
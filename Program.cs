Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b){
  System.Console.WriteLine("MAX = " + a);
  System.Console.WriteLine("MIN = " + b);
} else {
  System.Console.WriteLine("MAX = " + b);
  System.Console.WriteLine("MIN = " + a);
}
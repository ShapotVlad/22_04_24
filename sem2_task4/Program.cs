//Программа выводит третью цифру слева
//если  третьей цифры нет, пишет - третьей цифры нет
//456 => 6
//5846 => 4
//94 => третьей цифры нет



Console.WriteLine("ввод числа");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100  ||  num <= -100)
{

while (num > 999  || num < -999)
{
  num = num/10;  
}
int result = num % 10;

Console.WriteLine($"Третья цифра слева = {result}");
}

else
{
    Console.WriteLine("Третьей цифры нет.");
}

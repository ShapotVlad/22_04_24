//Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
//Примеры
//a = 256 => 26
//a = 891 => 81


Console.WriteLine("ввод трехзначного числа");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstdigit = num / 100;
    int thiddigit = num % 10;

    int result = firstdigit * 10 + thiddigit;

    Console.WriteLine($"вывод результата = {result}");
}
else
{
    Console.WriteLine("Ошибка! Число не трехзначное.");
}






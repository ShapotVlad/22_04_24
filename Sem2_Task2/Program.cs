// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень,
//  равную третьей цифре.
//   Примеры
//    487 => 8^7 = 2 097 152
//    254 => 5^4 = 625 
//    617 =>  


Console.WriteLine("ввод трехзначного числа");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int seconddigit = num / 10 % 10;
    int exponent = num % 10;
    int result = 1;
    int i = 0;

    while (i < exponent)
    {
        result = result * seconddigit;
        i = i + 1;
    }

    Console.WriteLine($"вывод результата = {result}");
}
else
{
    Console.WriteLine("Ошибка! Число не трехзначное.");
}


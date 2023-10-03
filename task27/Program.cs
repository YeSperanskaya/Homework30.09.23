// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfNumber (int num)
{
    int sum = 0;
    while(num != 0)
    {
        int numRemainder = num % 10;
        sum = sum + numRemainder;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if  (number < 0)
// { 
//     Console.WriteLine("Некорректный ввод");
//     return;
// }

int sumOfNumber = SumOfNumber(number);
Console.WriteLine($"{number} -> {sumOfNumber}");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Exponentiation (int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++ )
    {
        checked
        {
            result = result * num1;
        }
        
    } 
    return result;
} 

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if  (number1 < 1 | number1 < 1)
{ 
    Console.WriteLine("Некорректный ввод");
    return;
}

int resultExponent = Exponentiation(number1, number2);
Console.WriteLine($"{number1}, {number2} -> {resultExponent}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//Ограничения:
//- Должна быть отдельная функция, которая возвращает результат суммы цифр
//- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

double SUMM(int number)
{
    double result = 0;
    while(number > 0)
    {
        result = result + number%10;
        number = number/10;
    }
   return result;
}
double res = SUMM(number);
Console.WriteLine(res);

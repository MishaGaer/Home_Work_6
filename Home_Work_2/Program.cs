/*Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/
//Контроль ввода
int InputControl(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число. Пожалуйста введите корректное значение.");
        }
    }
}
//Поиск точки пересечения
void SearchIntersection(decimal k1, decimal b1, decimal k2, decimal b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые заданы одним и тем же уравнением.");
    }
    else
    {
        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны.");
        }
        else
        {
            decimal x = -((b1 - b2) / (k1 - k2));
            if (k1 * x + b1 == k2 * x + b2)
            {
                Console.WriteLine($"Прямые пересекаются в точке ({x};{k2 * x + b2}).");
            }
            else
            {
                Console.WriteLine("Прямые не пересекаются.");
            }
        }
    }
}
//Основной код
decimal k1 = InputControl("Введите значение k1 что бы задать прямые y = k1 * x + b1, y = k2 * x + b2");
decimal b1 = InputControl($"Введите значение b1 что бы задать прямые y = {k1} * x + b1, y = k2 * x + b2");
decimal k2 = InputControl($"Введите значение k2 что бы задать прямые y = {k1} * x + {b1}, y = k2 * x + b2");
decimal b2 = InputControl($"Введите значение b2 что бы задать прямые y = {k1} * x + {b1}, y = {k2} * x + b2");
Console.WriteLine($"Прямые будут задаваться уравнениями - y = {k1} * x + {b1}, y = {k2} * x + {b2}");
SearchIntersection(k1, b1, k2, b2);


/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
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
//заполнение массива с клавиатуры
void FillArray(int[] array)
{
    int index = 0;
    while (index < array.Length)
    {
        while (true)
        {
            Console.WriteLine($"Введите значение в {index + 1}-й элемент массива. Осталось заполнить {array.Length - index} элементов.");
            if (int.TryParse(Console.ReadLine(), out array[index]))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы ввели не число. Пожалуйста введите корректное значение.");
            }
        }
        index++;
    }
}
//печать массива с проверкой положительных
void PrintArray(int[] array)
{
    int positivSum = 0;
    int position = 0;
    while (position < array.Length)
    {
        Console.Write($"{array[position]}, ");
        if (array[position] > 0)
        {
            positivSum += 1;
        }
        position++;
    }
    Console.Write("\b");
    Console.Write("\b");
    Console.WriteLine($" - в нём содержится {positivSum} значения больше нуля.");
}
//основной код
int length = InputControl("Введите размер массива");
int[] array = new int[Math.Abs(length)];
FillArray(array);
Console.WriteLine("Введенный Вами массив:");
PrintArray(array);
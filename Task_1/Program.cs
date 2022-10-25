/*Задача 41:
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int [] GetArrayFromConsole()
{
    Console.WriteLine("Введите числа через запятую:");
    int [] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
    return array;
}
int GetQuantityPositiveNumber (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count ++;
    }
    return count;
}
void PrintArray(int [] array)
{   
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] array = GetArrayFromConsole();
int positiveNumb = GetQuantityPositiveNumber(array);
PrintArray(array);
Console.Write($"-> Введено {positiveNumb} чисел больше 0");



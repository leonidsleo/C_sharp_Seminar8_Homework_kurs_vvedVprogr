//Семинар 8. Курс введ в программирование.
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void NewArray(int[,] array) //Метод создания массива, значение рандома задает клиент. 
{
    Console.Write("Создать массив из случайных чисел [мин, макс]. Введите минимальное значение = ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Создать массив из случайных чисел [мин, макс]. Введите масимальное значение = ");
    int max = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SearchStringSmallestSumOfNumbersTwoArray (int[,] array) // метод поиска суммы каждой строки двумерного массива 
                                                             // и нахождение наименьшей суммы и указывает какая это строка.
{
    int size = array.GetLength(0);
    int summ = 0;
    List<string> numbers = new List<string>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            summ = summ + array[i, j];
        }
        //Console.WriteLine(summ); // времянная проверка вывод всех сумм строк
        numbers.Add($"{summ}");
        summ = 0;
    }
    Console.WriteLine("Суммы строк:");
    Console.WriteLine(String.Join<string>(" ", numbers));
    int min = Convert.ToInt32(numbers[0]);
    int ind = 0;
    int str = 0;
    while (ind < numbers.Count)
    {
        if (min > Convert.ToInt32(numbers[ind]))
        {
            min = Convert.ToInt32(numbers[ind]);
            str = ind + 1;
        }
        ind++;
    }
    Console.WriteLine($"Наименьшая сумма = {min}, {str} строка.");
}

Console.Write("Введите количество строк двумерного массива =  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива =  ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
NewArray(array); // вызов метода создания массива
PrintArray(array);
SearchStringSmallestSumOfNumbersTwoArray (array);
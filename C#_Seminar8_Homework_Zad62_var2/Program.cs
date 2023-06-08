//Семинар 8. Курс введ в программирование.
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// вариант 2. Попробывать решить, что бы подходила для любого размера массива

void NewArray(int[,] array) // создать двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
        }
    }
}

void FillNumbersHelicallyArray2D(int[,] array) // метод заполнения значениями спирально двумерного массива
{
    Console.Write("Значение начала спирали =  ");
    int start = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    int j = 0;
    int n = 0;
    while (array[i, j] == 0)
    {
        if (array[i, j] == 0)
        {
            while (j < array.GetLength(1) - n)
            {
                array[i, j] = start;
                start = start + 1;
                j++;
            }
        }
        i++;
        j--;
        if (array[i, j] == 0)
        {
            while (i < array.GetLength(0) - n)
            {
                array[i, j] = start;
                start = start + 1;
                i++;
            }
        }
        i--;
        j--;
        if (array[i, j] == 0)
        {
            while (j >= array.GetLength(1) - array.GetLength(1) + n)
            {
                array[i, j] = start;
                start = start + 1;
                j--;
            }
        }
        i--;
        j++;
        if (array[i, j] == 0)
        {
            while (i > n)
            {
                array[i, j] = start;
                start = start + 1;
                i--;
            }
        }
        i++;
        j++;
        n++;
    }
}

void PrintArray(int[,] array) // метод вывода на печать дву мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}


Console.Write("Количество строк 2D массива =  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов 2D массива =  ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
NewArray(array);
// PrintArray(array); // заполненый нулями 2D массив
FillNumbersHelicallyArray2D(array);
PrintArray(array);
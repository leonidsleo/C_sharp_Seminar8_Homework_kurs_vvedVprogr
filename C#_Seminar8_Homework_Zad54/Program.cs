//Семинар 8. Курс введ в программирование.
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void NewArray(int[,] array) //Метод создания массива, значение рандома задает клиент. 
{
    Console.Write("Создать массив из случайных чисел [мин, макс]. Введите минимальное значение = ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Создать массив из случайных чисел [мин, макс]. Введите масимальное значение = ");
    int max = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // array[i] = new Random().Next(min, max);
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
void OrderElementsRowsArray(int[,] array) // метод упорядочивание по убыванию элементов в каждой строке
{
    int i2 = 0;
    int j2 = 0;
    // int max = array[i, a];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int a = 0; a < array.GetLength(1); a++)
        {
            int max = array[i, a];
            for (int j = a; j < array.GetLength(1); j++)
            {
                if (max < array[i, j])
                {
                    max = array[i, j];
                    i2 = i;
                    j2 = j;
                }
            }
            //Console.WriteLine(max);
            //Console.WriteLine($"I = {i2}, J = {j2}");
            array[i2, j2] = array[i, a];
            array[i, a] = max;
        }
    }

}

Console.Write("Введите количество строк двумерного массива =  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива =  ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
NewArray(array); // вызов метода создания массива
PrintArray(array);
OrderElementsRowsArray(array);
Console.WriteLine();
PrintArray(array);
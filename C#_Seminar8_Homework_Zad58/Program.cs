//Семинар 8. Курс введ в программирование.
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void NewArray(int[,] array) //Метод создания массива, значение рандома задает клиент. 
{
    Console.Write("Создать массив из случайных чисел [мин, макс]. Введите минимальное значение = ");
    int min = Convert.ToInt32(Console.ReadLine());
    //int min = EnterNumber();
    Console.Write("Создать массив из случайных чисел [мин, макс]. Введите масимальное значение = ");
    int max = Convert.ToInt32(Console.ReadLine());
    //int max = EnterNumber();
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

Console.Write("Введите количество строк строк матрицы 1 =  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 1 =  ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];

Console.Write("Введите количество строк матрицы 2 =  ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы 2 =  ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] array2 = new int[rows2, columns2];

NewArray(array); // вызов метода создания массива
NewArray(array2); // вызов метода создания массива
Console.WriteLine("Матрица 1:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Матрица 2:");
PrintArray(array2);
Console.WriteLine();

if (columns != rows2)
{
    Console.WriteLine("Найти произведение не возможно.");
}
else
{
    //int summ = 0;
    int[,] array3 = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                array3[i, j] += array[i, k] * array2 [k, j];
                //summ = summ + pro;
                
            }
            //array3[i, j] = summ;
            //Console.WriteLine(summ);
            //summ = 0;
        }
        
    }
    Console.WriteLine("Матрица 3. Произведение М1 * М2:");
    PrintArray(array3);
}
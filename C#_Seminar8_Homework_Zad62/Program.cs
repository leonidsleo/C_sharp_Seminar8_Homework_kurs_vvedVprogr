//Семинар 8. Курс введ в программирование.
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите значение начала спирали =  ");
int start = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[4, 4];
int i = 0;
int j = 0;
while (j < array.GetLength(1))
{
    array[i, j] = start;
    start = start + 1;
    j++;
}

i++;
j = array.GetLength(1) - 1;
while (i < array.GetLength(0))
{
    array[i, j] = start;
    start = start + 1;
    i++;
}

i = array.GetLength(0) - 1;
j = array.GetLength(1) - 2;
while (j >= 0)
{
    array[i, j] = start;
    start = start + 1;
    j--;
}

i = array.GetLength(0) - 2;
j = array.GetLength(1) - array.GetLength(1);
while (i > 0)
{
    array[i, j] = start;
    start = start + 1;
    i--;
}

i = array.GetLength(0) - array.GetLength(0) + 1;
j = array.GetLength(1) - array.GetLength(1) + 1;
while (j < array.GetLength(1) - 1)
{
    array[i, j] = start;
    start = start + 1;
    j++;
}

i = array.GetLength(0) - 2;
j = array.GetLength(1) - 2;
while (j >= array.GetLength(1) - array.GetLength(1) + 1)
{
    array[i, j] = start;
    start = start + 1;
    j--;
}

for (i = 0; i < array.GetLength(0); i++)
{
    for (j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]:D2} ");
    }
    Console.WriteLine();
}
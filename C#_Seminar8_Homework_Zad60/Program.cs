// Семинар 8. Курс введ в программирование.
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int EnterNumber() // метод для ввода числа, значения 
{
    //Console.Write("Введите число = ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void NewArray(int[,,] array) //Метод создания массива, значение рандома задает клиент. 
{
    Console.Write("Введите минимальное значение Random = ");
    int min = EnterNumber();
    Console.Write("Введите максимальное значение Random = ");
    int max = EnterNumber();
    int num;
    if (((max - min) - 1) > (array.GetLength(0) * array.GetLength(1) * array.GetLength(2)))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int n = 0; n < array.GetLength(2); n++)
                {
                    num = new Random().Next(min, max);
                    for (int i2 = 0; i2 < array.GetLength(0); i2++)
                    {
                        for (int j2 = 0; j2 < array.GetLength(1); j2++)
                        {
                            for (int n2 = 0; n2 < array.GetLength(2); n2++)
                            {
                                if (array[i2, j2, n2] == num)
                                {
                                    num = new Random().Next(min, max);
                                    i2 = 0;
                                    j2 = 0;
                                    n2 = 0;

                                }
                            }
                        }
                    }
                    array[i, j, n] = num;
                }
                
            }

        }

    }
    else
    {
        Console.WriteLine("Размер массива больше диапозона выбора чисел. Повторите ввод.");
    }
    
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write(" ");
                Console.Write($"{array[i, j, n]}({i}, {j}, {n})");

            }
            Console.WriteLine();

        }
    }
    

}

Console.Write("Введите X массива =  ");
int rows = EnterNumber();
Console.Write("Введите Y массива =  ");
int columns = EnterNumber();
Console.Write("Введите Z массива =  ");
int three = EnterNumber();
int[,,] array = new int[rows, columns, three];
NewArray(array);
Console.WriteLine();
PrintArray(array);
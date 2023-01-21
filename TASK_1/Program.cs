/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

int [,] matrix = new int[4, 4];

// вывод результата
void Task()
{
FillArray(matrix);
System.Console.WriteLine();
PrintArrai(matrix);
System.Console.WriteLine();
NumberRowMinSumElements(matrix);
}

// печать массива
void PrintArrai(int[,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        System.Console.Write($"{matr[ i, j ]} ");
    }
System.Console.WriteLine();
}
}
// Заполнения массива рандомно числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0, 100)/10;
        }
    }
}

//вывода номера строки (не индекса строки) с наименьшей суммой элементов 
void NumberRowMinSumElements(int[,] array)
{
int minLine = 0;
int minSumLine = 0;
int sumLine = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minLine = minLine + matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        sumLine = sumLine + matrix[i, j];
        sumLine++;
        if (sumLine < minLine)
        {
            minLine = sumLine;
            minSumLine = i;
        }
        sumLine = 0;
    }
    
    Console.Write($"{minSumLine + 1} строка");
}



Task();
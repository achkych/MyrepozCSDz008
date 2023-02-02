/*
//z0.Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
int[,] array = new int[rows, colums];

for(int i =0; i< rows; i++)
      for(int j =0; j< colums; j++)
         array[i,j] = new Random().Next(minValue, maxValue + 1);

return array;
   
}

void Show2dArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0); i++)
   {
     for(int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + "\t");

     Console.WriteLine();
   }
   Console.WriteLine();
}

void ChangeRows(int[,] array, int r1, int r2)
{
    if(r1 >= 0 && r1 < array.GetLength(0) &&
     r2 >= 0 && r2 < array.GetLength(0) &&
     r1 != r2)
     {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           int temp = array[r1, j];
           array[r1, j] = array[r2, j];
           array[r2, j] = temp;

        }
     }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2dArray(newArray);

Console.Write("Input a number of rows1: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of rows2: ");
int row2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray, row1, row2);
Show2dArray(newArray);
*/
/*
//z1.Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min number: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max number: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//rows indexes
    {
        for (int j = 0; j < array.GetLength(1); j++)//columns indexes
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Reverse2dArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Not Square Array");
        return;
    }
    else
    {
        for (int i = 0; i < array.GetLength(0) - 1 ; i++)
            for (int j = i+1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;                
            }
    }
}
int[,] array = CreateRandom2dArray();
Console.Clear();
Show2dArray(array);
Reverse2dArray(array);
Show2dArray(array);
*/
/*
//z2.Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min number: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max number: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)//rows indexes
    {
        for (int j = 0; j < array.GetLength(1); j++)//columns indexes
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[] MinArrayIndex(int[,] array)
{
    int[] indexes = new int[2];//index of row and index of column with MIN value
    indexes[0] = 0;
    indexes[1] = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[indexes[0], indexes[1]])
            {
                indexes[0] = i;
                indexes[1] = j;
            }
    return indexes;
}
int[,] RemoveMinIndexes(int[] indexes, int[,] array)
{
    int[,] resarray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int i2 = 0;
    int j2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != indexes[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
                if (j != indexes[1])
                {
                    resarray[i2, j2] = array[i, j];
                    j2++;
                }
            j2 = 0;
            i2++;
        }
    }
    return resarray;
}
int[,] array = CreateRandom2dArray();
Show2dArray(array);
int[] indexes = MinArrayIndex(array);
int[,] array2 = RemoveMinIndexes(indexes, array);
Console.WriteLine($"MIN = [{indexes[0]} : {indexes[1]}] = {array[indexes[0], indexes[1]]}");
Show2dArray(array2);
*/

/*
//z54.Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}
void ArrayToDescen(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}
Console.Clear();

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(array);
Console.WriteLine();
ArrayToDescen(array);
Show2dArray(array);
*/
/*
//z56.Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}
void NumRowMinSumElmnts(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} row");
    Console.WriteLine();
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(array);
NumRowMinSumElmnts(array);
*/
/*
//z60. Nesmog(.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
int[,,] array3D = new int[2, 2, 2];
Set3dArray(array3D);
Show3dArray(array3D);
// Функция заполнения 3D массива не повторяющимеся числами
void Set3dArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[k, i, j] += count;
                count += 3;
            }
        }
    }
}
// Функция вывода индекса элементов 3D массива
void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}
Console.WriteLine();
*/

/*
//z58.Nesmog. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int rows = ReadInt("Input a number of rows: ");
int columns = ReadInt("Input a number of columns: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

CreateRandom2dArray(array);
Show2dArray(array);

Console.WriteLine();

CreateRandom2dArray(secondArray);
Show2dArray(secondArray);

Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Nevozmojno peremnojit ");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}

Show2dArray(resultArray);

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция заполнения массива случайными числами от 1 до 9
void CreateRandom2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}


void Show2dArray(int[,] array)
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
*/

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int InputNumber(string message)
{
    System.Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void FillArray2D(int[,] array2D)
{
    Random rnd = new Random();

    for(int i = 0; i<array2D.GetLength(0); i++)
    {
        for(int j = 0; j<array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(0,10);
        }
    }
}
void PrintArray2D(int[,] array2D)
{
    for(int i = 0; i<array2D.GetLength(0); i++)
    {
        for(int j = 0; j<array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void SortArray2D(int[,] array2D)
{
    for(int i = 0; i<array2D.GetLength(0); i++)
    {
        for(int j = 0; j<array2D.GetLength(1)-1; j++)
        {
            for(int n = j+1; n<array2D.GetLength(1); n++)
            {
                if(array2D[i,j]<array2D[i,n])
                    {
                        int temp = array2D[i,n];
                        array2D[i,n] = array2D[i,j];
                        array2D[i,j] = temp;
                    }
            }
        }
    }
}

int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");
int[,] array2D = new int[rows, columns];
FillArray2D(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();
SortArray2D(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();
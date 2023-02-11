// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputNumber(string message)
{
    System.Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void FillArray(int[,] array)
{
    Random rnd = new Random();

    for(int i = 0; i<array.GetLength(0); i++) 
    {
        for(int j = 0; j<array.GetLength(1); j++) 
        {
            array[i, j] = Convert.ToInt32(rnd.Next(0, 4));
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++) 
    {
        for(int j = 0; j<array.GetLength(1); j++) 
           {
             System.Console.Write(string.Format ("{0, 5}", array[i, j]));
           }
        System.Console.WriteLine();
    }
}
void MultiplicationMatrix(int[,] array1, int[,] array2)
{
    if(array1.GetLength(1) != array2.GetLength(0))
    {
        System.Console.WriteLine("Две матрицы невозможно перемножить");
        return;
    }
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for(int j = 0; j<newArray.GetLength(1); j++)
    {
        for(int i = 0; i<newArray.GetLength(1); i++)
        {
            for(int k = 0; k<array1.GetLength(1)-1; k++)
            {
                newArray[i,j] += array1[i,k]*array2[k,j];
            }
        }
    }
    System.Console.WriteLine("Новая матрица: ");
    PrintArray(newArray);
}
int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");
int[,] array1 = new int[rows, columns];
FillArray(array1);
PrintArray(array1);
System.Console.WriteLine();
int[,] array2 = new int[rows, columns];
FillArray(array2);
PrintArray(array2);
MultiplicationMatrix(array1, array2);
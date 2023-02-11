// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
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
            array2D[i, j] = Convert.ToInt32(rnd.Next(0, 10));
        }
    }
}

void PrintArray2D(int[,] array2D)
{
    for(int i = 0; i<array2D.GetLength(0); i++) 
    {
        for(int j = 0; j<array2D.GetLength(1); j++) 
           {
             System.Console.Write(string.Format ("{0, 5}", array2D[i, j]));
           }
        System.Console.WriteLine();
    }
}
int MinSummElementsRow(int[,] array2D)
{
    int[] array = new int[array2D.GetLength(0)];

    for(int i = 0; i<array2D.GetLength(0); i++) 
    {
        int summ = 0;
        for(var j = 0; j<array2D.GetLength(1); j++) 
        {
          summ += array2D[i,j]; // Элементы каждой строки складываем.
        }
        System.Console.WriteLine("Сумма элементов " + (i+1) +" строки равна: " + summ);

        array[i] = summ; //  Создали одномерный массив в виде сумм каждой строки.            
    }

    int min = array[0];
    for(int i = 1; i<=array.Length-1; i++)
    {  
        if(array[i]<min)
        {
            min = array[i];            
        }        
    }    
    return min;    
}


int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");
int[,] array2D = new int[rows, columns];
FillArray2D(array2D);
PrintArray2D(array2D);
System.Console.WriteLine();
int minSummElementsRow = MinSummElementsRow(array2D);
System.Console.WriteLine("Наименьшей суммой строки массива равно: " + minSummElementsRow);

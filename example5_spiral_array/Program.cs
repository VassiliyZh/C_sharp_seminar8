// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int InputNumber(string message)
{
    System.Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void FillArraySpirally(int[,] array)
{
    int digit = 1;
    int length = array.GetLength(1);
    int width = array.GetLength(0);

    for(int i = 0; i < width; i++) 
    {
        for (int j = i; j < length; j++)  // Заполняем двигаясь вправо;
        {
            array[i, j] = digit;
            digit++;
        }
        for (int k = i + 1, j = length-1; k < width; k++) //Заполняем двигаясь вниз
        {
            if(array[k,j]==0) //Проверяем есть ли внизу значения
            {
                array[k,j] = digit;
                digit++;
            }
            else return;
        }
        length--;
        for(int k = width - 1, j = length-1; j >= 0+i; j--) //Заполняем двигаясь влево
        {
            if(array[k,j]==0) //Проверяем есть ли внизу значения
            {
                array[k,j] = digit;
                digit++;
            }
            else return;
        }
        width--;
        for (int k = width - 1, j = 0 + i; k > i; k--) //Заполняем двигаясь вверх
        {
            if(array[k,j]==0) //Проверяем есть ли вверху значения
            {
                array[k,j] = digit;
                digit++;
            }
            else return;
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++) 
    {
        for(int j = 0; j<array.GetLength(1); j++) 
        {
            if(array[i,j]<10)
                System.Console.Write(string.Format ("{0, 5}", "0" + array[i, j] + " "));
            else 
                System.Console.Write(string.Format ("{0, 5}", array[i, j] + " "));
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");
int[,] array = new int[rows, columns];
FillArraySpirally(array);
PrintArray(array);

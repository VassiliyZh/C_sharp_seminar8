// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputNumber(string message)
{
    System.Console.Write(message + ": ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void FillArrayWithRandomNumbers(int[] array)
{
    
    Random rnd = new Random();
    array[0] = rnd.Next(10,100);
    for(int i = 0; i<array.Length; i++) 
    {
        array[i] = rnd.Next(10,100); 
        for(int j = 0; j<i; j++)
        {
            while (array[i]==array[j])
            { 
                array[i] = rnd.Next(10,100);
                j = 0;
            }
        }
    }
}
void FillArray(int[,,] array)
{
    int[] NumbersToFillArray = new int[array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];
    FillArrayWithRandomNumbers(NumbersToFillArray);
    System.Console.WriteLine("Числа для заполнения массива: " + string.Join (", ", NumbersToFillArray) + "\n");
    int count = 0;
    int number = NumbersToFillArray[count];
    for(int k = 0; k<array.GetLength(2); k++) 
    {
        for(int i = 0; i<array.GetLength(0); i++) 
        {
            for(int j = 0; j<array.GetLength(1); j++) 
            {    
                array[i, j, k] = number;
                count++;
                if(count==NumbersToFillArray.Length) return;
                number = NumbersToFillArray[count];
            }
        }
    }
}
void PrintArray(int[,,] array)
{
    for(int k = 0; k<array.GetLength(2); k++) 
    {
        for(int i = 0; i<array.GetLength(0); i++) 
           {
             for(int j = 0; j<array.GetLength(1); j++) 
                {
                    System.Console.Write(string.Format ("{0, 13}", array[i, j, k] + $"{(i, j, k)}" + " "));
                }
                System.Console.WriteLine();
           }        
    }
}

int rows = InputNumber("Введите количество строк массива");
int columns = InputNumber("Введите количество столбцов массива");
int depth = InputNumber("Введите количество глубины массива");
int[,,] array = new int[rows, columns, depth];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

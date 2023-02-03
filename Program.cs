// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int row = new Random().Next(2,5);;
int col = new Random().Next(2,10);;
int[,] array = new int[row,col];
NewArray(array);
WriteArray(array);
SortArray(array);
Console.WriteLine();
WriteArray(array);
void NewArray (int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = new Random().Next(1,100);
        }   
    }
}
void WriteArray (int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void SortArray(int[,] array)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int p = 0; p < col-1; p++)
            {
                if (array[i, p] < array[i,p + 1])
                {
                    int d = array[i,p + 1];
                    array[i,p + 1] = array[i, p];
                    array[i, p] = d;
                }
            }
        }
    }   
}
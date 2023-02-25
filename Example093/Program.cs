// Задача 93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] firstArray = Random2DArray(5,5);
int[,] secondArray = Random2DArray(5,5);
int[,] resultArray = new int[5,5];
for(int i = 0;i<resultArray.GetLength(0);i++)
{
    for(int j = 0; j<resultArray.GetLength(1);j++)
    {
        for (int k = 0; k < secondArray.GetLength(0); k++)
	{
            resultArray[i,j] += firstArray[i,k]*secondArray[k,j];
	}
	System.Console.Write($"{resultArray[i,j]} "); 
    }
    System.Console.WriteLine();
}







int[,] Random2DArray(int row,int col)
{
    int[,] array2D = new int[row,col];
    Random rand = new Random();
    for(int i = 0; i<row;i++)
    {
        for(int j = 0; j<col;j++)
            array2D[i,j] = rand.Next(1,10);
    }
    return array2D;
}

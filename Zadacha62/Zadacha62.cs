/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
System.Console.WriteLine("Enter number of rows: "); 
int M = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter number of columns: "); 
int N = Int32.Parse(System.Console.ReadLine());
int [,] Matrix= Get2DArray(M,N);
Print2DArray (Matrix);

int [,] Get2DArray(int M,int N)
{
    int[,] Array2D = new int [M,N];
    Array2D[0,0]=1;
    int i=0;
    int j=0;
    while (i-1>=0 && i<Array2D.GetLength(0) &&Array2D[i-1,j]==0)
    {
     Array2D[i-1,j]=Array2D[i,j]+1;
     i++;
     System.Console.WriteLine("прошел1");
    }
    while (j+1<Array2D.GetLength(1) &&Array2D[i,j+1]==0)
    {
     Array2D[i,j+1]= Array2D[i,j]+1;
     j++;
     System.Console.WriteLine("прошел2");
    }
    return Array2D;
}

/*int [,] Get2DArray (int M, int N)
{
int[,] Array2D = new int [M,N];
int i=0;
    for (int j=0; j<Array2D.GetLength(1); j++)
    {
      Array2D[i,j]= Array2D[i,j]+1;
    }//это заполнение строки 0 слева направо
Array2D[i+1,j]=Array2D[i,j];
    for (i++; i<Array2D.GetLength(1); i++)
    {
      Array2D[i,j]= Array2D[i,j]+1;
    } //это заполнение столбца 3 сверху вниз, начиная со строки 1
Array2D[i,j-1]=Array2D[i,j]+1;
    for (j++; j>=0; j=j-1)
    {
        Array2D[i,j]= Array2D[i,j]+1;
    } //это заполнение строки 4 справа налево, начиная со столбца 2
Array2D[i+1,j+1]=Array2D[i,j]+1;
}
 return Array2D;*/


void Print2DArray (int [,] Matrix)
{
for (int i=0; i<Matrix.GetLength(0); i++)
 {
    for (int j=0; j<Matrix.GetLength(1); j++)
    {
      System.Console.Write($"{Matrix[i,j]} ");
    }
    System.Console.WriteLine();
 }
}
/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
/*План действий:
1. создание массива размера м на н, 
который будет заполняться целыми числами по порядку, начиная с 0
2. поменять ему порядок перебора ячеек так, чтобы все время 
"сворачивал направо" и каждый раз делал всего шагов на 1 шаг меньше,
чем до поворота*/
System.Console.WriteLine("Enter number of rows: "); 
int M = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter number of columns: "); 
int N = Int32.Parse(System.Console.ReadLine());
int [,] Matrix= Get2DArray(M,N);
Print2DArray (Matrix);

int [,] Get2DArray (int M, int N)
{
int[,] Array2D = new int [M,N];
Array2D[0,0]=0;
int count=1;
for (int i=0; i<Array2D.GetLength(0); i++)
 {
    for (int j=0; j<Array2D.GetLength(1); j++)
    {
      Array2D[i,j]= Array2D[i,j]+count;
      count++;
    }
 }
 return Array2D;
}

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
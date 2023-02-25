/*Задача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами*/
System.Console.WriteLine("Enter number of rows: "); 
int M = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter number of columns: "); 
int N = Int32.Parse(System.Console.ReadLine());
double [,] Matrix= Get2DArrayofRealNumbers(M,N);
Print2DArray (Matrix);

double [,] Get2DArrayofRealNumbers (int M, int N)
{
double[,] Array2D = new double [M,N];
Random rand=new Random();
for (int i=0; i<Array2D.GetLength(0); i++)
 {
    for (int j=0; j<Array2D.GetLength(1); j++)
    {
      Array2D[i,j]= rand.NextDouble()*15;
    }
 }
 return Array2D;
}

void Print2DArray (double [,] Matrix)
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

/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.*/
System.Console.WriteLine("Enter number of rows: "); 
int M = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter number of columns: "); 
int N = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter maximal number: "); 
int MaxValue = Int32.Parse(System.Console.ReadLine());
System.Console.WriteLine("Enter minimal number: "); 
int MinValue = Int32.Parse(System.Console.ReadLine());
int [,] Matrix= Get2DArray(M,N,MaxValue,MinValue);
Print2DArray (Matrix); //вывод массива для проверки
System.Console.WriteLine(); //пустая строка чтоб легче читалась консоль
double [] MeansOfColumns= GetTheMeansOfColumnsIn2DArray(Matrix);
MassiveAsString (MeansOfColumns); //вывод средних по столбцам

double [] GetTheMeansOfColumnsIn2DArray (int [,] Matrix)
{
 double [] MeansOfColumnsIn2DArray = new double [Matrix.GetLength(1)];
 int SumOfElementsInColumn=0;
 for (int j=0; j<Matrix.GetLength(1);)
    {
     for (int i=0; i<Matrix.GetLength(0); i++)
      {
       SumOfElementsInColumn=SumOfElementsInColumn+Matrix[i,j];
      }
    double temp=SumOfElementsInColumn;
     MeansOfColumnsIn2DArray[j]=temp/Matrix.GetLength(1);
     SumOfElementsInColumn=0;
     j++;
    }
 return MeansOfColumnsIn2DArray;
}

int [,] Get2DArray (int M, int N, int MaxValue, int MinValue)
{
int[,] Array2D = new int [M,N];
for (int i=0; i<Array2D.GetLength(0); i++)
 {
    for (int j=0; j<Array2D.GetLength(1); j++)
    {
      Array2D[i,j]= new Random().Next(MinValue, MaxValue+1);
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

void MassiveAsString (double [] MeansOfColumns)
{
    string ArrayAsString = string.Join(" , ", MeansOfColumns); 
    System.Console.WriteLine(ArrayAsString);
}
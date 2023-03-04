int rows = new Random().Next(1,6);
int cols = new Random().Next(1,6);
int [,] GetMatrix (int rows, int cols, int minValue, int maxValue)
{
  int[,] matrix = new int [rows,cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      matrix[i,j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return matrix;
}
void PrintMatrix(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int cols = matrix.GetLength(1);
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
  }
}
int[,] array2D = GetMatrix(rows, cols, 0, 100);
PrintMatrix(array2D);
Console.Write("Введите номер строки: ");
int numberRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int numberCols = Convert.ToInt32(Console.ReadLine());
if (numberRows > rows | numberCols > cols )
{
  Console.Write($"Элемент с номером строки {numberRows} и столбцом {numberCols} НЕ СУЩЕСТВУЕТ! ");
}
else
{
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
      if (array2D[i,j] == array2D[numberRows,numberCols])
      {
        Console.Write($"Элемент с номером строки {numberRows} и столбцом {numberCols} - это {array2D[i,j]} ");
      }
    }
  }
}
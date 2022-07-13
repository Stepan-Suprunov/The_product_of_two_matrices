// Задать две матрицы. Найти их произведение.


void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void Product(int[,] collection, int[,] collection2)
{
    int[,] result = new int[collection.GetLength(0), collection2.GetLength(1)];
    int product = 0;
    for (int i = 0; i == 0; i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            product += collection[i,j] * collection2[j,i];
        }
    }
    result[0,0] = product;

    product = 0;
    for (int i = 0; i == 0; i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            product += collection[i,j] * collection2[j,i+1];
        }
    }
    result[0,1] = product;

    product = 0;
    for (int i = 1; i == 1; i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            product += collection[i,j] * collection2[j,i-1];
        }
    }
    result[1,0] = product;

    product = 0;
    for (int i = 1; i == 1; i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            product += collection[i,j] * collection2[j,i];
        }
    }
    result[1,1] = product;

    PrintArray(result);
}

int[,] matrix1 = new int[2,3];
int[,] matrix2 = new int[3,2];

FillArray(matrix1);
FillArray(matrix2);
PrintArray(matrix1);
Console.WriteLine("----------");
PrintArray(matrix2);
Console.WriteLine("----------");
Product(matrix1,matrix2);
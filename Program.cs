int size = 5;
int[] arrNum = new int[size];
int min = 0;
int max = 10;
int sumNegative = 0;
Random rnd = new Random();

for (int i = 0; i < arrNum.Length; i++)
{
    arrNum[i] = rnd.Next(min,max);
}
PrintArray(arrNum);

for(int i = 0; i < arrNum.Length; i++)
{
    if(i%2 == 0)
        sumNegative+= arrNum[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях  {sumNegative}");

// Functions
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


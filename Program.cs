int size = 5;
int[] arrNum = new int[size];
int min = 0;
int max = 10;
int sumNegativePos = 0;
Random rnd = new Random();

for (int i = 0; i < arrNum.Length; i++)
{
    arrNum[i] = rnd.Next(min,max);
}
PrintArray(arrNum);

for(int i = 1; i < arrNum.Length; i+=2)
{
    sumNegativePos+= arrNum[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях  {sumNegativePos}");

// Functions
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


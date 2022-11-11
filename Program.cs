int size = 15;
int[] arrNum = new int[size];
int min = 0;
int max = 200;
int sumNegative = 0;
Random rnd = new Random();

for (int i = 0; i < arrNum.Length; i++)
{
    arrNum[i] = rnd.Next(min,max);
}
PrintArray(arrNum);

for(int i = 0; i < arrNum.Length; i++)
{
    if(arrNum[i]%2 == 0)
     sumNegative++;
}
Console.WriteLine($"Количество четных чисел  {sumNegative}");

// Functions
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


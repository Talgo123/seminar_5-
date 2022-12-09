int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1); // от минуса 9 до 10 (10 не включается)
    }
    return arr;
}

int size = 123;
int leftRange = 1;
int rightRange = 1000;

int[] array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join(",", array) + ']');
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
    {
        sum++;
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"[{string.Join(",", array)}] -> {sum}");

// Напишите программу замены элементов массива: положительные элементы замените на отрицательные, и наоборот

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

int[] array = new int[6];

array = FillArrayWithRandomNumbers(6, -9, 9);
System.Console.WriteLine('[' + string.Join(",", array) + ']');

for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
}
System.Console.WriteLine('[' + string.Join(",", array) + ']');


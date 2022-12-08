//Демонстрация решения
// Здайте массив из 12 элементов, заполненный случайными числами от -9 до 9.
// Найдите сумму положительных и отрицательных элементов массива.


const int SIZE = 12;
const int LEFT_RANGE = -9;
const int RIGHT_RANGE = 9;

int[] array = new int[SIZE];
int sumPositive = 0;
int sumNegative = 0;

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

array = FillArrayWithRandomNumbers(SIZE, LEFT_RANGE, RIGHT_RANGE);
System.Console.WriteLine('[' + string.Join(",", array) + ']');

void sumPositiveAndNegative(int[] arr, out int sumP, out int sumN)
{
    sumP = 0;
    sumN = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumP+=arr[i]; // sumPositive = sumPositive + array[i]
        }
        else
        {
            sumN+=arr[i];
        }
    }
}

sumPositiveAndNegative(array, out int sumP, out int sumN);
System.Console.WriteLine($"Сумма положительных элементов = { sumP}. Сумма отрицательных элементов = {sumN}");

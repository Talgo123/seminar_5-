// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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


void TrueFalse(int[] arr, int digit)
{
    bool res = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == digit)
        {
            res = true;
        }
    }
    if (res)
    {
        System.Console.WriteLine("yes");
    }
    else
    {
        System.Console.WriteLine("no");
    }
}

int[] array = new int[6];

array = FillArrayWithRandomNumbers(6, 1, 9);
System.Console.WriteLine('[' + string.Join(",", array) + ']'); // выводит массив

System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

 TrueFalse(array, number);
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int leftRang = 1;
int rightRang = 10;
int[]array = FillArrayWithRandomNumbers(size, leftRang, rightRang);

int[]newArray = new int [size / 2 + size % 2];
int i = 0;
for (i = 0; i < size / 2; i++)
{
    newArray[i] = array[i] * array[array.Length -1 - i];
}
if (array.Length % 2 != 0)
{
    newArray[newArray.Length -1] += array[array.Length % 2 +1];
}
System.Console.WriteLine('[' + string.Join(",", array) + ']');
System.Console.WriteLine('[' + string.Join(" ", newArray) + ']');
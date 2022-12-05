// Задать массив из 12 элементов (случайные числа от -9 до 9)
// Найти сумму отрицательных и положительных чисел элемнтов массива

void FillArray(int[] fill)
{
    int length = fill.Length;
    int index = 0;
    for (index = 0; index < fill.Length; index++)
    {
        fill[index] = new Random().Next(-9,10);    
    }
}

void printArr (int[] print)
{
    int length = print.Length;
    int i = 0;
    string space = " ";
    Console.Write("Сгенерированный массив: ");
    for (i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + space);
    }
}

int[] myArr = new int[12];

FillArray(myArr);
printArr(myArr);

int N = 15; // колчество элементов массива

string[] SetArray(int Length)
{
    string[] array = new string[Length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива :  ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] array = SetArray(N);


Console.Write("Введите номер позиции (k): ");
int k = Convert.ToInt32(Console.ReadLine());
if (k >= 0 & k <= 12)
{
    Console.Write("Введите новое число (1/3) ");
    string new_el = Console.ReadLine();
    for (int i = array.Length - 1; i > k; i--)
    {
       array[i] = array[i-1];
    }
    array[k] = new_el;
    k += 1;

    Console.Write("Введите новое число (2/3) ");
    string new_el1 = Console.ReadLine();
    for (int i = array.Length - 1; i > k; i--)
    {
        array[i] = array[i - 1];
    }
    array[k] = new_el1 ;
    k += 1;
    Console.Write("Введите новое число (3/3) ");
    string new_el2 = Console.ReadLine();
    for (int i = array.Length - 1; i > k; i--)
    {
        array[i] = array[i - 1];
    }
    array[k] = new_el2;



    void PrintArray(string[] array)
    {
        Console.Write("Массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("“");
            Console.Write($"{array[i]}");
            Console.Write("” ");
        }
    }


    PrintArray(array);
}
else
{
    Console.Write("Введите корректное k (0<=k<=12) ");
}





// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[m];

void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine();
    }
}
string[] symbol(string[] stringArray)   //метод считает количество элементов с длиной менее 3-х символов включительно
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }
    string[] rezult = new string[n]; // формирует новый массив с количеством посчитанных элементов
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++) // заполнение нового массива элементами, удовлетворяющими условию
    {
        if (stringArray[i].Length <= 3)
        {
            rezult[j] = stringArray[i];
            j++;
        }
    }
    return rezult;
}

void printArray(string[] stringArray) // Функция выводит массив на печать
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"‘{stringArray[i]}’, ");
    }
    Console.Write("]");
}

array(stringArray);
printArray(symbol(stringArray));
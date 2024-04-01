// Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Генерация массива
string[] GenerateArray(int size) {
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        array[i]=Console.ReadLine()!;
    }
    return array;
}

// Основной код
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
string[] array = GenerateArray(size);
Console.Write("[“"+string.Join("”, “",array)+"”] → ");
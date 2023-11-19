// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] ArrayOfWords(string[] array) //метод  выбора элементов длина которых <= 3 символa.
{

    string[] NewWords = new string[11]; // Создаем новый массив

    int count = 0;                          // Создаем переменную для счетчика

    for (int i = 0; i < array.Length; i++)  // перебираем массив
    {
        if (array[i].Length <= 3)           // находим элементы длинной <=3
        {
            NewWords[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref NewWords, count); 
    return NewWords;
}

void PrintArray(string[] array)     //Вывод результата.
{
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}
//Создание и заполнение массива
string[] NewArray = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
// вывод результата
PrintArray(ArrayOfWords(NewArray));
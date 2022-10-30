
// ЗАДАЧА

// Написать программу которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется использование коллекций, лучше обойтись исключительно массивами.

// ПРИМЕРЫ

// ["hello", "2", "world", ":-)"]  ->  ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"]  ->  ["-2"]

// ["Russia", "Denmark", "Kazan"]  ->  [ ]


string[] firstArray = { "hello", "2", "world", ":-)" };
string[] secondArray = { "1234", "1567", "-2", "computer science" };
string[] thirdArray = { "Russia", "Denmark", "Kazan" };



// Шаг 1 Метод 1 - пишем функцию преобразования массива в строку.

string OriginalArrayToString(string[] array)
{
    string txt = "[\"";
    
    for (int i = 0; i < array.Length; i++)
    {
        txt += array[i];
        txt += i != array.Length - 1 ? "\", \"" : "\"]";
    }
    return txt;
}
string txt = OriginalArrayToString(thirdArray);

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


// Шаг 2 Метод 2 - пишем функцию выборки элементов массива, длина которых не превышает 3 символа (включительно) и преобразования их в строку.


string SelectedArrayToString(string[] array)
{
    string textSorted = "[";

    for (int i = 0; i < array.Length; i++)
        
        if (array[i].Length == 1)
        {
            textSorted += "\"" + array[i] + "\",";
            
        }
        
            else if (array[i].Length <=3)
            { 
                textSorted += "\"" + array[i]+ "\"";
                
            }
        textSorted += "]";
    
    return textSorted;
}

string textSorted = SelectedArrayToString(thirdArray);
System.Console.WriteLine($"Наш первоначальный массив: {txt}   ->   {textSorted} отсортировынный массив элементов длиной от 0 до 3 символов");


// Шаг 3 Метод 3 - преобразовывем полученный выборкой массив строк в новый массив


string[] newArrayString = textSorted.Split(' ', ' ');
foreach(var arrNew in newArrayString)
{
    System.Console.WriteLine($"Финальный массив из строк выглядит так: newArrayString = {arrNew}");
}
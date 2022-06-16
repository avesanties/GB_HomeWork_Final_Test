/* Описание задачи.
**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

string ShowArray(string[] array){
    string result = string.Empty;
    
    result += "[";
    for(int i = 0; i < array.Length; i++)
        if(!(array[i] is null)) result += ($"\"{array[i]}\", ");
    
    result += "]";
    return result.Replace(", ]","]");
}

string[] FindSubArray(string[] array){
    string[] resultArray = new string[array.Length];
    int symbolsLimit = 3;
    for(int i = 0; i < array.Length; i++){
        if(array[i].Length <= symbolsLimit)
            resultArray[i] = array[i];
    }

    return resultArray;
}

//string[] stringArr = {"hello", "2", "world", ":-)"};
//string[] stringArr = {"1234", "1567", "-2", "computer science"};
//string[] stringArr = {"Russia", "Denmark", "Kazan"};
string[] stringArr = {"Russia", "", "Kazan"};
//string[] stringArr = {"", "", ""};
//string[] stringArr = {};

Console.WriteLine($"{ShowArray(stringArr)} -> {ShowArray(FindSubArray(stringArr))}");
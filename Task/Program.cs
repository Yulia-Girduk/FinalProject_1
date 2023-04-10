// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Вывод сообщения для пользователя.
string Prompt(string message)
{
    Console.Write(message);
    string result = Console.ReadLine();
    return result;
}

// Генерация массива строк пользователем через ввод данных.
string[] GenerateArray(int arrayLength)
{
    string[] array = new string[arrayLength];

    for (int i = 0; i < array.Length; i++)
    {
       array[i] = Prompt($"Введите значение {i} элемента массива: ");
    }
    return array;
}

// Вывод массива.
void PrintArray(string[] array)
{
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

// Получаем массив из элементов заданного массива, длина которых меньше или равна 3.
string[] GetArrayElementsLengthLessOrEqualToThree(string[] array)
{
    string[] newArray = new string[1];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.WriteLine($"j = {j}");
            if (j!=0)
            {
                int resizeArray = newArray.Length + 1;
               Array.Resize(ref newArray, resizeArray); 
            }

            newArray[j] = array[i];
            Console.WriteLine($"newArray[{j}] = {newArray[j]}");
            j++;
        }
    }
    return newArray;

}



int arrayLength = int.Parse(Prompt("Введите длину массива: "));
string[] arrayGiven = GenerateArray(arrayLength);

PrintArray(arrayGiven);

string[] arrayElementsLengthLessOrEqualToThree = GetArrayElementsLengthLessOrEqualToThree(arrayGiven);

PrintArray(arrayElementsLengthLessOrEqualToThree);

// Написать программу, которая из имеющегося массива строк формирует
// новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

string[] FindElements(string[] array)
{
    string[] result = new string[0];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[j] = array[i];
            j = j + 1;
        }
    }
    return result;
}
Console.Write("Введите значения массива разделив их запятой и пробелом: ");
string text = Console.ReadLine() ?? String.Empty;
string[] textArray = text.Split(", ");
string[] resultArray = FindElements(textArray);
Console.WriteLine($"[{String.Join(", ", resultArray)}]");
Console.Clear(); // Очищаем консоль

// Функция формирует новый массив со строками, длина которых не превышает 3х символов
string[] NewArray(string[] array)
{
    // определяем кол-во элементов нового массива
    int ArrayItem = 0;
    string[] ArrayNew = new string[ArrayItem];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            ArrayItem++;
            Array.Resize(ref ArrayNew, ArrayItem);
            ArrayNew[ArrayItem - 1] = array[i];
        }

    }

    return ArrayNew;

}

int number;
string input;
while (true) // Бесконечный цикл
{
    Console.Write("Введите количество строк для ввода от 1 до 10: ");
    input = Console.ReadLine()!; // Чтение строки ввода пользователя

    if (int.TryParse(input, out number))
    {
        if (number > 0 && number < 11)
        {
            Console.WriteLine($"Число строк: {number}");
            break;
        }
        else Console.WriteLine("Веденное число не лежит в диапазоне от 1 до 10!");

    }
}

string[] InputArray = new string[number];

for (int i = 0; i < number; i++) //Заполняем массив строк
{

    Console.WriteLine($"Введите строку {i + 1}:");
    while (true)
    {
        input = Console.ReadLine()!;
        if (input != "")
        {
            InputArray[i] = input;
            break;
        }
        else Console.WriteLine("Строка пустая, введите строку!");
    }
}
Console.WriteLine($"Вы ввели массив из строк: [{string.Join("; ", InputArray)}]");
// Выводим итоговый массив
Console.WriteLine($"Итоговый массив: [{string.Join("; ", NewArray(InputArray))}]");



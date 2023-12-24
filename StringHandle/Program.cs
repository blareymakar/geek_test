Console.Clear(); // Очищаем консоль

int number;
while (true) // Бесконечный цикл
{
    Console.Write("Введите количество строк для ввода от 1 до 10: ");
    string input = Console.ReadLine()!; // Чтение строки ввода пользователя
    
    if (int.TryParse(input, out number))
    {
        if (number>0&&number<11) 
        {Console.WriteLine($"Введено число {number}");
        break;
        }
        else Console.WriteLine("Веденное число не лежит в диапазоне от 1 до 10!");

    }
}

string[] InputArray = new string[number];

for (int i = 0; i < number; i++) //Заполняем массив строк
{

    Console.WriteLine($"Введите строку:{i + 1}");
    InputArray[i] = Console.ReadLine()!;
}
Console.WriteLine($"Задан массив[{string.Join("; ", InputArray)}]");

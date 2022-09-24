// SЗадача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2       1, -7, 567, 89, 223 -> 4
string NumberString = ReadInt("Введите числа через запятую: ");
int count = 0;
string temp = string.Empty;

for (int i = 0; i < NumberString.Length; i++)
{
    if (NumberString[i] != ',')
    {
        temp += NumberString[i];
    }
    else
    {
        if (Convert.ToInt32(temp) > 0)
        {
            count++;
        }
        temp = string.Empty;
    }
}

if (Convert.ToInt32(temp) > 0)
{
    count++;
}

Console.WriteLine($"{count} Чисел больше 0");

string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

// Написать программу, которая из сформированного массива
// строк, содержащих символы и числа, создаст массив из строк,
// в который попадут только символы, не являющиеся цифрами.
// Входные данные - путем ввода с клавиатуры.

// 1. Получаем входные данные, конвертируем в массив символов

Console.WriteLine("Введите нескольких символов, в т.ч. чисел, через пробел: ");
string line = Console.ReadLine();
char[] symbols = line.ToCharArray();
// Console.WriteLine(symbols);

// 2. Находим количество цифр в заданном пользователем массиве
int AmountNumbers(char[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= '0' && array[i] <= '0')
        {
            sum = sum + 1;
        }
    }
    return sum;
}

// Метод создания и заполнения нового массива без цифр

char[] FinalMethod(char[] symbols)
{
    int count = symbols.Length - AmountNumbers(symbols);
    char[] newArray = new char[count];
    int pos = 0;
    int size = symbols.Length;
    for (int i = 0; i < size; i++)
    {
        if (symbols[i] > '9')
        {
            newArray[pos] = symbols[i];
            pos++;
        }
    }
    return newArray;
}

char[] result = FinalMethod(symbols);

Console.WriteLine("Новый массив без цифр: ");
Console.WriteLine(result);

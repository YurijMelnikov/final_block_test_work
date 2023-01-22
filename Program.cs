/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами*/


string[] StringGeneretion(string[] array) // Метод, по заполнению массива случайными строками, длиной от 1 до 8 символов, созданными из случайных заглавных букв английского алфавита
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        int stringlen = rand.Next(1, 9);
        int randValue; 
        string str = "";
        char letter;
        for (int j = 0; j < stringlen; j++)
        {
            randValue = rand.Next(0, 26);
            letter = Convert.ToChar(randValue + 65);
            str = str + letter;
        }
        array[i] = str;
    }
    return array;
}

string[] StringSort(string[] array) // Метод сортировки строк массива, длина которых равна или меньше 3 символов. И запись этих строк в новый массив
{
    int lengthOfStringSort = 0;
    for (int i = 0; i < array.Length; i++) //вычисление длины массива, в который будут записываться строки, длина которых равна или меньше 3 символов
    {
        if (array[i].Length <= 3)
        {
            lengthOfStringSort++;
        }
    }
    int counter = 0;
    string[] sortedArray = new string[lengthOfStringSort];
    for (int i = 0; i < array.Length; i++) //запись значений в новый массив, counter - счётчик индекса нового массива
    {

        if (array[i].Length <= 3)
        {
            sortedArray[counter] = array[i];
            counter++;
        }
    }
    return sortedArray;
}

void PrintArray(string[] arbitraryArray)
{
    Console.Write("[");
    for (int i = 0; i < arbitraryArray.Length; i++)
        if (i != arbitraryArray.Length - 1)
        {
            {
                Console.Write($"{arbitraryArray[i]}, ");

            }
        }
        else
        {
            Console.Write($"{arbitraryArray[i]}]\n");
        }
}

Console.WriteLine("Введите количество строк в массиве");
int count = int.Parse(Console.ReadLine());
string[] stringsArray = new string[count];
StringGeneretion(stringsArray);
Console.WriteLine("Вывод массива со сгенерированными случайными строками длиной от 1 до 8 символов заглавных букв английского алфавита");
PrintArray(stringsArray);
string[] sortedArray = StringSort(stringsArray);
if (sortedArray.Length == 0)
{
    Console.WriteLine("В массиве нет строк длиной 3 и меньше символов");
}
else
{
    Console.WriteLine("Вывод массива созданного из строк, длиной 3 и меньше, первичного массива");
    PrintArray(sortedArray);
}
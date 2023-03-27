// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.





int InputInt(string message)                                                //Название метода ввода
{
    System.Console.Write($"{message}->");                                   //Вывод приглашения квводу
    int value;                                                              //Инициализация переменной

    if (int.TryParse(Console.ReadLine(), out value))                        //Условия корректности ввода + ввод со строки
    {                                                                       //если конвертация прошла правильно, то мы попадаем в ветку               
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);                                                    //Возвращаемся в систему (выход из программы) с кодом ошибки(1)
    return 0;                                                               //Для копиляции
}

string[] FillArray(int quantity)                                            //Название метода заполнения массива
{
    string[] array = new string[quantity];                                  //создание нового массива
    string[] elem = { "world", "2", "hello", "geekBrains", "543",           //массив с элементами
                    "73565", "15", "Moscow", "425672765", "disigne",
                    "gim", "metr", "net", "da", "43", "master", "tor", 
                    "Russia", "784", "rubeg"};

    Random rnd = new Random();                                              //заполнение массива array рандомными элементами
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = elem[rnd.Next(0, 20)];
    }
    return array;
}

string[] Array3Simbols(string[] array)                                      //Название метода поиска элементов с 3 символами и меньше
{
    string[] secondArray = new string[array.Length];                        //Новый массив
    int count = 0;                                                          //Счетчик количества элементов нового массива
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            secondArray[j] = array[i];                                       //Заполнение массива элементами с 3 символами и меньше
            j++;
            count++;
        }
    }
    Array.Resize(ref secondArray, count);                                    //Изменение размера массива под фактическое количество элементов
    return secondArray;
}

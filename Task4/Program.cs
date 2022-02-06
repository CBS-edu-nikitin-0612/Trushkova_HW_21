// See https://aka.ms/new-console-template for more information
using Task4; //без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");
int length = 10;

//Создание коллекции из рандомных чисел
MyList<int> myList = new MyList<int>(length);

Random random = new Random();

for (int i = 0; i < myList.Count; i++)
{
    myList[i] = random.Next(1, 100);
}

//Вывод на экран нашей коллекции
Console.WriteLine($"Массив {myList.GetType()}");
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i].ToString());
}

//Перевод коллекции в формат массива array и вывод на экран
int[] arrayList = myList.GetArray();
Console.WriteLine($"Массив {arrayList.GetType()}");
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i].ToString());
}
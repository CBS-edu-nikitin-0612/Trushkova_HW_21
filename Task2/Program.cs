// See https://aka.ms/new-console-template for more information
using Task2; //без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");

//Создание коллекции из рандомных целых чисел
int length = 10;
MyList<int> myList = new MyList<int>(length);

Random random = new Random();

for (int i = 0; i < myList.Count; i++)
{
    myList[i] = random.Next(1, 100);
}

//Добавление нового элемента в коллекцию
int addNum = 0;
myList.Add(addNum);

//Вывод на экран количества элементов в коллекции
Console.WriteLine(myList.Count);

//Вывод на экран всей коллекции
for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i].ToString());
}
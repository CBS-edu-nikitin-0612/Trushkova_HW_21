// See https://aka.ms/new-console-template for more information
using Task2;

Console.WriteLine("Hello, Teacher!");
int length = 10;
MyList<int> myList = new MyList<int>(length);

Random random = new Random();

for (int i = 0; i < myList.Count; i++)
{
    myList[i] = random.Next(1, 100);
}
int addNum = 0;
myList.Add(addNum);

Console.WriteLine(myList.Count);

for (int i = 0; i < myList.Count; i++)
{
    Console.WriteLine(myList[i].ToString());
}
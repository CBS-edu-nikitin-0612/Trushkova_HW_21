// See https://aka.ms/new-console-template for more information
using Task3;

Console.WriteLine("Hello, Teacher!");

MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
myDictionary.Add("книга", "book");
myDictionary.Add("ручка", "pen");
myDictionary.Add("солнце", "sun");
myDictionary.Add("яблоко", "apple");
myDictionary.Add("стол", "table");

try
{
    Console.WriteLine(myDictionary.Count);
    string word = "солнце";
    Console.WriteLine($"Слово {word} по-английски будет {myDictionary[word]}");
    word = "ручка";
    Console.WriteLine($"Слово {word} по-английски будет {myDictionary[word]}");
    word = "кучка";
    Console.WriteLine($"Слово {word} по-английски будет {myDictionary[word]}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}
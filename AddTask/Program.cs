// See https://aka.ms/new-console-template for more information
using AddTask; //без явного указания не работает программа, тк не видит другие классы

Console.WriteLine("Hello, Teacher!");

//Создание и вывод на экран переменной по умолчанию типа int
int variable1 = MyClass<int>.FacrotyMethod();
Console.WriteLine("int " + variable1);

//Создание и вывод на экран переменной по умолчанию типа decimal
decimal variable3 = MyClass<decimal>.FacrotyMethod();
Console.WriteLine("decimal " + variable3);

//Создание и вывод на экран переменной по умолчанию типа bool
bool variable4 = MyClass<bool>.FacrotyMethod();
Console.WriteLine("bool " + variable4);


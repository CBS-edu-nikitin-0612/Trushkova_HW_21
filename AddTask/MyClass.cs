namespace AddTask
{
    internal class MyClass<T> where T : new()
    {
        //Фабричный метод для создания экземпляра по умолчанию класса Т
        public static T FactoryMethod() => new T();       
    }
}

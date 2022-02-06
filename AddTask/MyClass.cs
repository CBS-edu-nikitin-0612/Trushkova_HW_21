namespace AddTask
{
    internal class MyClass<T>
    {
        //Фабричный метод для создания экземпляра по умолчанию класса Т
        public static T? FacrotyMethod()
        {
            T? variable = default;
            return variable;
        }
    }
}

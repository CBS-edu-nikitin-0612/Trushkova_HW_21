namespace Task4
{
    internal static class MyListExtension
    {
        //Расширяющий метод. Переводит коллекцию в формат массив array
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] array = new T[list.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }
}

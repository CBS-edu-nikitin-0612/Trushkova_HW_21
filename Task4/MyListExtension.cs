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
        
        //Вывод на экран коллекции
        public static void Show<T>(this MyList<T> list)
        {
            if (list != null)
            {                
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]?.ToString());
                }
            }
        }

        //Вывод на экран массива
        public static void ShowArray<T>(this T[] array)
        {
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]?.ToString());
                }
            }
        }
    }
}

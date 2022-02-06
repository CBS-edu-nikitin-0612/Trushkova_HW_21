namespace Task4
{
    internal class MyList<T>
    {
        private T[] _arrayT;

        public MyList(int Length)
        {
            _arrayT = new T[Length];
        }

        //Индексатор
        public T this[int index]
        {
            get { return _arrayT[index]; }
            set { _arrayT[index] = value; }
        }

        //Размер коллекции
        public int Count
        {
            get { return _arrayT.Length; }
        }

        //Добавление элемента
        public void Add(T element)
        {
            _arrayT = _arrayT.Append(element).ToArray();
        }  
    }
}

namespace Task2
{
    internal class MyList<T>
    {
        private T[] arrayT;

        public MyList(int Length)
        {
            arrayT = new T[Length];
        }

        public T this[int index]
        {
            get { return arrayT[index]; }
            set { arrayT[index] = value; }
        }

        public int Count
        {
            get { return arrayT.Length; }
        }

        public void Add(T element)
        {
            arrayT = arrayT.Append(element).ToArray();
        }        
    }
}

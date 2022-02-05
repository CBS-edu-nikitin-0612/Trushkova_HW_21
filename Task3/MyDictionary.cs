namespace Task3
{
    internal class MyDictionary<TKey, TValue>
    {
        private TKey[] _arrayTKeys;
        private TValue[] _arrayTValues;

        public MyDictionary()
        {
            _arrayTKeys = new TKey[] { };
            _arrayTValues = new TValue[] { };
        }

        public void Add(TKey tkey, TValue tvalue)
        {
            _arrayTKeys = _arrayTKeys.Append(tkey).ToArray();
            _arrayTValues = _arrayTValues.Append(tvalue).ToArray();
        }

        public int Count
               => _arrayTKeys.Length;

        public TValue this[TKey key]
        {
            get
            {
                if (_arrayTKeys.Contains(key))
                    return _arrayTValues[IndexOf(key)];
                else
                    throw new Exception("Нет такого слова");
            }
        }

        private int IndexOf(TKey key)
        {
            int i = 0;
            for (int j = 0; j < _arrayTKeys?.Length; j++)      
                if (_arrayTKeys[j].Equals(key))
                    return j;
            return i;
        }
    }
}

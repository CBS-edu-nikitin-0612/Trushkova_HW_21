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

        //Добавление одной пары слов
        public void Add(TKey tkey, TValue tvalue)
        {
            _arrayTKeys = _arrayTKeys.Append(tkey).ToArray();
            _arrayTValues = _arrayTValues.Append(tvalue).ToArray();
        }

        //Размер словаря
        public int Count
               => _arrayTKeys.Length;

        //Индексатор по ключевому слову TKey
        public TValue this[TKey key]
        {
            get
            {
                if (_arrayTKeys.Contains(key))
                {
                    int index = IndexOf(key, _arrayTKeys);
                    if (index < _arrayTValues.Length)
                        return _arrayTValues[index];
                    else
                        throw new Exception("Нет такого слова в словаре");
                }
                else
                    throw new Exception("Нет такого слова в словаре");
            }
        }

        //Индексатор по порядковому номеру слова в словаре
        public (TKey, TValue) this[int index]
        {
            get
            {
                if (index >= 0 && index < _arrayTValues.Length)
                    return (_arrayTKeys[index], _arrayTValues[index]);
                else
                    throw new Exception("Нет такого слова в словаре");
            }
        }

        //Нахождение индекса для выбранного ключевого слова
        private int IndexOf(TKey key, TKey[] array)
        {
            int i = array.Length;

            for (int j = 0; j < array.Length; j++)
            {
                if (key != null && key.Equals(array[j]))
                    return j;
            }
            return i;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryDemo
{
    class MyDictionary<Key,Value>
    {
        Key[] keys; // Key tipinde keys adlı boş bir dizi oluşturduk.
        Value[] values; // Value tipinde values adlı boş bir dizi oluşturduk.

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempArrayK = keys; // dizi boyutunu artırınca elimizdeki elemanlar gitmesin diye referansımızı tuttuk.
            keys = new Key[keys.Length + 1];

            Value[] tempArrayV = values;// dizi boyutunu artırınca elimizdeki elemanlar gitmesin diye referansımızı tuttuk.
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempArrayK.Length; i++)
            {
                keys[i] = tempArrayK[i];
            }
            keys[keys.Length - 1] = key; // verilen değeri keys dizisinin sonuna ekledik.

            for (int i = 0; i < tempArrayV.Length; i++)
            {
                values[i] = tempArrayV[i];
            }
            values[values.Length - 1] = value; // verilen değeri values dizisinin sonuna ekledik.

            Console.WriteLine(key +" " + value + " :Başarıyla Eklendi!");

        }
    }
}

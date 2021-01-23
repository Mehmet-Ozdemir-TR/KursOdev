using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(12, "Mehmet");
            myDictionary.Add(16 , "Saliha");
        }
    }
}

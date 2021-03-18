using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary= new MyDictionary<int, string>();

            myDictionary.Add(5, "Metin");
            myDictionary.Add(6, "Sado");
            myDictionary.Add(7, "Tufan");
            myDictionary.Add(8, "Esref");
            myDictionary.Add(9, "Rahman");


            myDictionary.List();
            myDictionary.Find(8);
            myDictionary.Find(1);
        }
    }
}

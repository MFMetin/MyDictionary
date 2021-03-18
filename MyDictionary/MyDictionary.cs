using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] myKey;
        Tvalue[] myValue;
        Tkey[] temp1;
        Tvalue[] temp2;
        public MyDictionary()
        {
            myKey = new Tkey[0];
            myValue = new Tvalue[0];        
        }
        public void Add(Tkey x, Tvalue y )
        {
            temp1 = myKey;
            temp2 = myValue;

            myKey = new Tkey[myKey.Length + 1];
            myValue = new Tvalue[myValue.Length + 1];

            for(int i = 0; i < temp1.Length; i++)
            {
                myKey[i] = temp1[i];
                myValue[i] = temp2[i];            
            }
            myKey[myKey.Length - 1] = x;
            myValue[myValue.Length - 1] = y;
        }
        public void List()
        {
            for (int i = 0; i < myKey.Length; i++)
            {
                Console.WriteLine("Key : " + myKey[i]);
                Console.WriteLine("Value : " + myValue[i]);
            }      
        }
        public void Find(Tkey find)
        {
            bool isFind = false;
            
            for (int i = 0; i < myKey.Length; i++)
            {
                if (find.Equals(myKey[i]))
                {
                    isFind = true;
                    Console.WriteLine(myValue[i]);
                }
            }
            if (isFind!)
            {
                Console.WriteLine("Key does not exist.");
            }    
        }
    }
}

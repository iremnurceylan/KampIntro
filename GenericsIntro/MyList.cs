using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T elemen)
        {
            T[] geciciArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i <geciciArray.Length; i++)
            {
                items[i] = geciciArray[i];

            }

            items[items.Length - 1] = items;

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar4Gun
{
    class MyList<T>
    {
        T[] items;
        //contructor
        public MyList()  //ctor snippet
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizi
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; 
            }

            items[items.Length - 1] = item; 
        
        }
    }
}

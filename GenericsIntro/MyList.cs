using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  //T = Type'dan gelir. Kullanıcının vereceği tip anlamına gelir
    {
        T[] items;
        //constructor.(ctor +tab+tab ) class new dediğimiz anda otomatik çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) // T Kullanıcının vereceği değeri alır
        {
            T[] tempArray = items; //Geçici dizi oluşturduk. İtemsın referansını saklıyoruz
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //tempArray'da tuttuğumuz değerleri tekrar items'a attık
            }
            items[items.Length - 1] = item; // Son eklenen değeri ekledik
        }
        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}

using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
         
            myList.Add("Serhat");
            Console.WriteLine(myList.Length);

            myList.Add("Semih");
            Console.WriteLine(myList.Length);
            foreach (var item in myList.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

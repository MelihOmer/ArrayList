using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
           //System.Collections namespace
           ArrayList list = new ArrayList();
        //    list.Add("Ayşe");
        //    list.Add(2);
        //    list.Add(true);
        //    list.Add('A');

           //İçerisindeki Verilere erişim
           //System.Console.WriteLine(list[1]);

        //    foreach (var item in list)
        //    {
        //        System.Console.WriteLine(item);
        //    }
           //AddRange
           System.Console.WriteLine("*** AddRange ***");
           //string[] renkler = {"Kırmızı","Sarı","Yeşil"};
           List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
          // list.AddRange(renkler);
           list.AddRange(sayilar);
            foreach (var item in list)
           {
               System.Console.WriteLine(item);
           }

           //Sort
           System.Console.WriteLine("*** Sort ***");
           list.Sort();

           foreach (var item in list)
           {
               System.Console.WriteLine(item);
           }

           //Binary Seacrh
           System.Console.WriteLine("*** Binary Seacrh ***");
           System.Console.WriteLine(list.BinarySearch(9));

           //Reverse
           System.Console.WriteLine("*** Reverse ***");
           list.Reverse();
           foreach (var item in list)
           {
               System.Console.WriteLine(item);
           }
           //clear
           System.Console.WriteLine("*** Clear ***");
           list.Clear();
           foreach (var item in list)
           {
               System.Console.WriteLine(item);
           }

        }
    }
}

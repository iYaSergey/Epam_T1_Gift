using System;

namespace Gift
{
    class Program
    {
        static void Main(string[] args)
        {
            Gift gift = new Gift();
            gift.Add(new Cake("Cake",5.0,100,2));
            gift.Add(new Candy("Candy",2.5,25,10));
            gift.Add(new Gingerbread("Gingerbread",1.0,200,1));
            gift.Add(new Lollipop("Lollipop",7.5, 75,5));

            Console.WriteLine($"Total weight: {gift.GetTotalWeight()}\n");
            Console.WriteLine($"Unsorted:\n{gift}\n");
            gift.SortByName();
            Console.WriteLine($"Sorted by name:\n{gift}\n");
            gift.SortBySugar();
            Console.WriteLine($"Sorted by sugar amount:\n{gift}\n");
            gift.SortByWeight();
            Console.WriteLine($"Sorted by weight:\n{gift}\n");
            gift.SortByCount();
            Console.WriteLine($"Sorted by count:\n{gift}\n");
            Console.WriteLine("Sugar range from 2 to 6:");
            gift.FindBySugarRange(2, 6).ForEach(Console.WriteLine);
        }
    }
}

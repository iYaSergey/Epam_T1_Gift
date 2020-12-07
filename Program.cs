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

            Console.WriteLine($"Total weight: {gift.GetTotalWeight()}");
            Console.WriteLine(gift);
            gift.SortByName();
            Console.WriteLine(gift);
            gift.SortBySugar();
            Console.WriteLine(gift);
            gift.SortByWeight();
            Console.WriteLine(gift);
            gift.SortByCount();
            Console.WriteLine(gift);

            gift.FindBySugarRange(2, 6).ForEach(Console.WriteLine);
        }
    }
}

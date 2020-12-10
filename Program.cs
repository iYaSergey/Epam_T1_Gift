using System;
using Gift.Model.Sweets;
using Gift.Service;

namespace Gift
{
    class Program
    {
        static void Main(string[] args)
        {
            IGiftService giftService = new GiftService();

            Model.Gift gift = new Model.Gift();
            gift.Add(new Cake("Cake",5.0,100,2));
            gift.Add(new Candy("Candy",2.5,25,10));
            gift.Add(new Gingerbread("Gingerbread",1.0,200,1));
            gift.Add(new Lollipop("Lollipop",7.5, 75,5));

            Console.WriteLine($"Total weight: {giftService.GetTotalWeight(gift)}\n");
            Console.WriteLine($"Unsorted:\n{gift}\n");
            giftService.SortByName(gift);
            Console.WriteLine($"Sorted by name:\n{gift}\n");
            giftService.SortBySugar(gift);
            Console.WriteLine($"Sorted by sugar amount:\n{gift}\n");
            giftService.SortByWeight(gift);
            Console.WriteLine($"Sorted by weight:\n{gift}\n");
            giftService.SortByCount(gift);
            Console.WriteLine($"Sorted by count:\n{gift}\n");
            Console.WriteLine("Sugar range from 2 to 6:");
            giftService.FindBySugarRange(gift, 2, 6).ForEach(Console.WriteLine);
        }
    }
}

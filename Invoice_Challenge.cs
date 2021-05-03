using System;
using System.Collections.Generic;
using System.Linq;

namespace Invoice_Challenge
{
    class items
    {
        public string item;
        public int price;
        public items(string item , int price) {
            this.item = item;
            this.price = price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<items>();

            Console.WriteLine("Please select an item by writing the item number");

            Console.WriteLine("item 1 - price 20 SAR\n" +
                "item 2 - price 40 SAR\n" +
                "item 3 - price 300 SAR\n" +
                "item 4 - price 1000 SAR\n");
            
            for (int i = 0; i < 1;)
            {
                
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        items.Add(new items("item 1", 20));
                        Console.WriteLine("Added item 1 price 20 SAR");
                        break;
                    case 2:
                        items.Add(new items("item 2", 40));
                        Console.WriteLine("Added item 2 price 40 SAR");
                        break;
                    case 3:
                        items.Add(new items("item 3", 300));
                        Console.WriteLine("Added item 3 price 300 SAR");
                        break;
                    case 4:
                        items.Add(new items("item 4", 1000));
                        Console.WriteLine("Added item 4 price 1000 SAR");
                        break;

                    default:
                        Console.WriteLine("enter the right option");
                        break;
                }

                

                int PrintTotal = 0;
                foreach (var item in items)
                {
                    PrintTotal = PrintTotal + item.price;
                }

                //Console.WriteLine("Total Price : "+ PrintTotal+" SAR");

                double total = 0;
                Console.WriteLine("Your Items List :");
                int IDCount = 0;
                foreach (var item in items)
                {

                    total = total + item.price;
                    Console.WriteLine("item ID :" + IDCount + "     " + item.item + "      Price " + item.price);
                    IDCount++;
                }
                Console.WriteLine("total price is\t" + total);
                if (total>1000)
                {
                    Console.WriteLine("You got a discount 10%");
                    double discount = total * 0.10;
                    Console.WriteLine("discounted amount :"+ discount);
                    Console.WriteLine("total now is "+(total-discount));
                }

                Console.WriteLine("want to remove something?(1=YES || -1=NO)");

                int answer =Convert.ToInt32( Console.ReadLine());
                
                if (answer!=-1)
                {
                    Console.WriteLine("write down the item id");
                    int removeItemByID = Convert.ToInt32(Console.ReadLine());
                    items.RemoveAt(removeItemByID);
                }

                here:
                Console.WriteLine("press ( 0 ) to select again || press ( 1 ) to Exit");
                i = Convert.ToInt32(Console.ReadLine());
                if (i != 0 && i != 1)
                {
                    goto here;
                }
            }
            /*var result = from unitPrice in items
                         where unitPrice.price == 10
                         select unitPrice;*/
            
        }
    }
}

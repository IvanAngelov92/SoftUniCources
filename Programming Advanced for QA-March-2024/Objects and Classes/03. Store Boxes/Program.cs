using System;
using System.Collections.Generic;
using System.Linq;

class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Item(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal BoxPrice { get; set; }

    public Box(string serialNumber, Item item, int itemQuantity, decimal boxPrice)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        BoxPrice = boxPrice;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Box> boxes = new List<Box>();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] data = input.Split();
            string serialNumber = data[0];
            string itemName = data[1];
            int itemQuantity = int.Parse(data[2]);
            decimal itemPrice = decimal.Parse(data[3]);

            Item item = new Item(itemName, itemPrice);
            decimal boxPrice = itemQuantity * itemPrice;

            Box box = new Box(serialNumber, item, itemQuantity, boxPrice);
            boxes.Add(box);
        }

        var sortedBoxes = boxes.OrderByDescending(box => box.BoxPrice);

        foreach (var box in sortedBoxes)
        {
            Console.WriteLine($"{box.SerialNumber}");
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.BoxPrice:F2}");
        }
    }
}
using System;

class Program {
    static void Main() {
        int price;
        string productName;

        Console.Write("Name product: ");
        productName = Console.ReadLine();

        Console.Write("Price: ");
        price = int.Parse(Console.ReadLine());

        Console.WriteLine($"Vu vneslu product: {productName} for price {price} uah.");
    }
}
using System;
using System.Collections.Generic;
using Inventory_Management_System;




List<Retail_Store> inventory = new List<Retail_Store>();
Console.CursorVisible = false;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.Yellow;


while (true)
{
    Console.WriteLine();
    Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
    Console.WriteLine();
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("1. Add new item to inventory");
    Console.WriteLine("2. Update the item");
    Console.WriteLine("3. Display inventory");
    Console.WriteLine("4. Search item by name or ID");
    Console.WriteLine("5. Remove item from inventory");
    Console.WriteLine("6. Exit");
    Console.WriteLine();
    Console.WriteLine("------------------------------------------------------------");

    Console.Write("\nEnter choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (choice)
    {
        case 1:
            AddItem();
            Console.Clear();
            break;

        case 2:
            UpdateItem();
            break;

        case 3:
            DisplayInventory();
            break;

        case 4:
            Search_Item();
            break;

        case 5:
            Remove_Item();
            break;

        case 6:
            Console.WriteLine("\n           Thanks For Visiting Our Store!");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("\nInvalid choice. Please enter a number from 1 to 6.");
            break;
    }
}
void AddItem()
{
    Console.WriteLine();
    Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
    Console.WriteLine();
    Console.Write("\nEnter item name: ");
    string name = Console.ReadLine();

    Console.Write("Enter item quantity: ");
    int quantity = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter item price: ");
    double price = Convert.ToDouble(Console.ReadLine());

    inventory.Add(new Retail_Store(name, quantity, price));
    Console.WriteLine($"{name} has been added to the inventory.");
}

void UpdateItem()
{
    Console.WriteLine();
    Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
    Console.Write("\nEnter item name: ");
    string itemToUpdate = Console.ReadLine();
    Console.WriteLine();
    Console.WriteLine("1.Change The Quantity.");
    Console.WriteLine("2.Change The Price.");
    Console.WriteLine("3.Change Both Quantity and Price.");
    Console.WriteLine("4.Change All");
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Enter an option : ");
    int opt = int.Parse(Console.ReadLine());
    if (opt == 4)
    {
        Console.Write("\nEnter item new name: ");
        string newName = Console.ReadLine();

        Console.Write("Enter new quantity: ");
        int newQuantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter new Price: ");
        int newPrice = Convert.ToInt32(Console.ReadLine());

        foreach (Retail_Store item in inventory)
        {
            if (item.Name == itemToUpdate)
            {
                item.Name = newName;
                item.Quantity = newQuantity;
                item.Price = newPrice;
                Console.WriteLine($"{item.Name} has been updated.");
                break;
            }
        }
    }
    else if(opt == 1) 
    {
        Console.Write("Enter new quantity: ");
        int newQuantity = Convert.ToInt32(Console.ReadLine());
        foreach (Retail_Store item in inventory)
        {
            if (item.Name == itemToUpdate)
            {
                item.Quantity = newQuantity;
                Console.WriteLine($"{item.Name} has been updated.");
                break;
            }
        }
    }
    else if (opt == 2)
    {
        Console.Write("Enter new Price: ");
        int newPrice = Convert.ToInt32(Console.ReadLine());
        foreach (Retail_Store item in inventory)
        {
            if (item.Name == itemToUpdate)
            {
                item.Price = newPrice;
                Console.WriteLine($"{item.Name} has been updated.");
                break;
            }
        }
    }
    else if (opt == 3)
    {
        Console.Write("Enter new quantity: ");
        int newQuantity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter new Price: ");
        int newPrice = Convert.ToInt32(Console.ReadLine());
        foreach (Retail_Store item in inventory)
        {
            if (item.Name == itemToUpdate)
            {
                item.Price = newPrice;
                item.Quantity = newQuantity;
                Console.WriteLine($"{item.Name} has been updated.");
                break;
            }
        }
    }
}

void DisplayInventory()
{
    Console.WriteLine();
    Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
    Console.WriteLine();
    Console.WriteLine("------------------------------------------------------------");
    if (inventory.Any())
    {
        Console.WriteLine("\n************** Current Inventory **************");
        Console.WriteLine();
        Console.WriteLine();
        string t = "ID".PadRight(10);
        string t1 = "NAME".PadRight(15);
        string t2 = "QUANTITY".PadRight(15);
        string t3 = "PRICE".PadRight(15);

        Console.WriteLine(t + t1 + t2 + t3);
        Console.WriteLine("------------------------------------------------------------");
        foreach (Retail_Store item in inventory)
        {
            string temp_id = item.Id.ToString().PadRight(10);
            string temp_name = item.Name.ToString().PadRight(15);
            string temp_quantity = item.Quantity.ToString().PadRight(15);
            string temp_price = item.Price.ToString().PadRight(15);
            
            Console.WriteLine(temp_id + temp_name + temp_quantity + temp_price);
        } 
    }
    Console.WriteLine("------------------------------------------------------------");
    Console.ReadKey();
    Console.Clear();
}

void Search_Item()
{
    Console.WriteLine();
    Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
    Console.WriteLine();
    Console.Write("\nEnter item ID: ");
    int itrm_id = int.Parse(Console.ReadLine());
    Console.Write("\nEnter item name: ");
    string searchItem = Console.ReadLine();
    foreach (Retail_Store item in inventory)
    {
        if (item.Name == searchItem || item.Id == itrm_id)
        {
            Console.WriteLine($"{item.Name} ({item.Id}) - Quantity: {item.Quantity}, Price: ${item.Price}");
            break;
        }
    }
}

void Remove_Item()
{
    Console.WriteLine();
    Console.WriteLine("***************  Welcome To IMP Retail Store ***************");
    Console.WriteLine();
    Console.Write("\nEnter item name to remove: ");
    string itemToRemove = Console.ReadLine();

    int removedItems = inventory.RemoveAll(item => item.Name == itemToRemove);
    
    if (removedItems > 0)
    {
        Console.WriteLine($"{removedItems} {itemToRemove} has been removed from the inventory.");
    }
    else
    {
        Console.WriteLine($"{itemToRemove} was not found in the inventory.");
    }
}


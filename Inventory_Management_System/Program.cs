
using Retail_Store;

Console.CursorVisible = false;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.Yellow;

List<Item> products = new List<Item>();

while (true)
{
    int opt = Features.choice();
    switch (opt)
    {
        case 1:
            Features.AddItem(products);
            break;

        case 2:
            Features.UpdateItem(products);
            break;

        case 3:
            Features.DisplayInventory(products);
            break;

        case 4:
            Features.Search_Item(products);
            break;

        case 5:
            Features.Remove_Item(products);
            break;

        case 6:
            Console.WriteLine("***************Thanks For Visiting Our Store!***************");
            Console.WriteLine("------------------------------------------------------------");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("\nInvalid choice. Please enter a number from 1 to 6.");
            break;
    }
}
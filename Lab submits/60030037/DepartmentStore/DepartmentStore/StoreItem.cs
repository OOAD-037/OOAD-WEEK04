public class StoreItem
{
    public int itemNumber;
    public string itemName;
    public string size;
    public double unitPrice;

    public void CreateItem()
    {
        itemNumber = 792475;
        itemName = "Wireless Keyboard Logitec 1548";
        size = "200g";
        unitPrice = 1800;
    }

    public void Describe()
    {
        System.Console.WriteLine("Department Store");

        System.Console.Write("Item #:     ");
        System.Console.WriteLine(itemNumber);
        System.Console.Write("Item Name:  ");
        System.Console.WriteLine(itemName);
        System.Console.Write("Item Size:  ");
        System.Console.WriteLine(size);
        System.Console.Write("Unit Price: ");
        System.Console.WriteLine(unitPrice);
    }
}
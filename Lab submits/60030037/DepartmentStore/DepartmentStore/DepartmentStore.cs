public class DepartmentStore
{
    static void Main()
    {
        StoreItem si = new StoreItem();

        si.CreateItem();
        si.Describe();

        System.Console.ReadKey();
    }
}
namespace Ex_03_01;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();

        Console.Write("商品番号を入力してください->");
　　　　　int itemNo = int.Parse(Console.ReadLine());
        Console.Write("商品名を入力してください->");
　　　　　string itemName = Console.ReadLine();
        Console.Write("値段を入力してください->");
　　　　　int price = int.Parse(Console.ReadLine());
        Console.WriteLine("結果");
        Console.WriteLine($"商品番号={item.itemNo}");
        Console.WriteLine($"商品名={item.itemName}");
        Console.WriteLine($"値段={item.price}");
        
        
    }
}

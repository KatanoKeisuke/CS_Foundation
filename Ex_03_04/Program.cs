namespace Ex_03_04;

static class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();

        Console.Write("商品番号を入力してください->");
        int itemNo = int.Parse(Console.ReadLine());
        item.itemNo = itemNo;

        Console.Write("商品名を入力してください->");
            string itemName = Console.ReadLine();
            item.itemName = itemName;
        Console.Write("値段を入力してください->");
        int price = int.Parse(Console.ReadLine());
           item.price = price;


        Console.Write("新しい単価を入力してください->");
        int pprice = int.Parse(Console.ReadLine());
        
        item.ChangePrice(pprice);   
        item.CalculateTaxAmount(pprice);
        item.Print();
        
        
        
    }
}
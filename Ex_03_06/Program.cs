namespace Ex_03_06;

static class Program
{
    static void Main(string[] args)
    {
        

        Console.Write("商品番号を入力してください->");
        int itemNo = int.Parse(Console.ReadLine());
        

        Console.Write("商品名を入力してください->");
            string itemName = Console.ReadLine();
            
        Console.Write("値段を入力してください->");
        int price = int.Parse(Console.ReadLine());
           
        Item item = new Item(itemNo,itemName,price);

        Console.Write("新しい単価を入力してください->");
        int pprice = int.Parse(Console.ReadLine());

        
        
        item.ChangePrice(pprice);

        Console.WriteLine("結果");

        item.Print();

        Console.Write("更に新しい単価を入力してください->");
        string ppprice = Console.ReadLine();


        item.ChangePrice(ppprice);

        Console.WriteLine("結果");

        item.Print();
        
        
    }
}

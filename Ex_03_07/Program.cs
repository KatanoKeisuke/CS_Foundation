using Ex_03_07.Models;
namespace Ex_03_07;

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
           
        Item item = new Item();
        item.ItemNo = itemNo;
        item.ItemName = itemName;
        item.Price = price;

          Console.WriteLine("結果");

        item.Print();
        
        
    }
}
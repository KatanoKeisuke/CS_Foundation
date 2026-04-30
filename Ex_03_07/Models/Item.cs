namespace Ex_03_07.Models;

public class Item
{
public int ItemNo { get; set; }
public string ItemName { get; set; }	
public int Price { get; set; }


public void Print()
{
    Console.WriteLine("商品番号:{0}",ItemNo);
    Console.WriteLine("商品名:{0}",ItemName);
    Console.WriteLine("値段:{0}",Price);
}
}
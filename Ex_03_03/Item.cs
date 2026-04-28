namespace Ex_03_03;

/// <summary>
/// 商品を表すクラス
/// <summary>
public class Item
{
    public int itemNo;
    public string itemName;
    public int price;

    public void Print()
    {Console.WriteLine("結果");
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"値段={price}");
    }
    public void ChangePrice(int newprice)
    {
        price = newprice;
    }
}
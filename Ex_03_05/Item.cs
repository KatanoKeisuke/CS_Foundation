namespace Ex_03_05;

/// <summary>
/// 演習-02 インスタンスを複数作成し、値が個別に保持されていることを確認
/// 商品を表すクラス
/// </summary>
public class Item
{
    public int itemNo;      // 商品番号
    public string itemName; // 商品名
    public int price;       // 単価
    public double salesTaxRate = 0.10; // 消費税率(10%)

     public Item(int pitemNo,string pitemName,int pprice)
    {
        this.itemNo = pitemNo;
        this.itemName = pitemName;
        this.price = pprice;
    }

    /// <summary>
    /// 演習-04 フィールドの値を出力するメソッドを作成して利用する
    /// 模範解答
    /// </summary>
    public void Print()
    {
        Console.WriteLine($"商品番号={itemNo}");
        Console.WriteLine($"商品名={itemName}");
        Console.WriteLine($"単価={price}");
    }
    /// <summary>
    /// 演習-05 フィールドの値を変更するメソッドを作成して利用する
    /// 模範解答
    /// </summary>
    /// <param name="pprice">単価</param>
    public void ChangePrice(int pprice)
    {
        price = pprice;
    }
    /// <summary>
    /// 演習-06 戻り値を返すメソッドを作成して利用する
    /// 模範解答
    /// </summary>
    /// <returns>消費税込み金額</returns>
    public int CalculateTaxAmount()
    {
        double result = price + (price * salesTaxRate);
        return (int)result;
    }

    /// <summary>
    /// 演習-07 参照型引数を利用する
    /// 模範解答
    /// </summary>
    /// <param name="price">金額</param>
    public void CalculateTaxAmountRef(ref int price)
    {
        price = (int)(price + (price * salesTaxRate));
    }

    /// <summary>
    /// 演習-09 オーバーロードメソッドを作成し利用する
    /// </summary>
    /// <param name="price">金額(文字列型)</param>
    /// 
    public void ChangePrice(string pprice)
    {
        price = int.Parse(pprice);
    }
    
   
    
}
namespace Ex_02_03;

static class Program
{
    static void Main(string[] args)
    {
                
        System.Console.Write("数値を入力してください->");
        var number = System.Console.ReadLine();
        int result;
        result = int.Parse(number) + 5;
        System.Console.WriteLine($"5を加算した結果は{result}です");
        result = int.Parse(number) - 5;
        System.Console.WriteLine($"5を減算した結果は{result}です");
    }
}
namespace Ex_02_04;

static class Program
{
    static void Main(string[] args)
    {
        int[] number = new int[3];

        Console.Write("数値1を入力してください->");
        number[0] = int.Parse(Console.ReadLine());
        Console.Write("数値2を入力してください->");
        number[1] = int.Parse(Console.ReadLine());
        Console.Write("数値3を入力してください->");
        number[2] = int.Parse(Console.ReadLine());

        Console.WriteLine("入力結果");
        Console.WriteLine($"数値1:{number[0]}");
        Console.WriteLine($"数値2:{number[1]}");
        Console.WriteLine($"数値3:{number[2]}");
    }
}

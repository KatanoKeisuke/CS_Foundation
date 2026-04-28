namespace Ex_02_06;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("値を入力してください->");
　　　　　int value = int.Parse(Console.ReadLine());
　　　　　if (value % 4 == 0)
    {
        Console.WriteLine("4の倍数です");
    }
    else
    {
        Console.WriteLine("４の倍数ではありません");
    }
}
    }

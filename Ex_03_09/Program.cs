using Ex_03_09.Modules;

namespace Ex_03_09;

static class Program
{
    static void Main(string[] args)
    {
        NetAccounts netAccount = new NetAccounts();
        Console.Write("口座番号を入力してください->");
        netAccount.AccountNo = Console.ReadLine();
        Console.Write("口座名義を入力してください->");
        netAccount.AccountName = Console.ReadLine();
        Console.Write("残高を入力してください->");
        netAccount.Balance = int.Parse(Console.ReadLine());
        Console.Write("ポイントを入力してください->");
        netAccount.Point = int.Parse(Console.ReadLine());
        Console.Write("結果>");

        Console.WriteLine($"口座番号：{netAccount.AccountNo} ");
        Console.WriteLine($"口座名義：{netAccount.AccountName}" );
        Console.WriteLine($"残高：{netAccount.Balance} ");
        Console.WriteLine($"ポイント：{netAccount.Point}");

    
    }
}

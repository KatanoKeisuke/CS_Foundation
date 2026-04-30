namespace Ex_03_08.Modules;

public class NetAccount : Account

{
    public int Point { get; set; }


public NetAccount(string AccountNo, string AccountName, int Balance, int Point) : base(AccountNo, AccountName, Balance);

}
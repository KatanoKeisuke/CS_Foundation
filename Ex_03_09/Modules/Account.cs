namespace Ex_03_09.Modules;

public class Account
{
public string? AccountNo { get; set; }
public string? AccountName { get; set; }
public int Balance { get; set; }



public Account(string AccountNo, string AccountName, int Balance);

public virtual void Print();
public override string ToString();

}
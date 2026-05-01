using Ex_03_10.Modules;
namespace Ex_03_10;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("DVDのタイトルを入力してください->");
        string dvdMeida1 = Console.ReadLine();
        Player player1 = new DVDPlayer(dvdMeida1);
        player1.Play();
        player1.Stop();

        Console.Write("DVDのタイトルを入力してください->");
        string BlurayMeida1 = Console.ReadLine();
        Player player1 = new BlurayPlayer(blurayMeida1);
        player1.Play();
        player1.Stop();

        
        
    }
}

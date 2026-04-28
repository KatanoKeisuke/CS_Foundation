namespace Example;

static class Program
{
            static void Main(string[] args)
            {
                Console.Write("値を入力してください->");
                object obj = Console.ReadLine();
                switch (obj)
                {
                case int n:
                Console.WriteLine($"整数型:{n}");
                break;
                case string s:
                Console.WriteLine($"文字列型:{s}");
                break;
                default:
                Console.WriteLine("他のデータ型");
                break;
                }
            }


   
}
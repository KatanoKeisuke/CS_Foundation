namespace Ex_02_05;

static static class Program
{
    static void Main(string[] args)
    {
                    Console.Write("値を入力してください->");
                    int a = int.Parse(Console.ReadLine());
                    if (a % 2 == 1)
                    {
                    Console.WriteLine($"結果:{a}");
                    }
                    else
                    {
                    Console.WriteLine($"結果:{a*10}");
                    }
                    Console.WriteLine("終了");	
                }
    }

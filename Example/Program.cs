namespace Example;

static class Program
{
            static void Main(string[] args)     
            {int? value = null;
            if (value.HasValue)
            {
            Console.WriteLine($"有効な値={value.Value}");
            }
            else
            {
            Console.WriteLine("無効な値(null)");
            }}
}
namespace DemoApplicationForDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 != s2)
            {
                Console.WriteLine("Not sharing the same resourece");
            }
            else
            {
                Console.WriteLine("Sharing the same resource");
            }
            Console.ReadLine();
        }
    }
}
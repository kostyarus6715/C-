namespace ConsoleApp5
{
    internal class Program
    {
        public static void Method()
        {
            Person tom = new Person();
        }
        static void Main()
        {
            Method();
            GC.Collect();

        }
    }
}
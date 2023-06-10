namespace ConsoleApp4
{
    internal class Counter
    {

        public int Count { get; set; }

        public Counter()
        {
            Random rand = new Random();
            Count = rand.Next(0, 10);

        }
        public Counter(int count)
        {
            this.Count = count;
        }
        public void Plus()
        {
            Count++;
        }
        public void Minus()
        {
            Count--;
        }
        public int GetCount
        {
            get { return Count; }
        }



    }
}

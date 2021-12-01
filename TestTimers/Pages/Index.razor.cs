namespace TestTimers.Pages
{
    public partial class Index
    {
        private Timer _timer;

        public Index()
        {
            _timer = new System.Threading.Timer(_ =>
            {
                Console.WriteLine("In timer, doing stuff.");
            }, null, 0, 500);
        }
    }
}

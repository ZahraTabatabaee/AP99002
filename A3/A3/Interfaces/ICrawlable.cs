namespace A3.Interfaces
{
    public interface ICrawlable
    {
        public double SpeedRate { get; set; }
        public string Crawl();
    }
}
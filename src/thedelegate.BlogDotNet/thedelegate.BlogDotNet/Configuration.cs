namespace thedelegate.BlogDotNet
{
    public class Configuration : IConfiguration
    {
        public Configuration()
        {
            ContentLocation = "Content/blog";
        }

        public string ContentLocation { get; set; }
    }
}

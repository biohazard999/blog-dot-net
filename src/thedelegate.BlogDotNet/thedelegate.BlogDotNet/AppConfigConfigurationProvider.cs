using System.Configuration;

namespace thedelegate.BlogDotNet
{
    public class AppConfigConfigurationProvider : IConfigurationProvider
    {
        private IConfiguration _Configuration;

        public IConfiguration Configuration
        {
            get { return _Configuration ?? (_Configuration = ReadConfiguration()); }
            private set { _Configuration = value; }
        }

        private IConfiguration ReadConfiguration()
        {
            return new Configuration()
            {
                ContentLocation = ConfigurationManager.AppSettings["ContentLocation"]
            };
        }
    }
}
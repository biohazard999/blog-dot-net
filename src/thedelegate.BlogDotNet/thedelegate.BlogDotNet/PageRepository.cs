using System.Collections.Generic;

namespace thedelegate.BlogDotNet
{
    public class PageRepository : IPageRepository
    {
        private readonly IConfiguration _configuration;

        public PageRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<PageEntry> GetAllPageEntries()
        {
            yield break;
        }

        public IEnumerable<PageEntry> GetArchivePageEntries()
        {
            yield break;
        }
    }
}
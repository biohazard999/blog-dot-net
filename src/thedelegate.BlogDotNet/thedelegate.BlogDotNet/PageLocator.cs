using System.Collections.Generic;

namespace thedelegate.BlogDotNet
{
    public class PageLocator : IPageLocator
    {
        private readonly IPageLocation _pageLocation;

        public PageLocator(IPageLocation pageLocation)
        {
            _pageLocation = pageLocation;
        }

        public IEnumerable<PageEntry> GetAllPageEntries()
        {
            return new List<PageEntry>();
        }
    }
}
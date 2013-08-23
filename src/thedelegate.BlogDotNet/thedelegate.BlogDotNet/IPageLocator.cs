using System.Collections.Generic;

namespace thedelegate.BlogDotNet
{
    public interface IPageLocator
    {
        IEnumerable<PageEntry> GetAllPageEntries();
    }
}
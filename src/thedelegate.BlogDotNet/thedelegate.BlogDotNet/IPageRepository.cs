using System.Collections.Generic;

namespace thedelegate.BlogDotNet
{
    public interface IPageRepository
    {
        IEnumerable<PageEntry> GetAllPageEntries();
        IEnumerable<PageEntry> GetArchivePageEntries();
    }
}
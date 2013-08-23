namespace thedelegate.BlogDotNet
{
    public interface IContentProcessor
    {
        IContentProvider FillProvider(IContentProvider provider);
    }
}
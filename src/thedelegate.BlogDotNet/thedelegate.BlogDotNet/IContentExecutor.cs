namespace thedelegate.BlogDotNet
{
    public interface IContentExecutor
    {
        IContentProvider FillProvider(IContentProvider provider);
    }
}
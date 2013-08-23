using System.Diagnostics;
using System.IO;

namespace thedelegate.BlogDotNet.ContentProvider.Markdown
{
    public class MarkdownContentProcessor : IContentProcessor
    {
        private readonly string _Path;

        public MarkdownContentProcessor(string path)
        {
            _Path = path;
            if (!File.Exists(_Path))
                throw new FileNotFoundException("The File was not found", path);
        }

        public IContentProvider FillProvider(IContentProvider provider)
        {
            var md = new MarkdownDeep.Markdown
            {
                ExtraMode = true, 
                SafeMode = false,
            };

            provider.Content = md.Transform(File.ReadAllText(_Path));

            return provider;
        }
    }
}
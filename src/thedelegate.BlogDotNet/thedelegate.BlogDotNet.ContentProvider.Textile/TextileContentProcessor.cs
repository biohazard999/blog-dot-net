using System;
using System.IO;
using Textile;

namespace thedelegate.BlogDotNet.ContentProvider.Textile
{
    public class TextileContentProcessor : IContentProcessor
    {
        private readonly string _Path;

        public TextileContentProcessor(string path)
        {
            _Path = path;
            if (!File.Exists(_Path))
                throw new FileNotFoundException("The File was not found", path);
        }

        public IContentProvider FillProvider(IContentProvider provider)
        {
            provider.Content = TextileFormatter.FormatString(File.ReadAllText(_Path));
            return provider;
        }
    }
}
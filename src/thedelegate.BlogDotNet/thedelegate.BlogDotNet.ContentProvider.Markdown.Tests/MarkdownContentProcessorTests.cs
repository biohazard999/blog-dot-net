using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExtensions;

namespace thedelegate.BlogDotNet.ContentProvider.Markdown.Tests
{
    public class MarkdownContentProcessorTests
    {
        [TestMethod]
        public void Constuctor_IfFileIsMissing_ThrowsFileNotFoundException()
        {
            var filename = Path.Combine(Path.GetTempPath(), Guid.Empty.ToString());
     
            ExceptionAssert.Throws<FileNotFoundException>(() => new MarkdownContentProcessor(filename), 
                "The File was not found");
        }
    }
}
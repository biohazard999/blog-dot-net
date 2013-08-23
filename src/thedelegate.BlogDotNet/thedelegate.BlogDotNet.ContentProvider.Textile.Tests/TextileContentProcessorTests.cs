using System;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;
using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExtensions;

namespace thedelegate.BlogDotNet.ContentProvider.Textile.Tests
{
    [UseReporter(typeof(DiffReporter), typeof(ClipboardReporter))]
    [TestClass]
    public class TextileContentProcessorTests
    {
        [TestMethod]
        public void Constuctor_IfFileIsMissing_ThrowsFileNotFoundException()
        {
            var filename = Path.Combine(Path.GetTempPath(), Guid.Empty.ToString());

            ExceptionAssert.Throws<FileNotFoundException>(() => new TextileContentProcessor(filename),
                "The File was not found");
        }


        [TestMethod]
        [TestCategory("Integration")]
        public void Render_textism_Entry()
        {
            var path = @"..\..\TestData\textism.yml";

            IContentProcessor contentProcessor = new TextileContentProcessor(path);

            IContentProvider provider = contentProcessor.FillProvider(A.Fake<IContentProvider>());

            Approvals.Verify(provider.Content);
        }
    }
}
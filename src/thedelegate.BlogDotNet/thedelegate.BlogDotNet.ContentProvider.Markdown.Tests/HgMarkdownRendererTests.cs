using System;
using System.IO;
using ApprovalTests;
using ApprovalTests.Reporters;
using FakeItEasy;
using Mercurial;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestExtensions;

namespace thedelegate.BlogDotNet.ContentProvider.Markdown.Tests
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
    public class HgMarkdownRendererTests
    {
        private string _RepoPath;
        private Repository _Repo;

        [TestInitialize]
        public void TestInitialize()
        {
            _RepoPath = Path.Combine(Path.GetTempPath(), Guid.Empty.ToString());
            Directory.CreateDirectory(_RepoPath);

            _Repo = new Repository(_RepoPath);
            _Repo.Clone("https://biohazard999@bitbucket.org/biohazard999/x2.delegate.at", new CloneCommand());
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _Repo = null;
            SilentExecute(() => Directory.Delete(_RepoPath, true));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void Render_FirstPost_2013()
        {
            var path = Path.Combine(_RepoPath, "2013", "1-markdown-centric-blog", "markdown-centric-blog.md");

            IContentExecutor contentExecutor = new MarkDownContentExecutor(path);

            IContentProvider provider = contentExecutor.FillProvider(A.Fake<IContentProvider>());

            Approvals.Verify(provider.Content);
        }

        private void SilentExecute(Action action)
        {
            try
            {
                action();
            }
            // ReSharper disable once EmptyGeneralCatchClause
            catch
            {
               
            }
        }

        [TestMethod]
        public void Constuctor_IfFileIsMissing_ThrowsFileNotFoundException()
        {
            var filename = Path.Combine(Path.GetTempPath(), Guid.Empty.ToString());
     
            ExceptionAssert.Throws<FileNotFoundException>(() => new MarkDownContentExecutor(filename), 
                "The File was not found");
        }

    }
}

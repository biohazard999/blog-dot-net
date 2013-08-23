using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

// ReSharper disable SuggestUseVarKeywordEvident

namespace thedelegate.BlogDotNet.Tests
{
    [TestClass]
    public class CommentTests
    {
        [TestMethod]
        public void Content_Stores_StringValue()
        {
            string expected = new Fixture().Create<string>();

            var page = new Comment()
            {
                Content = expected
            };

            page.Content.Should().Be(expected);
        }

        [TestMethod]
        public void Comment_Implements_IContentProvider()
        {
            IContentProvider provider = new Comment();

            provider.Should().BeAssignableTo<IContentProvider>();
        }
    }
}
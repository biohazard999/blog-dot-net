using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

// ReSharper disable SuggestUseVarKeywordEvident

namespace thedelegate.BlogDotNet.Tests
{
    [TestClass]
    public class PageTests
    {
        [TestMethod]
        public void Content_Stores_StringValue()
        {

            string expected = new Fixture().Create<string>();

            var page = new Page()
            {
                Content = expected
            };

            page.Content.Should().Be(expected);
        } 
    }
}
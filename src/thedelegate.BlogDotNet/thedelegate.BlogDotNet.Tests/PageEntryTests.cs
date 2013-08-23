using System;
using System.Collections.Generic;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

// ReSharper disable SuggestUseVarKeywordEvident
namespace thedelegate.BlogDotNet.Tests
{
    [TestClass]
    public class PageEntryTests
    {
        [TestMethod]
        public void Slug_Stores_StringValue()
        {
            string expected = new Fixture().Create<string>();

            var pageEntry = new PageEntry()
            {
                Slug = expected
            };

            pageEntry.Slug.Should().Be(expected);
        }

        [TestMethod]
        public void State_Stores_PrivatePageState()
        {
            State_Stores_PageState(PageState.Private);
        }

        [TestMethod]
        public void State_Stores_DraftPageState()
        {
            State_Stores_PageState(PageState.Draft);
        }

        [TestMethod]
        public void State_Stores_PublicPageState()
        {
            State_Stores_PageState(PageState.Public);
        }

        private void State_Stores_PageState(PageState state)
        {
            var pageEntry = new PageEntry()
            {
                State = state,
            };

            Assert.AreEqual(state, pageEntry.State);
        }

        [TestMethod]
        public void Author_Stores_StringValue()
        {
            string expected = new Fixture().Create<string>();

            var pageEntry = new PageEntry()
            {
                Author = expected
            };

            pageEntry.Author.Should().Be(expected);
        }

        [TestMethod]
        public void PublishDate_Stores_NullableDateTimeValue()
        {
            DateTime? expected = new Fixture().Create<DateTime?>();

            var pageEntry = new PageEntry()
            {
                PublishDate = expected
            };

            pageEntry.PublishDate.Should().Be(expected);
        }

        [TestMethod]
        public void Tags_Stores_IEnumerableOfString()
        {
            IEnumerable<string> expected  = new Fixture().Create<List<string>>();

            var pageEntry = new PageEntry()
            {
                Tags = expected
            };

            pageEntry.Tags.Should().BeAssignableTo<IEnumerable<string>>();
        }

        [TestMethod]
        public void Comments_Stores_IEnumerableOfComment()
        {
            IEnumerable<Comment> expected = new Fixture().Create<List<Comment>>();

            var pageEntry = new PageEntry()
            {
                Comments = expected
            };

            pageEntry.Comments.Should().BeAssignableTo<IEnumerable<Comment>>();
        }
    }
}
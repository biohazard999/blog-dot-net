using System;
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

            var comment = new Comment()
            {
                Content = expected
            };

            comment.Content.Should().Be(expected);
        }

        [TestMethod]
        public void Comment_Implements_IContentProvider()
        {
            IContentProvider provider = new Comment();

            provider.Should().BeAssignableTo<IContentProvider>();
        }

        [TestMethod]
        public void FullName_Stores_StringValue()
        {
            string expected = new Fixture().Create<string>();

            var comment = new Comment()
            {
                FullName = expected
            };

            comment.FullName.Should().Be(expected);
        }

        [TestMethod]
        public void Email_Stores_StringValue()
        {
            string expected = new Fixture().Create<string>();

            var comment = new Comment()
            {
                Email = expected
            };

            comment.Email.Should().Be(expected);
        }

        [TestMethod]
        public void Homepage_Stores_StringValue()
        {
            string expected = new Fixture().Create<string>();

            var comment = new Comment()
            {
                Homepage = expected
            };

            comment.Homepage.Should().Be(expected);
        }

        [TestMethod]
        public void Date_Stores_NullableDateTime()
        {
            DateTime? expected = new Fixture().Create<DateTime?>();

            var comment = new Comment()
            {
                Date = expected
            };

            comment.Date.Should().Be(expected);
        }

        [TestMethod]
        public void IsSpam_Stores_Boolean()
        {
            bool expected = new Fixture().Create<bool>();

            var comment = new Comment()
            {
                IsSpam = expected
            };

            comment.IsSpam.Should().Be(expected);
        }
    }
}
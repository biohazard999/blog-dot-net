using System;
using System.Collections.Generic;
using FakeItEasy;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace thedelegate.BlogDotNet.Tests
{
    [TestClass]
    public class PageRepositoryTests
    {
        [TestMethod]
        public void GetAllPageEntries_ToScanAllPages_ShouldReturnIEnumerableOfPageEntires()
        {
            var pageLocation = A.Fake<IConfiguration>();

            IPageRepository postRepository = new PageRepository(pageLocation);

            IEnumerable<PageEntry> result = postRepository.GetAllPageEntries();

            result.Should().BeAssignableTo<IEnumerable<PageEntry>>();
        }

        [TestMethod]
        public void GetArchivePageEntries_ToShowArchiveList_ShouldReturnIEnumerableOfPageEntires()
        {
            var pageLocation = A.Fake<IConfiguration>();

            IPageRepository postRepository = new PageRepository(pageLocation);

            IEnumerable<PageEntry> result = postRepository.GetArchivePageEntries();

            result.Should().BeAssignableTo<IEnumerable<PageEntry>>();
        }
    }
}

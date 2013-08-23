using System;
using System.Collections.Generic;
using FakeItEasy;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace thedelegate.BlogDotNet.Tests
{
    [TestClass]
    public class PageLocatorTests
    {
        [TestMethod]
        public void GetAllPageEntries_ToScanAllPages_ShouldReturnIEnumerableOfPageEntires()
        {
            var pageLocation = A.Fake<IPageLocation>();

            IPageLocator postLocator = new PageLocator(pageLocation);

            IEnumerable<PageEntry> result = postLocator.GetAllPageEntries();

            result.Should().BeAssignableTo<IEnumerable<PageEntry>>();
        }


    }
}

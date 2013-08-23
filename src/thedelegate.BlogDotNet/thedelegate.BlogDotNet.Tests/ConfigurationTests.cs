using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;

// ReSharper disable SuggestUseVarKeywordEvident

namespace thedelegate.BlogDotNet.Tests
{
    [TestClass]
    public class ConfigurationTests
    {
        [TestMethod]
        public void Configuration_Implements_IConfiguration()
        {
            IConfiguration configuration = new Configuration();

            configuration.Should().BeAssignableTo<IConfiguration>();
        }

        [TestMethod]
        public void ContentLocation_ToSupportConvention_ShouldReturnContentDashBlog()
        {
            IConfiguration configuration = new Configuration();

            configuration.ContentLocation.Should().Be("Content/blog");
        }

        [TestMethod]
        public void ContentLocation_ToSupportConfiguration_ShouldBeSettable()
        {
            string expected = new Fixture().Create<string>();

            IConfiguration configuration = new Configuration()
            {
                ContentLocation = expected
            };

            configuration.ContentLocation.Should().Be(expected);
        }
    }
}
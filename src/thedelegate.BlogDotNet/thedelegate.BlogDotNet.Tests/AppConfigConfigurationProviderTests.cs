using FakeItEasy.ExtensionSyntax;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace thedelegate.BlogDotNet.Tests
{
    [TestClass]
    public class AppConfigConfigurationProviderTests
    {
        [TestMethod]
        public void Get_Configuration_Reads_ContentLocation()
        {
            IConfigurationProvider provider = new AppConfigConfigurationProvider();

            IConfiguration configuration = provider.Configuration;

            configuration.ContentLocation.Should().Be("MyPath/To/Blog");
        }
    }
}
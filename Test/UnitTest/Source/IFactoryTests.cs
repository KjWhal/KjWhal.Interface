
namespace UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using KjWhal.Interface;

    /// <summary>
    /// Container class for test methods of IBuilder
    /// </summary>
    [TestClass]
    public class IBuilderTests
    {
        /// <summary>
        /// Verifies that Factory implements IBuilder(T)
        /// </summary>
        [TestMethod]
        public void IBuilderPubliclyAvailable()
        {
            IBuilder<string> sut = new Factory();
        }

        /// <summary>
        /// Verifies that IBuilder(T) implements Initialize
        /// </summary>
        [TestMethod]
        public void IBuilderRequiresInitializeImplementation()
        {
            IBuilder<string> sut = new Factory();

            var result = sut.Initialize();

            Assert.AreEqual<string>(string.Empty, result);
        }
    }

    internal class Factory : IBuilder<string>
    {
        public string Initialize()
        {
            return string.Empty;
        }
    }
}


namespace UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using KjWhal.Interface;

    /// <summary>
    /// Container class for test methods of IFactory
    /// </summary>
    [TestClass]
    public class IFactoryTests
    {
        /// <summary>
        /// Verifies that Factory implements IFactory(T)
        /// </summary>
        [TestMethod]
        public void IFactoryPubliclyAvailable()
        {
            IFactory<string> sut = new Factory();
        }

        /// <summary>
        /// Verifies that IFactory(T) implements Initialize
        /// </summary>
        [TestMethod]
        public void IFactoryRequiresInitializeImplementation()
        {
            IFactory<string> sut = new Factory();

            var result = sut.Initialize();

            Assert.AreEqual<string>(string.Empty, result);
        }
    }

    internal class Factory : IFactory<string>
    {
        public string Initialize()
        {
            return string.Empty;
        }
    }
}

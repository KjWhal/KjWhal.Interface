using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    using KjWhal.Interface;

    /// <summary>
    /// Container class for test methods of IFactory
    /// </summary>
    [TestClass]
    public class IRuntimeFactoryTests
    {
        /// <summary>
        /// Verifies that Factory implements IRuntimeFactory(TResult, TArgument)
        /// </summary>
        [TestMethod]
        public void IRuntimeFactoryPubliclyAvailable()
        {
            IRuntimeFactory<string, string> sut = new Factory();
        }

        /// <summary>
        /// Verifies that IRuntimeFactory(TResult, TArgument) implements Initialize
        /// </summary>
        [TestMethod]
        public void IRuntimeFactoryRequiresInitializeImplementation()
        {
            IRuntimeFactory<string, string> sut = new Factory();

            var result = sut.Initialize(string.Empty);

            Assert.AreEqual<string>(string.Empty, result);
        }
    }

    private class Factory : IRuntimeFactory<string, string>
    {
        internal string Initialize(string argument)
        {
            return string.Empty;
        }
    }
}

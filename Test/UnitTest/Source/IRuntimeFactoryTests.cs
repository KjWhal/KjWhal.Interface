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
            IFactory<string, string> sut = new RuntimeFactory();
        }

        /// <summary>
        /// Verifies that IRuntimeFactory(TResult, TArgument) implements Initialize
        /// </summary>
        [TestMethod]
        public void IRuntimeFactoryRequiresInitializeImplementation()
        {
            IFactory<string, string> sut = new RuntimeFactory();

            var result = sut.Initialize(string.Empty);

            Assert.AreEqual<string>(string.Empty, result);
        }
    }

    internal class RuntimeFactory : IFactory<string, string>
    {
        public string Initialize(string argument)
        {
            return string.Empty;
        }
    }
}

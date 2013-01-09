
namespace UnitTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using KjWhal.Interface;

    /// <summary>
    /// Container class for test methods of IFactory
    /// </summary>
    [TestClass]
    public class IBatchDataContextTests
    {
        /// <summary>
        /// Verifies that Factory implements IFactory(T)
        /// </summary>
        [TestMethod]
        public void IBatchDataContextPubliclyAvailable()
        {
            IBatchDataContext sut = new BatchDataContext();
        }

        /// <summary>
        /// Verifies that IBatchDataContext implements AddSaveMany
        /// </summary>
        [TestMethod]
        public void IBatchDataContextRequiresIAddSaveManyImplementation()
        {
            IBatchDataContext sut = new BatchDataContext();

            sut.AddSaveMany(new string[1]);
        }

        /// <summary>
        /// Verifies that IBatchDataContext implements RemoveSaveMany
        /// </summary>
        [TestMethod]
        public void IBatchDataContextRequiresIRemoveSaveManyImplementation()
        {
            IBatchDataContext sut = new BatchDataContext();

            sut.RemoveSaveMany(new string[1]);
        }
    }

    internal class BatchDataContext : IBatchDataContext
    {
        public void AddSaveMany<T>(System.Collections.Generic.IEnumerable<T> items) where T : class
        {
            // Do nothing
        }

        public void RemoveSaveMany<T>(System.Collections.Generic.IEnumerable<T> items) where T : class
        {
            // Do nothing
        }
    }
}

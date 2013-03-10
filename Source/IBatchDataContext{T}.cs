
namespace KjWhal.Interface
{
    using System.Collections.Generic;

    /// <summary>
    /// Contract for data context objects providing batchable interfaces
    /// </summary>
    public interface IBatchDataContext
    {
        /// <summary>
        /// Adds objects to local datacontext and commits the changes
        /// </summary>
        /// <typeparam name="T">Represents the type of item being added</typeparam>
        /// <param name="items">Items to add to data context</param>
        void AddSaveMany<T>(IEnumerable<T> items) where T : class;

        /// <summary>
        /// Removes objects to local datacontext and commits the changes
        /// </summary>
        /// <typeparam name="T">Represents the type of item being added</typeparam>
        /// <param name="items">Items to add to data context</param>
        void RemoveSaveMany<T>(IEnumerable<T> items) where T : class;
    }
}

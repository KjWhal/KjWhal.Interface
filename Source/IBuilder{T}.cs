
namespace KjWhal.Interface
{
    /// <summary>
    /// Contract for an instance which initializes new instances of T
    /// </summary>
    /// <typeparam name="TResult">Type to instantiate</typeparam>
    public interface IBuilder<T>
    {
        /// <summary>
        /// Initializes a new instance of T
        /// </summary>
        /// <returns>Instance of TResult</returns>
        T Initialize();
    }
}

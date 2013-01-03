
namespace KjWhal.Interface
{
    /// <summary>
    /// Contract for an instance which initializes new instances of types
    /// </summary>
    /// <typeparam name="TResult">Type to instantiate</typeparam>
    public interface IFactory<T>
    {
        /// <summary>
        /// Initializes a new instance of TResult with run-time arguments from TArgument
        /// </summary>
        /// <returns>Instance of TResult</returns>
        T Initialize();
    }
}

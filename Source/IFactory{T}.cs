
namespace KjWhal.Interface
{
    /// <summary>
    /// Contract for an instance which initializes new instances of types
    /// </summary>
    /// <typeparam name="TResult">Type to instantiate</typeparam>
    /// <typeparam name="TArgument">Type representing run-time arguments used in initialization</typeparam>
    public interface IFactory<TResult, TArgument>
    {
        /// <summary>
        /// Initializes a new instance of TResult with run-time arguments from TArgument
        /// </summary>
        /// <param name="argument">Run-time arguments for initializing a new instance ofTResult</param>
        /// <returns>Instance of TResult</returns>
        TResult Initialize(TArgument argument);
    }
}

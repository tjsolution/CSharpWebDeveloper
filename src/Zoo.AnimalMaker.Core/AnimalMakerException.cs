/// <summary>
/// Exception class for the Animal Factory.
/// </summary>
[System.Serializable]
public class AnimalMakerException : System.Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnimalMakerException"/> class.
    /// </summary>
    public AnimalMakerException() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="AnimalMakerException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public AnimalMakerException(string message) : base(message) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="AnimalMakerException"/> class.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <param name="inner">The inner.</param>
    public AnimalMakerException(string message, System.Exception inner) : base(message, inner) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="AnimalMakerException"/> class.
    /// </summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
    protected AnimalMakerException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context)
        : base(info, context) { }

    /// <summary>
    /// Creates the exception with a formatted message using string.Format(message, args).
    /// </summary>
    /// <param name="message">The message.</param>
    /// <param name="args">The arguments for the formatted message.</param>
    /// <returns></returns>
    public static AnimalMakerException Create(string message, params object[] args)
    {
        if (string.IsNullOrEmpty(message))
        {
            return new AnimalMakerException();
        }
        var formattedMessage = string.Format(message, args);
        return new AnimalMakerException(formattedMessage);
    }
}
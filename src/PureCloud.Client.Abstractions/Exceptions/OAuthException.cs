namespace PureCloud.Client.Exceptions;

public sealed class OAuthException : Exception
{
    public OAuthException(string message)
        : base(message) { }
}

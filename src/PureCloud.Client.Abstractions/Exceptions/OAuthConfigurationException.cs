namespace PureCloud.Client.Exceptions;

public sealed class OAuthConfigurationException : Exception
{
    public OAuthConfigurationException()
        : base("OAuth configuration is missing. ClientId and ClientSecret must be configured.") { }

    public OAuthConfigurationException(string message)
        : base(message) { }
}

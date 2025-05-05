namespace PureCloud.Client.Models;

public sealed class TokenInfo
{
    /// <summary>
    /// The current organization
    /// </summary>
    /// <value>The current organization</value>
    public NamedEntity Organization { get; private set; }

    /// <summary>
    /// The token&#39;s home organization
    /// </summary>
    /// <value>The token&#39;s home organization</value>
    public NamedEntity HomeOrganization { get; private set; }

    /// <summary>
    /// The list of scopes authorized for the OAuth client
    /// </summary>
    /// <value>The list of scopes authorized for the OAuth client</value>
    public IEnumerable<string> AuthorizedScope { get; private set; }

    /// <summary>
    /// Only present when a user is a clone of trustee user in the trustor org.
    /// </summary>
    /// <value>Only present when a user is a clone of trustee user in the trustor org.</value>
    public TokenInfoClonedUser ClonedUser { get; private set; }

    /// <summary>
    /// Gets or Sets OAuthClient
    /// </summary>
    public OrgOAuthClient OAuthClient { get; set; }
}

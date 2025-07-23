namespace PureCloud.Client.Models;

public sealed class OAuthClient
{
    public string Id { get; set; }
    public string Name { get; set; }
    public long? AccessTokenValiditySeconds { get; set; }
    public string Description { get; set; }
    public IEnumerable<string> RegisteredRedirectUri { get; set; }
    public string Secret { get; set; }
    public IEnumerable<string> RoleIds { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public DomainEntityRef CreatedBy { get; set; }
    public DomainEntityRef ModifiedBy { get; set; }
    public AuthorizedGrantTypeEnum? AuthorizedGrantType { get; set; }
    public IEnumerable<string> Scope { get; set; }
    public IEnumerable<RoleDivision> RoleDivisions { get; set; }
    public StateEnum? State { get; set; }
    public DateTime? DateToDelete { get; set; }
    public string SelfUri { get; set; }
    public enum AuthorizedGrantTypeEnum { OutdatedSdkVersion, Code, Token, Saml2bearer, Password, Clientcredentials }
    public enum StateEnum { OutdatedSdkVersion, Active, Disabled, Inactive }
}

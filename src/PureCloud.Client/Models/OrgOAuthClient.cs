using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum OrgOAuthClientState
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Active for "active"
    /// </summary>
    [EnumMember(Value = "active")]
    Active,

    /// <summary>
    /// Enum Disabled for "disabled"
    /// </summary>
    [EnumMember(Value = "disabled")]
    Disabled,

    /// <summary>
    /// Enum Inactive for "inactive"
    /// </summary>
    [EnumMember(Value = "inactive")]
    Inactive
}

public sealed class OrgOAuthClient
{
    /// <summary>
    /// The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. PKCE-Enabled Code Authorization grant type - Code grant type which requires PKCE challenge and verifier to create tokens. Used in public clients for increased security. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client. 
    /// </summary>
    /// <value>The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. PKCE-Enabled Code Authorization grant type - Code grant type which requires PKCE challenge and verifier to create tokens. Used in public clients for increased security. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client. </value>
    public AuthorizedGrantType? AuthorizedGrantType { get; set; }

    /// <summary>
    /// The state of the OAuth client. Active: The OAuth client can be used to create access tokens. This is the default state. Disabled: Access tokens created by the client are invalid and new ones cannot be created. Inactive: Access tokens cannot be created with this OAuth client and it will be deleted.
    /// </summary>
    /// <value>The state of the OAuth client. Active: The OAuth client can be used to create access tokens. This is the default state. Disabled: Access tokens created by the client are invalid and new ones cannot be created. Inactive: Access tokens cannot be created with this OAuth client and it will be deleted.</value>
    public OrgOAuthClientState? State { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the OAuth client.
    /// </summary>
    /// <value>The name of the OAuth client.</value>
    public string Name { get; set; }

    /// <summary>
    /// Date this client was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this client was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Date this client was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this client was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// User that created this client
    /// </summary>
    /// <value>User that created this client</value>
    public DomainEntityRef CreatedBy { get; set; }

    /// <summary>
    /// User that last modified this client
    /// </summary>
    /// <value>User that last modified this client</value>
    public DomainEntityRef ModifiedBy { get; set; }

    /// <summary>
    /// The scope requested by this client. Scopes only apply to clients not using the client_credential grant
    /// </summary>
    /// <value>The scope requested by this client. Scopes only apply to clients not using the client_credential grant</value>
    public IEnumerable<string> Scope { get; set; }

    /// <summary>
    /// Set of roles and their corresponding divisions associated with this client. Roles and divisions only apply to clients using the client_credential grant
    /// </summary>
    /// <value>Set of roles and their corresponding divisions associated with this client. Roles and divisions only apply to clients using the client_credential grant</value>
    public IEnumerable<RoleDivision> RoleDivisions { get; set; }

    /// <summary>
    /// The time at which this client will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which this client will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateToDelete { get; set; }

    /// <summary>
    /// The  oauth client&#39;s organization.
    /// </summary>
    /// <value>The  oauth client&#39;s organization.</value>
    public NamedEntity Organization { get; set; }
}

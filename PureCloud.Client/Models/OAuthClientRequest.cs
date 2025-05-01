using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OAuthClientRequest
/// </summary>
[DataContract]
public partial class OAuthClientRequest : IEquatable<OAuthClientRequest>
{
    /// <summary>
    /// The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. PKCE-Enabled Code Authorization grant type - Code grant type which requires PKCE challenge and verifier to create tokens. Used in public clients for increased security. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client. 
    /// </summary>
    /// <value>The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. PKCE-Enabled Code Authorization grant type - Code grant type which requires PKCE challenge and verifier to create tokens. Used in public clients for increased security. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client. </value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AuthorizedGrantTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Code for "CODE"
        /// </summary>
        [EnumMember(Value = "CODE")]
        Code,

        /// <summary>
        /// Enum Token for "TOKEN"
        /// </summary>
        [EnumMember(Value = "TOKEN")]
        Token,

        /// <summary>
        /// Enum Saml2bearer for "SAML2-BEARER"
        /// </summary>
        [EnumMember(Value = "SAML2-BEARER")]
        Saml2bearer,

        /// <summary>
        /// Enum Password for "PASSWORD"
        /// </summary>
        [EnumMember(Value = "PASSWORD")]
        Password,

        /// <summary>
        /// Enum Clientcredentials for "CLIENT-CREDENTIALS"
        /// </summary>
        [EnumMember(Value = "CLIENT-CREDENTIALS")]
        Clientcredentials
    }
    /// <summary>
    /// The state of the OAuth client. Active: The OAuth client can be used to create access tokens. This is the default state. Disabled: Access tokens created by the client are invalid and new ones cannot be created. Inactive: Access tokens cannot be created with this OAuth client and it will be deleted.
    /// </summary>
    /// <value>The state of the OAuth client. Active: The OAuth client can be used to create access tokens. This is the default state. Disabled: Access tokens created by the client are invalid and new ones cannot be created. Inactive: Access tokens cannot be created with this OAuth client and it will be deleted.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
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
    /// <summary>
    /// The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. PKCE-Enabled Code Authorization grant type - Code grant type which requires PKCE challenge and verifier to create tokens. Used in public clients for increased security. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client. 
    /// </summary>
    /// <value>The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. PKCE-Enabled Code Authorization grant type - Code grant type which requires PKCE challenge and verifier to create tokens. Used in public clients for increased security. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client. </value>
    [DataMember(Name = "authorizedGrantType", EmitDefaultValue = false)]
    public AuthorizedGrantTypeEnum? AuthorizedGrantType { get; set; }
    /// <summary>
    /// The state of the OAuth client. Active: The OAuth client can be used to create access tokens. This is the default state. Disabled: Access tokens created by the client are invalid and new ones cannot be created. Inactive: Access tokens cannot be created with this OAuth client and it will be deleted.
    /// </summary>
    /// <value>The state of the OAuth client. Active: The OAuth client can be used to create access tokens. This is the default state. Disabled: Access tokens created by the client are invalid and new ones cannot be created. Inactive: Access tokens cannot be created with this OAuth client and it will be deleted.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OAuthClientRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OAuthClientRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OAuthClientRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the OAuth client. (required).</param>
    /// <param name="AccessTokenValiditySeconds">The number of seconds, between 5mins and 48hrs, until tokens created with this client expire. If this field is omitted, a default of 24 hours will be applied..</param>
    /// <param name="Description">Description.</param>
    /// <param name="RegisteredRedirectUri">List of allowed callbacks for this client. For example: https://myap.example.com/auth/callback.</param>
    /// <param name="RoleIds">Deprecated. Use roleDivisions instead..</param>
    /// <param name="AuthorizedGrantType">The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. PKCE-Enabled Code Authorization grant type - Code grant type which requires PKCE challenge and verifier to create tokens. Used in public clients for increased security. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client.  (required).</param>
    /// <param name="Scope">The scope requested by this client. Scopes only apply to clients not using the client_credential grant.</param>
    /// <param name="RoleDivisions">Set of roles and their corresponding divisions associated with this client. Roles and divisions only apply to clients using the client_credential grant.</param>
    /// <param name="State">The state of the OAuth client. Active: The OAuth client can be used to create access tokens. This is the default state. Disabled: Access tokens created by the client are invalid and new ones cannot be created. Inactive: Access tokens cannot be created with this OAuth client and it will be deleted..</param>
    /// <param name="DateToDelete">The time at which this client will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public OAuthClientRequest(string Name = null, long? AccessTokenValiditySeconds = null, string Description = null, List<string> RegisteredRedirectUri = null, List<string> RoleIds = null, AuthorizedGrantTypeEnum? AuthorizedGrantType = null, List<string> Scope = null, List<RoleDivision> RoleDivisions = null, StateEnum? State = null, DateTime? DateToDelete = null)
    {
        this.Name = Name;
        this.AccessTokenValiditySeconds = AccessTokenValiditySeconds;
        this.Description = Description;
        this.RegisteredRedirectUri = RegisteredRedirectUri;
        this.RoleIds = RoleIds;
        this.AuthorizedGrantType = AuthorizedGrantType;
        this.Scope = Scope;
        this.RoleDivisions = RoleDivisions;
        this.State = State;
        this.DateToDelete = DateToDelete;

    }



    /// <summary>
    /// The name of the OAuth client.
    /// </summary>
    /// <value>The name of the OAuth client.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The number of seconds, between 5mins and 48hrs, until tokens created with this client expire. If this field is omitted, a default of 24 hours will be applied.
    /// </summary>
    /// <value>The number of seconds, between 5mins and 48hrs, until tokens created with this client expire. If this field is omitted, a default of 24 hours will be applied.</value>
    [DataMember(Name = "accessTokenValiditySeconds", EmitDefaultValue = false)]
    public long? AccessTokenValiditySeconds { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// List of allowed callbacks for this client. For example: https://myap.example.com/auth/callback
    /// </summary>
    /// <value>List of allowed callbacks for this client. For example: https://myap.example.com/auth/callback</value>
    [DataMember(Name = "registeredRedirectUri", EmitDefaultValue = false)]
    public List<string> RegisteredRedirectUri { get; set; }



    /// <summary>
    /// Deprecated. Use roleDivisions instead.
    /// </summary>
    /// <value>Deprecated. Use roleDivisions instead.</value>
    [DataMember(Name = "roleIds", EmitDefaultValue = false)]
    public List<string> RoleIds { get; set; }





    /// <summary>
    /// The scope requested by this client. Scopes only apply to clients not using the client_credential grant
    /// </summary>
    /// <value>The scope requested by this client. Scopes only apply to clients not using the client_credential grant</value>
    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public List<string> Scope { get; set; }



    /// <summary>
    /// Set of roles and their corresponding divisions associated with this client. Roles and divisions only apply to clients using the client_credential grant
    /// </summary>
    /// <value>Set of roles and their corresponding divisions associated with this client. Roles and divisions only apply to clients using the client_credential grant</value>
    [DataMember(Name = "roleDivisions", EmitDefaultValue = false)]
    public List<RoleDivision> RoleDivisions { get; set; }





    /// <summary>
    /// The time at which this client will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which this client will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateToDelete", EmitDefaultValue = false)]
    public DateTime? DateToDelete { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OAuthClientRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  AccessTokenValiditySeconds: ").Append(AccessTokenValiditySeconds).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  RegisteredRedirectUri: ").Append(RegisteredRedirectUri).Append("\n");
        sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
        sb.Append("  AuthorizedGrantType: ").Append(AuthorizedGrantType).Append("\n");
        sb.Append("  Scope: ").Append(Scope).Append("\n");
        sb.Append("  RoleDivisions: ").Append(RoleDivisions).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateToDelete: ").Append(DateToDelete).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as OAuthClientRequest);
    }

    /// <summary>
    /// Returns true if OAuthClientRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of OAuthClientRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OAuthClientRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                AccessTokenValiditySeconds == other.AccessTokenValiditySeconds ||
                AccessTokenValiditySeconds != null &&
                AccessTokenValiditySeconds.Equals(other.AccessTokenValiditySeconds)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                RegisteredRedirectUri == other.RegisteredRedirectUri ||
                RegisteredRedirectUri != null &&
                RegisteredRedirectUri.SequenceEqual(other.RegisteredRedirectUri)
            ) &&
            (
                RoleIds == other.RoleIds ||
                RoleIds != null &&
                RoleIds.SequenceEqual(other.RoleIds)
            ) &&
            (
                AuthorizedGrantType == other.AuthorizedGrantType ||
                AuthorizedGrantType != null &&
                AuthorizedGrantType.Equals(other.AuthorizedGrantType)
            ) &&
            (
                Scope == other.Scope ||
                Scope != null &&
                Scope.SequenceEqual(other.Scope)
            ) &&
            (
                RoleDivisions == other.RoleDivisions ||
                RoleDivisions != null &&
                RoleDivisions.SequenceEqual(other.RoleDivisions)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                DateToDelete == other.DateToDelete ||
                DateToDelete != null &&
                DateToDelete.Equals(other.DateToDelete)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (AccessTokenValiditySeconds != null)
            {
                hash = hash * 59 + AccessTokenValiditySeconds.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (RegisteredRedirectUri != null)
            {
                hash = hash * 59 + RegisteredRedirectUri.GetHashCode();
            }

            if (RoleIds != null)
            {
                hash = hash * 59 + RoleIds.GetHashCode();
            }

            if (AuthorizedGrantType != null)
            {
                hash = hash * 59 + AuthorizedGrantType.GetHashCode();
            }

            if (Scope != null)
            {
                hash = hash * 59 + Scope.GetHashCode();
            }

            if (RoleDivisions != null)
            {
                hash = hash * 59 + RoleDivisions.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (DateToDelete != null)
            {
                hash = hash * 59 + DateToDelete.GetHashCode();
            }

            return hash;
        }
    }
}

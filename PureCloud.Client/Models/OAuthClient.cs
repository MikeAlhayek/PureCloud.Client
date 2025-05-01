using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// OAuthClient
/// </summary>
[DataContract]
public partial class OAuthClient : IEquatable<OAuthClient>
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
    /// Initializes a new instance of the <see cref="OAuthClient" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OAuthClient() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OAuthClient" /> class.
    /// </summary>
    /// <param name="Name">The name of the OAuth client. (required).</param>
    /// <param name="AccessTokenValiditySeconds">The number of seconds, between 5mins and 48hrs, until tokens created with this client expire. If this field is omitted, a default of 24 hours will be applied..</param>
    /// <param name="Description">Description.</param>
    /// <param name="RegisteredRedirectUri">List of allowed callbacks for this client. For example: https://myap.example.com/auth/callback.</param>
    /// <param name="Secret">System created secret assigned to this client. Secrets are required for code authorization and client credential grants..</param>
    /// <param name="RoleIds">Deprecated. Use roleDivisions instead..</param>
    /// <param name="DateCreated">Date this client was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date this client was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedBy">User that created this client.</param>
    /// <param name="ModifiedBy">User that last modified this client.</param>
    /// <param name="AuthorizedGrantType">The OAuth Grant/Client type supported by this client. Code Authorization Grant/Client type - Preferred client type where the Client ID and Secret are required to create tokens. Used where the secret can be secured. PKCE-Enabled Code Authorization grant type - Code grant type which requires PKCE challenge and verifier to create tokens. Used in public clients for increased security. Implicit grant type - Client ID only is required to create tokens. Used in browser and mobile apps where the secret can not be secured. SAML2-Bearer extension grant type - SAML2 assertion provider for user authentication at the token endpoint. Client Credential grant type - Used to created access tokens that are tied only to the client.  (required).</param>
    /// <param name="Scope">The scope requested by this client. Scopes only apply to clients not using the client_credential grant.</param>
    /// <param name="RoleDivisions">Set of roles and their corresponding divisions associated with this client. Roles and divisions only apply to clients using the client_credential grant.</param>
    /// <param name="State">The state of the OAuth client. Active: The OAuth client can be used to create access tokens. This is the default state. Disabled: Access tokens created by the client are invalid and new ones cannot be created. Inactive: Access tokens cannot be created with this OAuth client and it will be deleted..</param>
    /// <param name="DateToDelete">The time at which this client will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public OAuthClient(string Name = null, long? AccessTokenValiditySeconds = null, string Description = null, List<string> RegisteredRedirectUri = null, string Secret = null, List<string> RoleIds = null, DateTime? DateCreated = null, DateTime? DateModified = null, DomainEntityRef CreatedBy = null, DomainEntityRef ModifiedBy = null, AuthorizedGrantTypeEnum? AuthorizedGrantType = null, List<string> Scope = null, List<RoleDivision> RoleDivisions = null, StateEnum? State = null, DateTime? DateToDelete = null)
    {
        this.Name = Name;
        this.AccessTokenValiditySeconds = AccessTokenValiditySeconds;
        this.Description = Description;
        this.RegisteredRedirectUri = RegisteredRedirectUri;
        this.Secret = Secret;
        this.RoleIds = RoleIds;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.CreatedBy = CreatedBy;
        this.ModifiedBy = ModifiedBy;
        this.AuthorizedGrantType = AuthorizedGrantType;
        this.Scope = Scope;
        this.RoleDivisions = RoleDivisions;
        this.State = State;
        this.DateToDelete = DateToDelete;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



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
    /// System created secret assigned to this client. Secrets are required for code authorization and client credential grants.
    /// </summary>
    /// <value>System created secret assigned to this client. Secrets are required for code authorization and client credential grants.</value>
    [DataMember(Name = "secret", EmitDefaultValue = false)]
    public string Secret { get; set; }



    /// <summary>
    /// Deprecated. Use roleDivisions instead.
    /// </summary>
    /// <value>Deprecated. Use roleDivisions instead.</value>
    [DataMember(Name = "roleIds", EmitDefaultValue = false)]
    public List<string> RoleIds { get; set; }



    /// <summary>
    /// Date this client was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this client was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date this client was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this client was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// User that created this client
    /// </summary>
    /// <value>User that created this client</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public DomainEntityRef CreatedBy { get; set; }



    /// <summary>
    /// User that last modified this client
    /// </summary>
    /// <value>User that last modified this client</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public DomainEntityRef ModifiedBy { get; set; }





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
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OAuthClient {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  AccessTokenValiditySeconds: ").Append(AccessTokenValiditySeconds).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  RegisteredRedirectUri: ").Append(RegisteredRedirectUri).Append("\n");
        sb.Append("  Secret: ").Append(Secret).Append("\n");
        sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  AuthorizedGrantType: ").Append(AuthorizedGrantType).Append("\n");
        sb.Append("  Scope: ").Append(Scope).Append("\n");
        sb.Append("  RoleDivisions: ").Append(RoleDivisions).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  DateToDelete: ").Append(DateToDelete).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return this.Equals(obj as OAuthClient);
    }

    /// <summary>
    /// Returns true if OAuthClient instances are equal
    /// </summary>
    /// <param name="other">Instance of OAuthClient to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OAuthClient other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.AccessTokenValiditySeconds == other.AccessTokenValiditySeconds ||
                this.AccessTokenValiditySeconds != null &&
                this.AccessTokenValiditySeconds.Equals(other.AccessTokenValiditySeconds)
            ) &&
            (
                this.Description == other.Description ||
                this.Description != null &&
                this.Description.Equals(other.Description)
            ) &&
            (
                this.RegisteredRedirectUri == other.RegisteredRedirectUri ||
                this.RegisteredRedirectUri != null &&
                this.RegisteredRedirectUri.SequenceEqual(other.RegisteredRedirectUri)
            ) &&
            (
                this.Secret == other.Secret ||
                this.Secret != null &&
                this.Secret.Equals(other.Secret)
            ) &&
            (
                this.RoleIds == other.RoleIds ||
                this.RoleIds != null &&
                this.RoleIds.SequenceEqual(other.RoleIds)
            ) &&
            (
                this.DateCreated == other.DateCreated ||
                this.DateCreated != null &&
                this.DateCreated.Equals(other.DateCreated)
            ) &&
            (
                this.DateModified == other.DateModified ||
                this.DateModified != null &&
                this.DateModified.Equals(other.DateModified)
            ) &&
            (
                this.CreatedBy == other.CreatedBy ||
                this.CreatedBy != null &&
                this.CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                this.ModifiedBy == other.ModifiedBy ||
                this.ModifiedBy != null &&
                this.ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                this.AuthorizedGrantType == other.AuthorizedGrantType ||
                this.AuthorizedGrantType != null &&
                this.AuthorizedGrantType.Equals(other.AuthorizedGrantType)
            ) &&
            (
                this.Scope == other.Scope ||
                this.Scope != null &&
                this.Scope.SequenceEqual(other.Scope)
            ) &&
            (
                this.RoleDivisions == other.RoleDivisions ||
                this.RoleDivisions != null &&
                this.RoleDivisions.SequenceEqual(other.RoleDivisions)
            ) &&
            (
                this.State == other.State ||
                this.State != null &&
                this.State.Equals(other.State)
            ) &&
            (
                this.DateToDelete == other.DateToDelete ||
                this.DateToDelete != null &&
                this.DateToDelete.Equals(other.DateToDelete)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.AccessTokenValiditySeconds != null)
            {
                hash = hash * 59 + this.AccessTokenValiditySeconds.GetHashCode();
            }

            if (this.Description != null)
            {
                hash = hash * 59 + this.Description.GetHashCode();
            }

            if (this.RegisteredRedirectUri != null)
            {
                hash = hash * 59 + this.RegisteredRedirectUri.GetHashCode();
            }

            if (this.Secret != null)
            {
                hash = hash * 59 + this.Secret.GetHashCode();
            }

            if (this.RoleIds != null)
            {
                hash = hash * 59 + this.RoleIds.GetHashCode();
            }

            if (this.DateCreated != null)
            {
                hash = hash * 59 + this.DateCreated.GetHashCode();
            }

            if (this.DateModified != null)
            {
                hash = hash * 59 + this.DateModified.GetHashCode();
            }

            if (this.CreatedBy != null)
            {
                hash = hash * 59 + this.CreatedBy.GetHashCode();
            }

            if (this.ModifiedBy != null)
            {
                hash = hash * 59 + this.ModifiedBy.GetHashCode();
            }

            if (this.AuthorizedGrantType != null)
            {
                hash = hash * 59 + this.AuthorizedGrantType.GetHashCode();
            }

            if (this.Scope != null)
            {
                hash = hash * 59 + this.Scope.GetHashCode();
            }

            if (this.RoleDivisions != null)
            {
                hash = hash * 59 + this.RoleDivisions.GetHashCode();
            }

            if (this.State != null)
            {
                hash = hash * 59 + this.State.GetHashCode();
            }

            if (this.DateToDelete != null)
            {
                hash = hash * 59 + this.DateToDelete.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

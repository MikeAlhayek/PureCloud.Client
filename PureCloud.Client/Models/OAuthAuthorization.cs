using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OAuthAuthorization
/// </summary>
[DataContract]
public partial class OAuthAuthorization : IEquatable<OAuthAuthorization>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
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
        /// Enum Unauthorized for "Unauthorized"
        /// </summary>
        [EnumMember(Value = "Unauthorized")]
        Unauthorized,

        /// <summary>
        /// Enum Requested for "Requested"
        /// </summary>
        [EnumMember(Value = "Requested")]
        Requested,

        /// <summary>
        /// Enum Authorized for "Authorized"
        /// </summary>
        [EnumMember(Value = "Authorized")]
        Authorized,

        /// <summary>
        /// Enum Revoked for "Revoked"
        /// </summary>
        [EnumMember(Value = "Revoked")]
        Revoked
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OAuthAuthorization" /> class.
    /// </summary>
    /// <param name="Client">Client.</param>
    /// <param name="Scope">Scope.</param>
    /// <param name="Roles">Roles.</param>
    /// <param name="ResourceOwner">ResourceOwner.</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="Pending">Pending.</param>
    /// <param name="State">State.</param>
    public OAuthAuthorization(OAuthClient Client = null, List<string> Scope = null, List<string> Roles = null, DomainEntityRef ResourceOwner = null, DateTime? DateCreated = null, DateTime? DateModified = null, DomainEntityRef CreatedBy = null, DomainEntityRef ModifiedBy = null, bool? Pending = null, StateEnum? State = null)
    {
        this.Client = Client;
        this.Scope = Scope;
        this.Roles = Roles;
        this.ResourceOwner = ResourceOwner;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.CreatedBy = CreatedBy;
        this.ModifiedBy = ModifiedBy;
        this.Pending = Pending;
        this.State = State;

    }



    /// <summary>
    /// Gets or Sets Client
    /// </summary>
    [DataMember(Name = "client", EmitDefaultValue = false)]
    public OAuthClient Client { get; set; }



    /// <summary>
    /// Gets or Sets Scope
    /// </summary>
    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public List<string> Scope { get; set; }



    /// <summary>
    /// Gets or Sets Roles
    /// </summary>
    [DataMember(Name = "roles", EmitDefaultValue = false)]
    public List<string> Roles { get; set; }



    /// <summary>
    /// Gets or Sets ResourceOwner
    /// </summary>
    [DataMember(Name = "resourceOwner", EmitDefaultValue = false)]
    public DomainEntityRef ResourceOwner { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public DomainEntityRef CreatedBy { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public DomainEntityRef ModifiedBy { get; set; }



    /// <summary>
    /// Gets or Sets Pending
    /// </summary>
    [DataMember(Name = "pending", EmitDefaultValue = false)]
    public bool? Pending { get; set; }





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
        sb.Append("class OAuthAuthorization {\n");

        sb.Append("  Client: ").Append(Client).Append("\n");
        sb.Append("  Scope: ").Append(Scope).Append("\n");
        sb.Append("  Roles: ").Append(Roles).Append("\n");
        sb.Append("  ResourceOwner: ").Append(ResourceOwner).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  Pending: ").Append(Pending).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as OAuthAuthorization);
    }

    /// <summary>
    /// Returns true if OAuthAuthorization instances are equal
    /// </summary>
    /// <param name="other">Instance of OAuthAuthorization to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OAuthAuthorization other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Client == other.Client ||
                Client != null &&
                Client.Equals(other.Client)
            ) &&
            (
                Scope == other.Scope ||
                Scope != null &&
                Scope.SequenceEqual(other.Scope)
            ) &&
            (
                Roles == other.Roles ||
                Roles != null &&
                Roles.SequenceEqual(other.Roles)
            ) &&
            (
                ResourceOwner == other.ResourceOwner ||
                ResourceOwner != null &&
                ResourceOwner.Equals(other.ResourceOwner)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                Pending == other.Pending ||
                Pending != null &&
                Pending.Equals(other.Pending)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Client != null)
            {
                hash = hash * 59 + Client.GetHashCode();
            }

            if (Scope != null)
            {
                hash = hash * 59 + Scope.GetHashCode();
            }

            if (Roles != null)
            {
                hash = hash * 59 + Roles.GetHashCode();
            }

            if (ResourceOwner != null)
            {
                hash = hash * 59 + ResourceOwner.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (Pending != null)
            {
                hash = hash * 59 + Pending.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

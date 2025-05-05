using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalOrganizationIdentifier
/// </summary>

public partial class ExternalOrganizationIdentifier : IEquatable<ExternalOrganizationIdentifier>
{
    /// <summary>
    /// The type of this identifier
    /// </summary>
    /// <value>The type of this identifier</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Externalid for "ExternalId"
        /// </summary>
        [EnumMember(Value = "ExternalId")]
        Externalid
    }
    /// <summary>
    /// The type of this identifier
    /// </summary>
    /// <value>The type of this identifier</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalOrganizationIdentifier" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ExternalOrganizationIdentifier() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalOrganizationIdentifier" /> class.
    /// </summary>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Type">The type of this identifier (required).</param>
    /// <param name="Value">The string value of the identifier. Will vary in syntax by type. (required).</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExternalSource">The External Source ID of the identifier.</param>
    public ExternalOrganizationIdentifier(WritableStarrableDivision Division = null, TypeEnum? Type = null, string Value = null, DateTime? DateCreated = null, ExternalSource ExternalSource = null)
    {
        this.Division = Division;
        this.Type = Type;
        this.Value = Value;
        this.DateCreated = DateCreated;
        this.ExternalSource = ExternalSource;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableStarrableDivision Division { get; set; }





    /// <summary>
    /// The string value of the identifier. Will vary in syntax by type.
    /// </summary>
    /// <value>The string value of the identifier. Will vary in syntax by type.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The External Source ID of the identifier
    /// </summary>
    /// <value>The External Source ID of the identifier</value>
    [JsonPropertyName("externalSource")]
    public ExternalSource ExternalSource { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalOrganizationIdentifier {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ExternalSource: ").Append(ExternalSource).Append("\n");
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
        return Equals(obj as ExternalOrganizationIdentifier);
    }

    /// <summary>
    /// Returns true if ExternalOrganizationIdentifier instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalOrganizationIdentifier to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalOrganizationIdentifier other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ExternalSource == other.ExternalSource ||
                ExternalSource != null &&
                ExternalSource.Equals(other.ExternalSource)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ExternalSource != null)
            {
                hash = hash * 59 + ExternalSource.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

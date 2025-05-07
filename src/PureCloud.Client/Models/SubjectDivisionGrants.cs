using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SubjectDivisionGrants
/// </summary>

public partial class SubjectDivisionGrants : IEquatable<SubjectDivisionGrants>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
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
        /// Enum PcUser for "PC_USER"
        /// </summary>
        [EnumMember(Value = "PC_USER")]
        PcUser,

        /// <summary>
        /// Enum PcGroup for "PC_GROUP"
        /// </summary>
        [EnumMember(Value = "PC_GROUP")]
        PcGroup,

        /// <summary>
        /// Enum PcOauthClient for "PC_OAUTH_CLIENT"
        /// </summary>
        [EnumMember(Value = "PC_OAUTH_CLIENT")]
        PcOauthClient,

        /// <summary>
        /// Enum PcTrusteeUser for "PC_TRUSTEE_USER"
        /// </summary>
        [EnumMember(Value = "PC_TRUSTEE_USER")]
        PcTrusteeUser,

        /// <summary>
        /// Enum PcTrusteeGroup for "PC_TRUSTEE_GROUP"
        /// </summary>
        [EnumMember(Value = "PC_TRUSTEE_GROUP")]
        PcTrusteeGroup,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SubjectDivisionGrants" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Divisions">Divisions.</param>
    /// <param name="Type">Type.</param>
    public SubjectDivisionGrants(string Name = null, List<Division> Divisions = null, TypeEnum? Type = null)
    {
        this.Name = Name;
        this.Divisions = Divisions;
        this.Type = Type;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Divisions
    /// </summary>
    [JsonPropertyName("divisions")]
    public List<Division> Divisions { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SubjectDivisionGrants {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Divisions: ").Append(Divisions).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as SubjectDivisionGrants);
    }

    /// <summary>
    /// Returns true if SubjectDivisionGrants instances are equal
    /// </summary>
    /// <param name="other">Instance of SubjectDivisionGrants to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SubjectDivisionGrants other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Divisions == other.Divisions ||
                Divisions != null &&
                Divisions.SequenceEqual(other.Divisions)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Divisions != null)
            {
                hash = hash * 59 + Divisions.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

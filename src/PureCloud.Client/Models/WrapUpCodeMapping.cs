using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WrapUpCodeMapping
/// </summary>

public partial class WrapUpCodeMapping : IEquatable<WrapUpCodeMapping>
{
    /// <summary>
    /// Gets or Sets DefaultSet
    /// </summary>
    
    public enum DefaultSetEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum ContactUncallable for "CONTACT_UNCALLABLE"
        /// </summary>
        [EnumMember(Value = "CONTACT_UNCALLABLE")]
        ContactUncallable,

        /// <summary>
        /// Enum NumberUncallable for "NUMBER_UNCALLABLE"
        /// </summary>
        [EnumMember(Value = "NUMBER_UNCALLABLE")]
        NumberUncallable,

        /// <summary>
        /// Enum RightPartyContact for "RIGHT_PARTY_CONTACT"
        /// </summary>
        [EnumMember(Value = "RIGHT_PARTY_CONTACT")]
        RightPartyContact,

        /// <summary>
        /// Enum BusinessSuccess for "BUSINESS_SUCCESS"
        /// </summary>
        [EnumMember(Value = "BUSINESS_SUCCESS")]
        BusinessSuccess,

        /// <summary>
        /// Enum BusinessFailure for "BUSINESS_FAILURE"
        /// </summary>
        [EnumMember(Value = "BUSINESS_FAILURE")]
        BusinessFailure,

        /// <summary>
        /// Enum BusinessNeutral for "BUSINESS_NEUTRAL"
        /// </summary>
        [EnumMember(Value = "BUSINESS_NEUTRAL")]
        BusinessNeutral
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="WrapUpCodeMapping" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="DefaultSet">The default set of wrap-up flags. These will be used if there is no entry for a given wrap-up code in the mapping..</param>
    /// <param name="Mapping">A map from wrap-up code identifiers to a set of wrap-up flags..</param>
    public WrapUpCodeMapping(string Name = null, int? Version = null, List<DefaultSetEnum> DefaultSet = null, Dictionary<string, List<string>> Mapping = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.DefaultSet = DefaultSet;
        this.Mapping = Mapping;

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
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The default set of wrap-up flags. These will be used if there is no entry for a given wrap-up code in the mapping.
    /// </summary>
    /// <value>The default set of wrap-up flags. These will be used if there is no entry for a given wrap-up code in the mapping.</value>
    [JsonPropertyName("defaultSet")]
    public List<DefaultSetEnum> DefaultSet { get; set; }



    /// <summary>
    /// A map from wrap-up code identifiers to a set of wrap-up flags.
    /// </summary>
    /// <value>A map from wrap-up code identifiers to a set of wrap-up flags.</value>
    [JsonPropertyName("mapping")]
    public Dictionary<string, List<string>> Mapping { get; set; }



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
        sb.Append("class WrapUpCodeMapping {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DefaultSet: ").Append(DefaultSet).Append("\n");
        sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
        return Equals(obj as WrapUpCodeMapping);
    }

    /// <summary>
    /// Returns true if WrapUpCodeMapping instances are equal
    /// </summary>
    /// <param name="other">Instance of WrapUpCodeMapping to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WrapUpCodeMapping other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                DefaultSet == other.DefaultSet ||
                DefaultSet != null &&
                DefaultSet.SequenceEqual(other.DefaultSet)
            ) &&
            (
                Mapping == other.Mapping ||
                Mapping != null &&
                Mapping.SequenceEqual(other.Mapping)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (DefaultSet != null)
            {
                hash = hash * 59 + DefaultSet.GetHashCode();
            }

            if (Mapping != null)
            {
                hash = hash * 59 + Mapping.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerWrapupcodemappingConfigChangeWrapUpCodeMapping
/// </summary>

public partial class DialerWrapupcodemappingConfigChangeWrapUpCodeMapping : IEquatable<DialerWrapupcodemappingConfigChangeWrapUpCodeMapping>
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
        RightPartyContact
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerWrapupcodemappingConfigChangeWrapUpCodeMapping" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="DefaultSet">DefaultSet.</param>
    /// <param name="Mapping">Mapping.</param>
    public DialerWrapupcodemappingConfigChangeWrapUpCodeMapping(string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null, List<DefaultSetEnum> DefaultSet = null, Dictionary<string, List<string>> Mapping = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
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
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public long? Version { get; set; }



    /// <summary>
    /// Gets or Sets DefaultSet
    /// </summary>
    [JsonPropertyName("defaultSet")]
    public List<DefaultSetEnum> DefaultSet { get; set; }



    /// <summary>
    /// Gets or Sets Mapping
    /// </summary>
    [JsonPropertyName("mapping")]
    public Dictionary<string, List<string>> Mapping { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerWrapupcodemappingConfigChangeWrapUpCodeMapping {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DefaultSet: ").Append(DefaultSet).Append("\n");
        sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
        return Equals(obj as DialerWrapupcodemappingConfigChangeWrapUpCodeMapping);
    }

    /// <summary>
    /// Returns true if DialerWrapupcodemappingConfigChangeWrapUpCodeMapping instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerWrapupcodemappingConfigChangeWrapUpCodeMapping to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerWrapupcodemappingConfigChangeWrapUpCodeMapping other)
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

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FieldConfig
/// </summary>
[DataContract]
public partial class FieldConfig : IEquatable<FieldConfig>
{
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntityTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Person for "person"
        /// </summary>
        [EnumMember(Value = "person")]
        Person,

        /// <summary>
        /// Enum Group for "group"
        /// </summary>
        [EnumMember(Value = "group")]
        Group,

        /// <summary>
        /// Enum Org for "org"
        /// </summary>
        [EnumMember(Value = "org")]
        Org
    }
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    [DataMember(Name = "entityType", EmitDefaultValue = false)]
    public EntityTypeEnum? EntityType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FieldConfig" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="EntityType">EntityType.</param>
    /// <param name="State">State.</param>
    /// <param name="Sections">Sections.</param>
    /// <param name="Version">Version.</param>
    /// <param name="SchemaVersion">SchemaVersion.</param>
    public FieldConfig(string Name = null, EntityTypeEnum? EntityType = null, string State = null, List<Section> Sections = null, string Version = null, string SchemaVersion = null)
    {
        this.Name = Name;
        this.EntityType = EntityType;
        this.State = State;
        this.Sections = Sections;
        this.Version = Version;
        this.SchemaVersion = SchemaVersion;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }





    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public string State { get; set; }



    /// <summary>
    /// Gets or Sets Sections
    /// </summary>
    [DataMember(Name = "sections", EmitDefaultValue = false)]
    public List<Section> Sections { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public string Version { get; set; }



    /// <summary>
    /// Gets or Sets SchemaVersion
    /// </summary>
    [DataMember(Name = "schemaVersion", EmitDefaultValue = false)]
    public string SchemaVersion { get; set; }



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
        sb.Append("class FieldConfig {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Sections: ").Append(Sections).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
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
        return Equals(obj as FieldConfig);
    }

    /// <summary>
    /// Returns true if FieldConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of FieldConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FieldConfig other)
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
                EntityType == other.EntityType ||
                EntityType != null &&
                EntityType.Equals(other.EntityType)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Sections == other.Sections ||
                Sections != null &&
                Sections.SequenceEqual(other.Sections)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                SchemaVersion == other.SchemaVersion ||
                SchemaVersion != null &&
                SchemaVersion.Equals(other.SchemaVersion)
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

            if (EntityType != null)
            {
                hash = hash * 59 + EntityType.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Sections != null)
            {
                hash = hash * 59 + Sections.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (SchemaVersion != null)
            {
                hash = hash * 59 + SchemaVersion.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

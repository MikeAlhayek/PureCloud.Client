using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Metadata for a CX infrastructure as code accelerator
/// </summary>
[DataContract]
public partial class AcceleratorMetadata : IEquatable<AcceleratorMetadata>
{
    /// <summary>
    /// where the accelerator originated
    /// </summary>
    /// <value>where the accelerator originated</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OriginEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Community for "Community"
        /// </summary>
        [EnumMember(Value = "Community")]
        Community,

        /// <summary>
        /// Enum Partner for "Partner"
        /// </summary>
        [EnumMember(Value = "Partner")]
        Partner,

        /// <summary>
        /// Enum Genesys for "Genesys"
        /// </summary>
        [EnumMember(Value = "Genesys")]
        Genesys
    }
    /// <summary>
    /// type of the artifact
    /// </summary>
    /// <value>type of the artifact</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Module for "Module"
        /// </summary>
        [EnumMember(Value = "Module")]
        Module,

        /// <summary>
        /// Enum Accelerator for "Accelerator"
        /// </summary>
        [EnumMember(Value = "Accelerator")]
        Accelerator,

        /// <summary>
        /// Enum Blueprint for "Blueprint"
        /// </summary>
        [EnumMember(Value = "Blueprint")]
        Blueprint
    }
    /// <summary>
    /// where the accelerator originated
    /// </summary>
    /// <value>where the accelerator originated</value>
    [DataMember(Name = "origin", EmitDefaultValue = false)]
    public OriginEnum? Origin { get; private set; }
    /// <summary>
    /// type of the artifact
    /// </summary>
    /// <value>type of the artifact</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AcceleratorMetadata" /> class.
    /// </summary>
    public AcceleratorMetadata()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// name of this accelerator
    /// </summary>
    /// <value>name of this accelerator</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; private set; }



    /// <summary>
    /// a description of the general purpose of this accelerator
    /// </summary>
    /// <value>a description of the general purpose of this accelerator</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; private set; }







    /// <summary>
    /// architectural classification into which the accelerator belongs
    /// </summary>
    /// <value>architectural classification into which the accelerator belongs</value>
    [DataMember(Name = "classification", EmitDefaultValue = false)]
    public string Classification { get; private set; }



    /// <summary>
    /// tags
    /// </summary>
    /// <value>tags</value>
    [DataMember(Name = "tags", EmitDefaultValue = false)]
    public List<string> Tags { get; private set; }



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
        sb.Append("class AcceleratorMetadata {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Origin: ").Append(Origin).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Classification: ").Append(Classification).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
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
        return Equals(obj as AcceleratorMetadata);
    }

    /// <summary>
    /// Returns true if AcceleratorMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of AcceleratorMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AcceleratorMetadata other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Origin == other.Origin ||
                Origin != null &&
                Origin.Equals(other.Origin)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Classification == other.Classification ||
                Classification != null &&
                Classification.Equals(other.Classification)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Origin != null)
            {
                hash = hash * 59 + Origin.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Classification != null)
            {
                hash = hash * 59 + Classification.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

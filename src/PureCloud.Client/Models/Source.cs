using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Source
/// </summary>

public partial class Source : IEquatable<Source>
{
    /// <summary>
    /// The type of source
    /// </summary>
    /// <value>The type of source</value>
    
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
        /// Enum System for "System"
        /// </summary>
        [EnumMember(Value = "System")]
        System,

        /// <summary>
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User
    }
    /// <summary>
    /// The type of source
    /// </summary>
    /// <value>The type of source</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Source" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Source() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Source" /> class.
    /// </summary>
    /// <param name="Name">The name of the source (required).</param>
    /// <param name="Description">The description of the source.</param>
    /// <param name="Type">The type of source.</param>
    /// <param name="Deactivated">Deactivated.</param>
    public Source(string Name = null, string Description = null, TypeEnum? Type = null, bool? Deactivated = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Type = Type;
        this.Deactivated = Deactivated;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the source
    /// </summary>
    /// <value>The name of the source</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The description of the source
    /// </summary>
    /// <value>The description of the source</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }





    /// <summary>
    /// Gets or Sets Deactivated
    /// </summary>
    [JsonPropertyName("deactivated")]
    public bool? Deactivated { get; set; }



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
        sb.Append("class Source {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Deactivated: ").Append(Deactivated).Append("\n");
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
        return Equals(obj as Source);
    }

    /// <summary>
    /// Returns true if Source instances are equal
    /// </summary>
    /// <param name="other">Instance of Source to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Source other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Deactivated == other.Deactivated ||
                Deactivated != null &&
                Deactivated.Equals(other.Deactivated)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Deactivated != null)
            {
                hash = hash * 59 + Deactivated.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhoneBaseSettings
/// </summary>
[DataContract]
public partial class PhoneBaseSettings : IEquatable<PhoneBaseSettings>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneBaseSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PhoneBaseSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneBaseSettings" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for this phone base settings (required).</param>
    /// <param name="Name">Name.</param>
    /// <param name="SelfUri">SelfUri.</param>
    public PhoneBaseSettings(string Id = null, string Name = null, string SelfUri = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.SelfUri = SelfUri;

    }



    /// <summary>
    /// The globally unique identifier for this phone base settings
    /// </summary>
    /// <value>The globally unique identifier for this phone base settings</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhoneBaseSettings {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as PhoneBaseSettings);
    }

    /// <summary>
    /// Returns true if PhoneBaseSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of PhoneBaseSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhoneBaseSettings other)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

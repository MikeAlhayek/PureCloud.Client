using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TagValue
/// </summary>
[DataContract]
public partial class TagValue : IEquatable<TagValue>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TagValue" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TagValue() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TagValue" /> class.
    /// </summary>
    /// <param name="Name">The workspace tag name. (required).</param>
    /// <param name="InUse">InUse.</param>
    /// <param name="Acl">Acl.</param>
    public TagValue(string Name = null, bool? InUse = null, List<string> Acl = null)
    {
        this.Name = Name;
        this.InUse = InUse;
        this.Acl = Acl;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The workspace tag name.
    /// </summary>
    /// <value>The workspace tag name.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets InUse
    /// </summary>
    [DataMember(Name = "inUse", EmitDefaultValue = false)]
    public bool? InUse { get; set; }



    /// <summary>
    /// Gets or Sets Acl
    /// </summary>
    [DataMember(Name = "acl", EmitDefaultValue = false)]
    public List<string> Acl { get; set; }



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
        sb.Append("class TagValue {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  InUse: ").Append(InUse).Append("\n");
        sb.Append("  Acl: ").Append(Acl).Append("\n");
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
        return Equals(obj as TagValue);
    }

    /// <summary>
    /// Returns true if TagValue instances are equal
    /// </summary>
    /// <param name="other">Instance of TagValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TagValue other)
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
                InUse == other.InUse ||
                InUse != null &&
                InUse.Equals(other.InUse)
            ) &&
            (
                Acl == other.Acl ||
                Acl != null &&
                Acl.SequenceEqual(other.Acl)
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

            if (InUse != null)
            {
                hash = hash * 59 + InUse.GetHashCode();
            }

            if (Acl != null)
            {
                hash = hash * 59 + Acl.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

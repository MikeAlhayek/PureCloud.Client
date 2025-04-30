using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// PatchExternalSegment
/// </summary>
[DataContract]
public partial class PatchExternalSegment : IEquatable<PatchExternalSegment>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchExternalSegment" /> class.
    /// </summary>
    /// <param name="Name">Name for the external segment in the system where it originates from..</param>
    public PatchExternalSegment(string Name = null)
    {
        this.Name = Name;

    }



    /// <summary>
    /// Name for the external segment in the system where it originates from.
    /// </summary>
    /// <value>Name for the external segment in the system where it originates from.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchExternalSegment {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return this.Equals(obj as PatchExternalSegment);
    }

    /// <summary>
    /// Returns true if PatchExternalSegment instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchExternalSegment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchExternalSegment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
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
            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            return hash;
        }
    }
}

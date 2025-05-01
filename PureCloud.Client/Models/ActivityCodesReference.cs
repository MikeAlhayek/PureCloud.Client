using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ActivityCodesReference
/// </summary>
[DataContract]
public partial class ActivityCodesReference : IEquatable<ActivityCodesReference>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityCodesReference" /> class.
    /// </summary>
    /// <param name="Ids">The IDs of activity codes.</param>
    public ActivityCodesReference(List<string> Ids = null)
    {
        this.Ids = Ids;

    }



    /// <summary>
    /// The IDs of activity codes
    /// </summary>
    /// <value>The IDs of activity codes</value>
    [DataMember(Name = "ids", EmitDefaultValue = false)]
    public List<string> Ids { get; set; }



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
        sb.Append("class ActivityCodesReference {\n");

        sb.Append("  Ids: ").Append(Ids).Append("\n");
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
        return Equals(obj as ActivityCodesReference);
    }

    /// <summary>
    /// Returns true if ActivityCodesReference instances are equal
    /// </summary>
    /// <param name="other">Instance of ActivityCodesReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActivityCodesReference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Ids == other.Ids ||
                Ids != null &&
                Ids.SequenceEqual(other.Ids)
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
            if (Ids != null)
            {
                hash = hash * 59 + Ids.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

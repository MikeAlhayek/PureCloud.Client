using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// DivisionEntityRef
/// </summary>
[DataContract]
public partial class DivisionEntityRef : IEquatable<DivisionEntityRef>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DivisionEntityRef" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="DateDivisionUpdated">The time the entity division was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public DivisionEntityRef(string Id = null, string Name = null, string SelfUri = null, DateTime? DateDivisionUpdated = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.SelfUri = SelfUri;
        this.DateDivisionUpdated = DateDivisionUpdated;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
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
    /// The time the entity division was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the entity division was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateDivisionUpdated", EmitDefaultValue = false)]
    public DateTime? DateDivisionUpdated { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DivisionEntityRef {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  DateDivisionUpdated: ").Append(DateDivisionUpdated).Append("\n");
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
        return Equals(obj as DivisionEntityRef);
    }

    /// <summary>
    /// Returns true if DivisionEntityRef instances are equal
    /// </summary>
    /// <param name="other">Instance of DivisionEntityRef to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DivisionEntityRef other)
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
            ) &&
            (
                DateDivisionUpdated == other.DateDivisionUpdated ||
                DateDivisionUpdated != null &&
                DateDivisionUpdated.Equals(other.DateDivisionUpdated)
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

            if (DateDivisionUpdated != null)
            {
                hash = hash * 59 + DateDivisionUpdated.GetHashCode();
            }

            return hash;
        }
    }
}

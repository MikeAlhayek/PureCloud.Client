using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SupportCenterCategory
/// </summary>
[DataContract]
public partial class SupportCenterCategory : IEquatable<SupportCenterCategory>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterCategory" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="Image">Image attributes for a featured category.</param>
    public SupportCenterCategory(string Id = null, string SelfUri = null, SupportCenterImage Image = null)
    {
        this.Id = Id;
        this.SelfUri = SelfUri;
        this.Image = Image;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }



    /// <summary>
    /// Image attributes for a featured category
    /// </summary>
    /// <value>Image attributes for a featured category</value>
    [DataMember(Name = "image", EmitDefaultValue = false)]
    public SupportCenterImage Image { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportCenterCategory {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
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
        return Equals(obj as SupportCenterCategory);
    }

    /// <summary>
    /// Returns true if SupportCenterCategory instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportCenterCategory to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportCenterCategory other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Image == other.Image ||
                Image != null &&
                Image.Equals(other.Image)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Image != null)
            {
                hash = hash * 59 + Image.GetHashCode();
            }

            return hash;
        }
    }
}

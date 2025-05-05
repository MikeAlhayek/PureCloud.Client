using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PublishForm
/// </summary>

public partial class PublishForm : IEquatable<PublishForm>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PublishForm" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PublishForm() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PublishForm" /> class.
    /// </summary>
    /// <param name="Published">Is this form published (required).</param>
    /// <param name="Id">Unique Id for this version of this form (required).</param>
    public PublishForm(bool? Published = null, string Id = null)
    {
        this.Published = Published;
        this.Id = Id;

    }



    /// <summary>
    /// Is this form published
    /// </summary>
    /// <value>Is this form published</value>
    [JsonPropertyName("published")]
    public bool? Published { get; set; }



    /// <summary>
    /// Unique Id for this version of this form
    /// </summary>
    /// <value>Unique Id for this version of this form</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PublishForm {\n");

        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as PublishForm);
    }

    /// <summary>
    /// Returns true if PublishForm instances are equal
    /// </summary>
    /// <param name="other">Instance of PublishForm to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PublishForm other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Published == other.Published ||
                Published != null &&
                Published.Equals(other.Published)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
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
            if (Published != null)
            {
                hash = hash * 59 + Published.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            return hash;
        }
    }
}

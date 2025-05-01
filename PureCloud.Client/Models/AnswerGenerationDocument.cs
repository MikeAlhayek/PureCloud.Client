using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// AnswerGenerationDocument
/// </summary>
[DataContract]
public partial class AnswerGenerationDocument : IEquatable<AnswerGenerationDocument>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnswerGenerationDocument" /> class.
    /// </summary>
    /// <param name="Title">The document title..</param>
    public AnswerGenerationDocument(string Title = null)
    {
        this.Title = Title;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The document title.
    /// </summary>
    /// <value>The document title.</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



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
        sb.Append("class AnswerGenerationDocument {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
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
        return Equals(obj as AnswerGenerationDocument);
    }

    /// <summary>
    /// Returns true if AnswerGenerationDocument instances are equal
    /// </summary>
    /// <param name="other">Instance of AnswerGenerationDocument to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnswerGenerationDocument other)
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
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
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

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalContactsContactNoteChangedTopicDivision
/// </summary>

public partial class ExternalContactsContactNoteChangedTopicDivision : IEquatable<ExternalContactsContactNoteChangedTopicDivision>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalContactsContactNoteChangedTopicDivision" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    public ExternalContactsContactNoteChangedTopicDivision(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalContactsContactNoteChangedTopicDivision {\n");

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
        return Equals(obj as ExternalContactsContactNoteChangedTopicDivision);
    }

    /// <summary>
    /// Returns true if ExternalContactsContactNoteChangedTopicDivision instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalContactsContactNoteChangedTopicDivision to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalContactsContactNoteChangedTopicDivision other)
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

            return hash;
        }
    }
}

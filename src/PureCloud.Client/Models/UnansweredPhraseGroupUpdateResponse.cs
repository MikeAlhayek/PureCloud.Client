using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UnansweredPhraseGroupUpdateResponse
/// </summary>

public partial class UnansweredPhraseGroupUpdateResponse : IEquatable<UnansweredPhraseGroupUpdateResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnansweredPhraseGroupUpdateResponse" /> class.
    /// </summary>
    /// <param name="PhraseAssociations">List of phrases and documents linked in the patch request.</param>
    /// <param name="Group">Knowledge base unanswered group response.</param>
    public UnansweredPhraseGroupUpdateResponse(List<PhraseAssociations> PhraseAssociations = null, UnansweredGroup Group = null)
    {
        this.PhraseAssociations = PhraseAssociations;
        this.Group = Group;

    }



    /// <summary>
    /// List of phrases and documents linked in the patch request
    /// </summary>
    /// <value>List of phrases and documents linked in the patch request</value>
    [JsonPropertyName("phraseAssociations")]
    public List<PhraseAssociations> PhraseAssociations { get; set; }



    /// <summary>
    /// Knowledge base unanswered group response
    /// </summary>
    /// <value>Knowledge base unanswered group response</value>
    [JsonPropertyName("group")]
    public UnansweredGroup Group { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UnansweredPhraseGroupUpdateResponse {\n");

        sb.Append("  PhraseAssociations: ").Append(PhraseAssociations).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
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
        return Equals(obj as UnansweredPhraseGroupUpdateResponse);
    }

    /// <summary>
    /// Returns true if UnansweredPhraseGroupUpdateResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of UnansweredPhraseGroupUpdateResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UnansweredPhraseGroupUpdateResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PhraseAssociations == other.PhraseAssociations ||
                PhraseAssociations != null &&
                PhraseAssociations.SequenceEqual(other.PhraseAssociations)
            ) &&
            (
                Group == other.Group ||
                Group != null &&
                Group.Equals(other.Group)
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
            if (PhraseAssociations != null)
            {
                hash = hash * 59 + PhraseAssociations.GetHashCode();
            }

            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            return hash;
        }
    }
}

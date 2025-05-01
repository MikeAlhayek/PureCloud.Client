using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UnansweredPhraseGroup
/// </summary>
[DataContract]
public partial class UnansweredPhraseGroup : IEquatable<UnansweredPhraseGroup>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UnansweredPhraseGroup" /> class.
    /// </summary>
    /// <param name="Label">Knowledge base phrase group label.</param>
    /// <param name="Phrases">List of unanswered phrases in a phrase group.</param>
    /// <param name="UnlinkedPhraseHitCount">Hit count of the unlinked phrase group.</param>
    /// <param name="UnlinkedPhraseCount">Unique phrase count of the unlinked phrase group.</param>
    public UnansweredPhraseGroup(string Label = null, List<UnansweredPhrase> Phrases = null, int? UnlinkedPhraseHitCount = null, int? UnlinkedPhraseCount = null)
    {
        this.Label = Label;
        this.Phrases = Phrases;
        this.UnlinkedPhraseHitCount = UnlinkedPhraseHitCount;
        this.UnlinkedPhraseCount = UnlinkedPhraseCount;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Knowledge base phrase group label
    /// </summary>
    /// <value>Knowledge base phrase group label</value>
    [DataMember(Name = "label", EmitDefaultValue = false)]
    public string Label { get; set; }



    /// <summary>
    /// List of unanswered phrases in a phrase group
    /// </summary>
    /// <value>List of unanswered phrases in a phrase group</value>
    [DataMember(Name = "phrases", EmitDefaultValue = false)]
    public List<UnansweredPhrase> Phrases { get; set; }



    /// <summary>
    /// Hit count of the unlinked phrase group
    /// </summary>
    /// <value>Hit count of the unlinked phrase group</value>
    [DataMember(Name = "unlinkedPhraseHitCount", EmitDefaultValue = false)]
    public int? UnlinkedPhraseHitCount { get; set; }



    /// <summary>
    /// Unique phrase count of the unlinked phrase group
    /// </summary>
    /// <value>Unique phrase count of the unlinked phrase group</value>
    [DataMember(Name = "unlinkedPhraseCount", EmitDefaultValue = false)]
    public int? UnlinkedPhraseCount { get; set; }



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
        sb.Append("class UnansweredPhraseGroup {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Label: ").Append(Label).Append("\n");
        sb.Append("  Phrases: ").Append(Phrases).Append("\n");
        sb.Append("  UnlinkedPhraseHitCount: ").Append(UnlinkedPhraseHitCount).Append("\n");
        sb.Append("  UnlinkedPhraseCount: ").Append(UnlinkedPhraseCount).Append("\n");
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
        return Equals(obj as UnansweredPhraseGroup);
    }

    /// <summary>
    /// Returns true if UnansweredPhraseGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of UnansweredPhraseGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UnansweredPhraseGroup other)
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
                Label == other.Label ||
                Label != null &&
                Label.Equals(other.Label)
            ) &&
            (
                Phrases == other.Phrases ||
                Phrases != null &&
                Phrases.SequenceEqual(other.Phrases)
            ) &&
            (
                UnlinkedPhraseHitCount == other.UnlinkedPhraseHitCount ||
                UnlinkedPhraseHitCount != null &&
                UnlinkedPhraseHitCount.Equals(other.UnlinkedPhraseHitCount)
            ) &&
            (
                UnlinkedPhraseCount == other.UnlinkedPhraseCount ||
                UnlinkedPhraseCount != null &&
                UnlinkedPhraseCount.Equals(other.UnlinkedPhraseCount)
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

            if (Label != null)
            {
                hash = hash * 59 + Label.GetHashCode();
            }

            if (Phrases != null)
            {
                hash = hash * 59 + Phrases.GetHashCode();
            }

            if (UnlinkedPhraseHitCount != null)
            {
                hash = hash * 59 + UnlinkedPhraseHitCount.GetHashCode();
            }

            if (UnlinkedPhraseCount != null)
            {
                hash = hash * 59 + UnlinkedPhraseCount.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConfusionIntentDetails
/// </summary>

public partial class ConfusionIntentDetails : IEquatable<ConfusionIntentDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfusionIntentDetails" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="UtteranceCount">Number of utterances in this intent which are similar to parent utterance..</param>
    /// <param name="Utterances">List of utterance which are similar to parent utterance..</param>
    public ConfusionIntentDetails(string Name = null, int? UtteranceCount = null, List<ConfusionUtterance> Utterances = null)
    {
        this.Name = Name;
        this.UtteranceCount = UtteranceCount;
        this.Utterances = Utterances;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Number of utterances in this intent which are similar to parent utterance.
    /// </summary>
    /// <value>Number of utterances in this intent which are similar to parent utterance.</value>
    [JsonPropertyName("utteranceCount")]
    public int? UtteranceCount { get; set; }



    /// <summary>
    /// List of utterance which are similar to parent utterance.
    /// </summary>
    /// <value>List of utterance which are similar to parent utterance.</value>
    [JsonPropertyName("utterances")]
    public List<ConfusionUtterance> Utterances { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConfusionIntentDetails {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UtteranceCount: ").Append(UtteranceCount).Append("\n");
        sb.Append("  Utterances: ").Append(Utterances).Append("\n");
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
        return Equals(obj as ConfusionIntentDetails);
    }

    /// <summary>
    /// Returns true if ConfusionIntentDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of ConfusionIntentDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConfusionIntentDetails other)
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
                UtteranceCount == other.UtteranceCount ||
                UtteranceCount != null &&
                UtteranceCount.Equals(other.UtteranceCount)
            ) &&
            (
                Utterances == other.Utterances ||
                Utterances != null &&
                Utterances.SequenceEqual(other.Utterances)
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

            if (UtteranceCount != null)
            {
                hash = hash * 59 + UtteranceCount.GetHashCode();
            }

            if (Utterances != null)
            {
                hash = hash * 59 + Utterances.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConfusionIntentInfo
/// </summary>

public partial class ConfusionIntentInfo : IEquatable<ConfusionIntentInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfusionIntentInfo" /> class.
    /// </summary>
    /// <param name="UtteranceCount">Number of utterances in this intent which are similar to parent utterance..</param>
    public ConfusionIntentInfo(int? UtteranceCount = null)
    {
        this.UtteranceCount = UtteranceCount;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the object.
    /// </summary>
    /// <value>The name of the object.</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }



    /// <summary>
    /// Number of utterances in this intent which are similar to parent utterance.
    /// </summary>
    /// <value>Number of utterances in this intent which are similar to parent utterance.</value>
    [JsonPropertyName("utteranceCount")]
    public int? UtteranceCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConfusionIntentInfo {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  UtteranceCount: ").Append(UtteranceCount).Append("\n");
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
        return Equals(obj as ConfusionIntentInfo);
    }

    /// <summary>
    /// Returns true if ConfusionIntentInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of ConfusionIntentInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConfusionIntentInfo other)
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

            return hash;
        }
    }
}

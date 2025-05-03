using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MinerTopicPhrase
/// </summary>

public partial class MinerTopicPhrase : IEquatable<MinerTopicPhrase>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MinerTopicPhrase" /> class.
    /// </summary>
    /// <param name="Name">Phrase name..</param>
    /// <param name="Topic">Topic associated with a phrase..</param>
    /// <param name="Utterances">List of utterances related to a phrase..</param>
    /// <param name="UtteranceCount">Number of utterances belonging to a phrase.</param>
    public MinerTopicPhrase(string Name = null, MinerTopic Topic = null, List<Utterance> Utterances = null, int? UtteranceCount = null)
    {
        this.Name = Name;
        this.Topic = Topic;
        this.Utterances = Utterances;
        this.UtteranceCount = UtteranceCount;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Phrase name.
    /// </summary>
    /// <value>Phrase name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Topic associated with a phrase.
    /// </summary>
    /// <value>Topic associated with a phrase.</value>
    [JsonPropertyName("topic")]
    public MinerTopic Topic { get; set; }



    /// <summary>
    /// List of utterances related to a phrase.
    /// </summary>
    /// <value>List of utterances related to a phrase.</value>
    [JsonPropertyName("utterances")]
    public List<Utterance> Utterances { get; set; }



    /// <summary>
    /// Number of utterances belonging to a phrase
    /// </summary>
    /// <value>Number of utterances belonging to a phrase</value>
    [JsonPropertyName("utteranceCount")]
    public int? UtteranceCount { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MinerTopicPhrase {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Topic: ").Append(Topic).Append("\n");
        sb.Append("  Utterances: ").Append(Utterances).Append("\n");
        sb.Append("  UtteranceCount: ").Append(UtteranceCount).Append("\n");
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
        return Equals(obj as MinerTopicPhrase);
    }

    /// <summary>
    /// Returns true if MinerTopicPhrase instances are equal
    /// </summary>
    /// <param name="other">Instance of MinerTopicPhrase to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MinerTopicPhrase other)
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
                Topic == other.Topic ||
                Topic != null &&
                Topic.Equals(other.Topic)
            ) &&
            (
                Utterances == other.Utterances ||
                Utterances != null &&
                Utterances.SequenceEqual(other.Utterances)
            ) &&
            (
                UtteranceCount == other.UtteranceCount ||
                UtteranceCount != null &&
                UtteranceCount.Equals(other.UtteranceCount)
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

            if (Topic != null)
            {
                hash = hash * 59 + Topic.GetHashCode();
            }

            if (Utterances != null)
            {
                hash = hash * 59 + Utterances.GetHashCode();
            }

            if (UtteranceCount != null)
            {
                hash = hash * 59 + UtteranceCount.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

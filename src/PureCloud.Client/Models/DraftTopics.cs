using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DraftTopics
/// </summary>

public partial class DraftTopics : IEquatable<DraftTopics>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DraftTopics" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DraftTopics() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DraftTopics" /> class.
    /// </summary>
    /// <param name="Id">Id for a topic. (required).</param>
    /// <param name="Name">Topic name..</param>
    /// <param name="Phrases">The phrases that are extracted for a topic. (required).</param>
    public DraftTopics(string Id = null, string Name = null, List<string> Phrases = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Phrases = Phrases;

    }



    /// <summary>
    /// Id for a topic.
    /// </summary>
    /// <value>Id for a topic.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Topic name.
    /// </summary>
    /// <value>Topic name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The miner to which the topic belongs.
    /// </summary>
    /// <value>The miner to which the topic belongs.</value>
    [JsonPropertyName("miner")]
    public Miner Miner { get; set; }



    /// <summary>
    /// Number of conversations where a topic has occurred.
    /// </summary>
    /// <value>Number of conversations where a topic has occurred.</value>
    [JsonPropertyName("conversationCount")]
    public int? ConversationCount { get; set; }



    /// <summary>
    /// Percentage of conversations where a topic has occurred.
    /// </summary>
    /// <value>Percentage of conversations where a topic has occurred.</value>
    [JsonPropertyName("conversationPercent")]
    public float? ConversationPercent { get; set; }



    /// <summary>
    /// Number of unique utterances where a topic has occurred.
    /// </summary>
    /// <value>Number of unique utterances where a topic has occurred.</value>
    [JsonPropertyName("utteranceCount")]
    public int? UtteranceCount { get; set; }



    /// <summary>
    /// Number of unique phrases (sub-utterances) where a topic has occurred.
    /// </summary>
    /// <value>Number of unique phrases (sub-utterances) where a topic has occurred.</value>
    [JsonPropertyName("phraseCount")]
    public int? PhraseCount { get; set; }



    /// <summary>
    /// The phrases that are extracted for a topic.
    /// </summary>
    /// <value>The phrases that are extracted for a topic.</value>
    [JsonPropertyName("phrases")]
    public List<string> Phrases { get; set; }



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
        sb.Append("class DraftTopics {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Miner: ").Append(Miner).Append("\n");
        sb.Append("  ConversationCount: ").Append(ConversationCount).Append("\n");
        sb.Append("  ConversationPercent: ").Append(ConversationPercent).Append("\n");
        sb.Append("  UtteranceCount: ").Append(UtteranceCount).Append("\n");
        sb.Append("  PhraseCount: ").Append(PhraseCount).Append("\n");
        sb.Append("  Phrases: ").Append(Phrases).Append("\n");
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
        return Equals(obj as DraftTopics);
    }

    /// <summary>
    /// Returns true if DraftTopics instances are equal
    /// </summary>
    /// <param name="other">Instance of DraftTopics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DraftTopics other)
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
                Miner == other.Miner ||
                Miner != null &&
                Miner.Equals(other.Miner)
            ) &&
            (
                ConversationCount == other.ConversationCount ||
                ConversationCount != null &&
                ConversationCount.Equals(other.ConversationCount)
            ) &&
            (
                ConversationPercent == other.ConversationPercent ||
                ConversationPercent != null &&
                ConversationPercent.Equals(other.ConversationPercent)
            ) &&
            (
                UtteranceCount == other.UtteranceCount ||
                UtteranceCount != null &&
                UtteranceCount.Equals(other.UtteranceCount)
            ) &&
            (
                PhraseCount == other.PhraseCount ||
                PhraseCount != null &&
                PhraseCount.Equals(other.PhraseCount)
            ) &&
            (
                Phrases == other.Phrases ||
                Phrases != null &&
                Phrases.SequenceEqual(other.Phrases)
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

            if (Miner != null)
            {
                hash = hash * 59 + Miner.GetHashCode();
            }

            if (ConversationCount != null)
            {
                hash = hash * 59 + ConversationCount.GetHashCode();
            }

            if (ConversationPercent != null)
            {
                hash = hash * 59 + ConversationPercent.GetHashCode();
            }

            if (UtteranceCount != null)
            {
                hash = hash * 59 + UtteranceCount.GetHashCode();
            }

            if (PhraseCount != null)
            {
                hash = hash * 59 + PhraseCount.GetHashCode();
            }

            if (Phrases != null)
            {
                hash = hash * 59 + Phrases.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

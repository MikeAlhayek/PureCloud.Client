using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MinerTopic
/// </summary>
[DataContract]
public partial class MinerTopic : IEquatable<MinerTopic>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MinerTopic" /> class.
    /// </summary>
    /// <param name="Name">Topic name..</param>
    /// <param name="Phrases">Phrases associated with a topic..</param>
    public MinerTopic(string Name = null, List<TopicPhrase> Phrases = null)
    {
        this.Name = Name;
        this.Phrases = Phrases;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Topic name.
    /// </summary>
    /// <value>Topic name.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The miner to which the topic belongs.
    /// </summary>
    /// <value>The miner to which the topic belongs.</value>
    [DataMember(Name = "miner", EmitDefaultValue = false)]
    public Miner Miner { get; private set; }



    /// <summary>
    /// Number of conversations where a topic has occurred.
    /// </summary>
    /// <value>Number of conversations where a topic has occurred.</value>
    [DataMember(Name = "conversationCount", EmitDefaultValue = false)]
    public int? ConversationCount { get; private set; }



    /// <summary>
    /// Percentage of conversations where a topic has occurred.
    /// </summary>
    /// <value>Percentage of conversations where a topic has occurred.</value>
    [DataMember(Name = "conversationPercent", EmitDefaultValue = false)]
    public float? ConversationPercent { get; private set; }



    /// <summary>
    /// Number of unique utterances where a topic has occurred.
    /// </summary>
    /// <value>Number of unique utterances where a topic has occurred.</value>
    [DataMember(Name = "utteranceCount", EmitDefaultValue = false)]
    public int? UtteranceCount { get; private set; }



    /// <summary>
    /// Number of unique phrases (sub-utterances) where a topic has occurred.
    /// </summary>
    /// <value>Number of unique phrases (sub-utterances) where a topic has occurred.</value>
    [DataMember(Name = "phraseCount", EmitDefaultValue = false)]
    public int? PhraseCount { get; private set; }



    /// <summary>
    /// Phrases associated with a topic.
    /// </summary>
    /// <value>Phrases associated with a topic.</value>
    [DataMember(Name = "phrases", EmitDefaultValue = false)]
    public List<TopicPhrase> Phrases { get; set; }



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
        sb.Append("class MinerTopic {\n");

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
        return Equals(obj as MinerTopic);
    }

    /// <summary>
    /// Returns true if MinerTopic instances are equal
    /// </summary>
    /// <param name="other">Instance of MinerTopic to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MinerTopic other)
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

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Operand
/// </summary>
[DataContract]
public partial class Operand : IEquatable<Operand>
{
    /// <summary>
    /// The Operand type of the category
    /// </summary>
    /// <value>The Operand type of the category</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Term for "Term"
        /// </summary>
        [EnumMember(Value = "Term")]
        Term,

        /// <summary>
        /// Enum Topic for "Topic"
        /// </summary>
        [EnumMember(Value = "Topic")]
        Topic,

        /// <summary>
        /// Enum Operandgroup for "OperandGroup"
        /// </summary>
        [EnumMember(Value = "OperandGroup")]
        Operandgroup
    }
    /// <summary>
    /// The Operand type of the category
    /// </summary>
    /// <value>The Operand type of the category</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Operand" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Operand() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Operand" /> class.
    /// </summary>
    /// <param name="Type">The Operand type of the category (required).</param>
    /// <param name="Occurrence">The minimum number of occurrences of the defined operand type.</param>
    /// <param name="Inverted">Applies a NOT modifier to the operand group.</param>
    /// <param name="Term">Filter interaction by word(s).</param>
    /// <param name="TopicId">Filter interaction by topic ID.</param>
    /// <param name="VoiceSecondsPosition">Dictates when the operand must occur in a voice interaction.</param>
    /// <param name="DigitalWordsPosition">Dictates when the operand must occur in a digital interaction.</param>
    /// <param name="InfixOperator">Defines a logical operation that is applied on the current operand, against the following operand.</param>
    /// <param name="Operands">Contains a new level of operands.</param>
    public Operand(TypeEnum? Type = null, int? Occurrence = null, bool? Inverted = null, Term Term = null, string TopicId = null, OperandPosition VoiceSecondsPosition = null, OperandPosition DigitalWordsPosition = null, InfixOperator InfixOperator = null, List<Operand> Operands = null)
    {
        this.Type = Type;
        this.Occurrence = Occurrence;
        this.Inverted = Inverted;
        this.Term = Term;
        this.TopicId = TopicId;
        this.VoiceSecondsPosition = VoiceSecondsPosition;
        this.DigitalWordsPosition = DigitalWordsPosition;
        this.InfixOperator = InfixOperator;
        this.Operands = Operands;

    }





    /// <summary>
    /// The minimum number of occurrences of the defined operand type
    /// </summary>
    /// <value>The minimum number of occurrences of the defined operand type</value>
    [DataMember(Name = "occurrence", EmitDefaultValue = false)]
    public int? Occurrence { get; set; }



    /// <summary>
    /// Applies a NOT modifier to the operand group
    /// </summary>
    /// <value>Applies a NOT modifier to the operand group</value>
    [DataMember(Name = "inverted", EmitDefaultValue = false)]
    public bool? Inverted { get; set; }



    /// <summary>
    /// Filter interaction by word(s)
    /// </summary>
    /// <value>Filter interaction by word(s)</value>
    [DataMember(Name = "term", EmitDefaultValue = false)]
    public Term Term { get; set; }



    /// <summary>
    /// Filter interaction by topic ID
    /// </summary>
    /// <value>Filter interaction by topic ID</value>
    [DataMember(Name = "topicId", EmitDefaultValue = false)]
    public string TopicId { get; set; }



    /// <summary>
    /// Dictates when the operand must occur in a voice interaction
    /// </summary>
    /// <value>Dictates when the operand must occur in a voice interaction</value>
    [DataMember(Name = "voiceSecondsPosition", EmitDefaultValue = false)]
    public OperandPosition VoiceSecondsPosition { get; set; }



    /// <summary>
    /// Dictates when the operand must occur in a digital interaction
    /// </summary>
    /// <value>Dictates when the operand must occur in a digital interaction</value>
    [DataMember(Name = "digitalWordsPosition", EmitDefaultValue = false)]
    public OperandPosition DigitalWordsPosition { get; set; }



    /// <summary>
    /// Defines a logical operation that is applied on the current operand, against the following operand
    /// </summary>
    /// <value>Defines a logical operation that is applied on the current operand, against the following operand</value>
    [DataMember(Name = "infixOperator", EmitDefaultValue = false)]
    public InfixOperator InfixOperator { get; set; }



    /// <summary>
    /// Contains a new level of operands
    /// </summary>
    /// <value>Contains a new level of operands</value>
    [DataMember(Name = "operands", EmitDefaultValue = false)]
    public List<Operand> Operands { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Operand {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Occurrence: ").Append(Occurrence).Append("\n");
        sb.Append("  Inverted: ").Append(Inverted).Append("\n");
        sb.Append("  Term: ").Append(Term).Append("\n");
        sb.Append("  TopicId: ").Append(TopicId).Append("\n");
        sb.Append("  VoiceSecondsPosition: ").Append(VoiceSecondsPosition).Append("\n");
        sb.Append("  DigitalWordsPosition: ").Append(DigitalWordsPosition).Append("\n");
        sb.Append("  InfixOperator: ").Append(InfixOperator).Append("\n");
        sb.Append("  Operands: ").Append(Operands).Append("\n");
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
        return Equals(obj as Operand);
    }

    /// <summary>
    /// Returns true if Operand instances are equal
    /// </summary>
    /// <param name="other">Instance of Operand to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Operand other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Occurrence == other.Occurrence ||
                Occurrence != null &&
                Occurrence.Equals(other.Occurrence)
            ) &&
            (
                Inverted == other.Inverted ||
                Inverted != null &&
                Inverted.Equals(other.Inverted)
            ) &&
            (
                Term == other.Term ||
                Term != null &&
                Term.Equals(other.Term)
            ) &&
            (
                TopicId == other.TopicId ||
                TopicId != null &&
                TopicId.Equals(other.TopicId)
            ) &&
            (
                VoiceSecondsPosition == other.VoiceSecondsPosition ||
                VoiceSecondsPosition != null &&
                VoiceSecondsPosition.Equals(other.VoiceSecondsPosition)
            ) &&
            (
                DigitalWordsPosition == other.DigitalWordsPosition ||
                DigitalWordsPosition != null &&
                DigitalWordsPosition.Equals(other.DigitalWordsPosition)
            ) &&
            (
                InfixOperator == other.InfixOperator ||
                InfixOperator != null &&
                InfixOperator.Equals(other.InfixOperator)
            ) &&
            (
                Operands == other.Operands ||
                Operands != null &&
                Operands.SequenceEqual(other.Operands)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Occurrence != null)
            {
                hash = hash * 59 + Occurrence.GetHashCode();
            }

            if (Inverted != null)
            {
                hash = hash * 59 + Inverted.GetHashCode();
            }

            if (Term != null)
            {
                hash = hash * 59 + Term.GetHashCode();
            }

            if (TopicId != null)
            {
                hash = hash * 59 + TopicId.GetHashCode();
            }

            if (VoiceSecondsPosition != null)
            {
                hash = hash * 59 + VoiceSecondsPosition.GetHashCode();
            }

            if (DigitalWordsPosition != null)
            {
                hash = hash * 59 + DigitalWordsPosition.GetHashCode();
            }

            if (InfixOperator != null)
            {
                hash = hash * 59 + InfixOperator.GetHashCode();
            }

            if (Operands != null)
            {
                hash = hash * 59 + Operands.GetHashCode();
            }

            return hash;
        }
    }
}

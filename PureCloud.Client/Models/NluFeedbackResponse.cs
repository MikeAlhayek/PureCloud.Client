using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// NluFeedbackResponse
/// </summary>
[DataContract]
public partial class NluFeedbackResponse : IEquatable<NluFeedbackResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NluFeedbackResponse" /> class.
    /// </summary>
    /// <param name="Text">The feedback text..</param>
    /// <param name="Intents">Detected intent of the utterance.</param>
    /// <param name="Language">The language of the version to which feedback is linked, e.g. en-us, de-de.</param>
    public NluFeedbackResponse(string Text = null, List<IntentFeedback> Intents = null, string Language = null)
    {
        this.Text = Text;
        this.Intents = Intents;
        this.Language = Language;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The feedback text.
    /// </summary>
    /// <value>The feedback text.</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// Detected intent of the utterance
    /// </summary>
    /// <value>Detected intent of the utterance</value>
    [DataMember(Name = "intents", EmitDefaultValue = false)]
    public List<IntentFeedback> Intents { get; set; }



    /// <summary>
    /// The domain version of the feedback.
    /// </summary>
    /// <value>The domain version of the feedback.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public NluDomainVersion Version { get; private set; }



    /// <summary>
    /// The date when the feedback was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the feedback was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The language of the version to which feedback is linked, e.g. en-us, de-de
    /// </summary>
    /// <value>The language of the version to which feedback is linked, e.g. en-us, de-de</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; set; }



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
        sb.Append("class NluFeedbackResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Intents: ").Append(Intents).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
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
        return Equals(obj as NluFeedbackResponse);
    }

    /// <summary>
    /// Returns true if NluFeedbackResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of NluFeedbackResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluFeedbackResponse other)
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
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Intents == other.Intents ||
                Intents != null &&
                Intents.SequenceEqual(other.Intents)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
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

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Intents != null)
            {
                hash = hash * 59 + Intents.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

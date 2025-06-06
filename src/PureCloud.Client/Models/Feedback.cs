using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Feedback
/// </summary>

public partial class Feedback : IEquatable<Feedback>
{
    /// <summary>
    /// Feedback relevance.
    /// </summary>
    /// <value>Feedback relevance.</value>
    
    public enum RelevanceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Relevant for "Relevant"
        /// </summary>
        [EnumMember(Value = "Relevant")]
        Relevant,

        /// <summary>
        /// Enum Irrelevant for "Irrelevant"
        /// </summary>
        [EnumMember(Value = "Irrelevant")]
        Irrelevant
    }
    /// <summary>
    /// Feedback relevance.
    /// </summary>
    /// <value>Feedback relevance.</value>
    [JsonPropertyName("relevance")]
    public RelevanceEnum? Relevance { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Feedback" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Feedback() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Feedback" /> class.
    /// </summary>
    /// <param name="SuggestionId">Feedback suggestion id. (required).</param>
    /// <param name="UserProvided">Indicates whether the answer/item was clicked by the human agent or not..</param>
    /// <param name="Relevance">Feedback relevance. (required).</param>
    public Feedback(string SuggestionId = null, bool? UserProvided = null, RelevanceEnum? Relevance = null)
    {
        this.SuggestionId = SuggestionId;
        this.UserProvided = UserProvided;
        this.Relevance = Relevance;

    }



    /// <summary>
    /// Feedback suggestion id.
    /// </summary>
    /// <value>Feedback suggestion id.</value>
    [JsonPropertyName("suggestionId")]
    public string SuggestionId { get; set; }



    /// <summary>
    /// Indicates whether the answer/item was clicked by the human agent or not.
    /// </summary>
    /// <value>Indicates whether the answer/item was clicked by the human agent or not.</value>
    [JsonPropertyName("userProvided")]
    public bool? UserProvided { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Feedback {\n");

        sb.Append("  SuggestionId: ").Append(SuggestionId).Append("\n");
        sb.Append("  UserProvided: ").Append(UserProvided).Append("\n");
        sb.Append("  Relevance: ").Append(Relevance).Append("\n");
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
        return Equals(obj as Feedback);
    }

    /// <summary>
    /// Returns true if Feedback instances are equal
    /// </summary>
    /// <param name="other">Instance of Feedback to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Feedback other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SuggestionId == other.SuggestionId ||
                SuggestionId != null &&
                SuggestionId.Equals(other.SuggestionId)
            ) &&
            (
                UserProvided == other.UserProvided ||
                UserProvided != null &&
                UserProvided.Equals(other.UserProvided)
            ) &&
            (
                Relevance == other.Relevance ||
                Relevance != null &&
                Relevance.Equals(other.Relevance)
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
            if (SuggestionId != null)
            {
                hash = hash * 59 + SuggestionId.GetHashCode();
            }

            if (UserProvided != null)
            {
                hash = hash * 59 + UserProvided.GetHashCode();
            }

            if (Relevance != null)
            {
                hash = hash * 59 + Relevance.GetHashCode();
            }

            return hash;
        }
    }
}

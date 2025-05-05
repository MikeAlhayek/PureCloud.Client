using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationInsight
/// </summary>

public partial class ConversationInsight : IEquatable<ConversationInsight>
{
    /// <summary>
    /// The type of insight
    /// </summary>
    /// <value>The type of insight</value>
    
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
        /// Enum Reason for "Reason"
        /// </summary>
        [EnumMember(Value = "Reason")]
        Reason,

        /// <summary>
        /// Enum Resolution for "Resolution"
        /// </summary>
        [EnumMember(Value = "Resolution")]
        Resolution,

        /// <summary>
        /// Enum Actionitem for "ActionItem"
        /// </summary>
        [EnumMember(Value = "ActionItem")]
        Actionitem
    }
    /// <summary>
    /// The type of insight
    /// </summary>
    /// <value>The type of insight</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationInsight" /> class.
    /// </summary>
    /// <param name="Type">The type of insight.</param>
    /// <param name="Title">The reason for contact, resolution for the interaction, or follow-up action item.</param>
    /// <param name="Description">Reasoning for the given insight.</param>
    /// <param name="Outcome">The outcome of a given resolution insight.</param>
    public ConversationInsight(TypeEnum? Type = null, string Title = null, string Description = null, string Outcome = null)
    {
        this.Type = Type;
        this.Title = Title;
        this.Description = Description;
        this.Outcome = Outcome;

    }





    /// <summary>
    /// The reason for contact, resolution for the interaction, or follow-up action item
    /// </summary>
    /// <value>The reason for contact, resolution for the interaction, or follow-up action item</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// Reasoning for the given insight
    /// </summary>
    /// <value>Reasoning for the given insight</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The outcome of a given resolution insight
    /// </summary>
    /// <value>The outcome of a given resolution insight</value>
    [JsonPropertyName("outcome")]
    public string Outcome { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationInsight {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Outcome: ").Append(Outcome).Append("\n");
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
        return Equals(obj as ConversationInsight);
    }

    /// <summary>
    /// Returns true if ConversationInsight instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationInsight to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationInsight other)
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
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Outcome == other.Outcome ||
                Outcome != null &&
                Outcome.Equals(other.Outcome)
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

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Outcome != null)
            {
                hash = hash * 59 + Outcome.GetHashCode();
            }

            return hash;
        }
    }
}

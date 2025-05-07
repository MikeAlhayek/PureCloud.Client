using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationSummaryWrapupCode
/// </summary>

public partial class ConversationSummaryWrapupCode : IEquatable<ConversationSummaryWrapupCode>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSummaryWrapupCode" /> class.
    /// </summary>
    /// <param name="Name">The name of the wrapup code..</param>
    /// <param name="Description">The description of the wrapup code..</param>
    public ConversationSummaryWrapupCode(string Name = null, string Description = null)
    {
        this.Name = Name;
        this.Description = Description;

    }



    /// <summary>
    /// The name of the wrapup code.
    /// </summary>
    /// <value>The name of the wrapup code.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The description of the wrapup code.
    /// </summary>
    /// <value>The description of the wrapup code.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// The id of the wrapup code.
    /// </summary>
    /// <value>The id of the wrapup code.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The AI confidence value.
    /// </summary>
    /// <value>The AI confidence value.</value>
    [JsonPropertyName("confidence")]
    public float? Confidence { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationSummaryWrapupCode {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
        return Equals(obj as ConversationSummaryWrapupCode);
    }

    /// <summary>
    /// Returns true if ConversationSummaryWrapupCode instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSummaryWrapupCode to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSummaryWrapupCode other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Confidence == other.Confidence ||
                Confidence != null &&
                Confidence.Equals(other.Confidence)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            return hash;
        }
    }
}

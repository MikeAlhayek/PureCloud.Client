using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// The error message params, if the action failed
/// </summary>
[DataContract]
public partial class ArchitectPromptNotificationErrorMessageParams : IEquatable<ArchitectPromptNotificationErrorMessageParams>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectPromptNotificationErrorMessageParams" /> class.
    /// </summary>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public ArchitectPromptNotificationErrorMessageParams(Dictionary<string, string> AdditionalProperties = null)
    {
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, string> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectPromptNotificationErrorMessageParams {\n");

        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return this.Equals(obj as ArchitectPromptNotificationErrorMessageParams);
    }

    /// <summary>
    /// Returns true if ArchitectPromptNotificationErrorMessageParams instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectPromptNotificationErrorMessageParams to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectPromptNotificationErrorMessageParams other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.AdditionalProperties == other.AdditionalProperties ||
                this.AdditionalProperties != null &&
                this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (this.AdditionalProperties != null)
            {
                hash = hash * 59 + this.AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LastResultOverallConditionSettings
/// </summary>

public partial class LastResultOverallConditionSettings : IEquatable<LastResultOverallConditionSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LastResultOverallConditionSettings" /> class.
    /// </summary>
    /// <param name="EmailWrapupCodes">A list of wrapup code identifiers to match for Email..</param>
    /// <param name="SmsWrapupCodes">A list of wrapup code identifiers to match for SMS..</param>
    public LastResultOverallConditionSettings(List<string> EmailWrapupCodes = null, List<string> SmsWrapupCodes = null)
    {
        this.EmailWrapupCodes = EmailWrapupCodes;
        this.SmsWrapupCodes = SmsWrapupCodes;

    }



    /// <summary>
    /// A list of wrapup code identifiers to match for Email.
    /// </summary>
    /// <value>A list of wrapup code identifiers to match for Email.</value>
    [JsonPropertyName("emailWrapupCodes")]
    public List<string> EmailWrapupCodes { get; set; }



    /// <summary>
    /// A list of wrapup code identifiers to match for SMS.
    /// </summary>
    /// <value>A list of wrapup code identifiers to match for SMS.</value>
    [JsonPropertyName("smsWrapupCodes")]
    public List<string> SmsWrapupCodes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LastResultOverallConditionSettings {\n");

        sb.Append("  EmailWrapupCodes: ").Append(EmailWrapupCodes).Append("\n");
        sb.Append("  SmsWrapupCodes: ").Append(SmsWrapupCodes).Append("\n");
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
        return Equals(obj as LastResultOverallConditionSettings);
    }

    /// <summary>
    /// Returns true if LastResultOverallConditionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of LastResultOverallConditionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LastResultOverallConditionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EmailWrapupCodes == other.EmailWrapupCodes ||
                EmailWrapupCodes != null &&
                EmailWrapupCodes.SequenceEqual(other.EmailWrapupCodes)
            ) &&
            (
                SmsWrapupCodes == other.SmsWrapupCodes ||
                SmsWrapupCodes != null &&
                SmsWrapupCodes.SequenceEqual(other.SmsWrapupCodes)
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
            if (EmailWrapupCodes != null)
            {
                hash = hash * 59 + EmailWrapupCodes.GetHashCode();
            }

            if (SmsWrapupCodes != null)
            {
                hash = hash * 59 + SmsWrapupCodes.GetHashCode();
            }

            return hash;
        }
    }
}

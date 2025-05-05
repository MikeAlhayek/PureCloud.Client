using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LastResultByColumnConditionSettings
/// </summary>

public partial class LastResultByColumnConditionSettings : IEquatable<LastResultByColumnConditionSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LastResultByColumnConditionSettings" /> class.
    /// </summary>
    /// <param name="EmailColumnName">The name of the contact column to evaluate for Email..</param>
    /// <param name="EmailWrapupCodes">A list of wrapup code identifiers to match for Email..</param>
    /// <param name="SmsColumnName">The name of the contact column to evaluate for SMS..</param>
    /// <param name="SmsWrapupCodes">A list of wrapup code identifiers to match for SMS..</param>
    public LastResultByColumnConditionSettings(string EmailColumnName = null, List<string> EmailWrapupCodes = null, string SmsColumnName = null, List<string> SmsWrapupCodes = null)
    {
        this.EmailColumnName = EmailColumnName;
        this.EmailWrapupCodes = EmailWrapupCodes;
        this.SmsColumnName = SmsColumnName;
        this.SmsWrapupCodes = SmsWrapupCodes;

    }



    /// <summary>
    /// The name of the contact column to evaluate for Email.
    /// </summary>
    /// <value>The name of the contact column to evaluate for Email.</value>
    [JsonPropertyName("emailColumnName")]
    public string EmailColumnName { get; set; }



    /// <summary>
    /// A list of wrapup code identifiers to match for Email.
    /// </summary>
    /// <value>A list of wrapup code identifiers to match for Email.</value>
    [JsonPropertyName("emailWrapupCodes")]
    public List<string> EmailWrapupCodes { get; set; }



    /// <summary>
    /// The name of the contact column to evaluate for SMS.
    /// </summary>
    /// <value>The name of the contact column to evaluate for SMS.</value>
    [JsonPropertyName("smsColumnName")]
    public string SmsColumnName { get; set; }



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
        sb.Append("class LastResultByColumnConditionSettings {\n");

        sb.Append("  EmailColumnName: ").Append(EmailColumnName).Append("\n");
        sb.Append("  EmailWrapupCodes: ").Append(EmailWrapupCodes).Append("\n");
        sb.Append("  SmsColumnName: ").Append(SmsColumnName).Append("\n");
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
        return Equals(obj as LastResultByColumnConditionSettings);
    }

    /// <summary>
    /// Returns true if LastResultByColumnConditionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of LastResultByColumnConditionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LastResultByColumnConditionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EmailColumnName == other.EmailColumnName ||
                EmailColumnName != null &&
                EmailColumnName.Equals(other.EmailColumnName)
            ) &&
            (
                EmailWrapupCodes == other.EmailWrapupCodes ||
                EmailWrapupCodes != null &&
                EmailWrapupCodes.SequenceEqual(other.EmailWrapupCodes)
            ) &&
            (
                SmsColumnName == other.SmsColumnName ||
                SmsColumnName != null &&
                SmsColumnName.Equals(other.SmsColumnName)
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
            if (EmailColumnName != null)
            {
                hash = hash * 59 + EmailColumnName.GetHashCode();
            }

            if (EmailWrapupCodes != null)
            {
                hash = hash * 59 + EmailWrapupCodes.GetHashCode();
            }

            if (SmsColumnName != null)
            {
                hash = hash * 59 + SmsColumnName.GetHashCode();
            }

            if (SmsWrapupCodes != null)
            {
                hash = hash * 59 + SmsWrapupCodes.GetHashCode();
            }

            return hash;
        }
    }
}

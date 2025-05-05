using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DigitalCondition
/// </summary>

public partial class DigitalCondition : IEquatable<DigitalCondition>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DigitalCondition" /> class.
    /// </summary>
    /// <param name="Inverted">If true, inverts the result of evaluating this condition. Default is false..</param>
    /// <param name="ContactColumnConditionSettings">The settings for a &#39;contact list column&#39; condition..</param>
    /// <param name="ContactAddressConditionSettings">The settings for a &#39;contact address&#39; condition..</param>
    /// <param name="ContactAddressTypeConditionSettings">The settings for a &#39;contact address type&#39; condition..</param>
    /// <param name="LastAttemptByColumnConditionSettings">The settings for a &#39;last attempt by column&#39; condition..</param>
    /// <param name="LastAttemptOverallConditionSettings">The settings for a &#39;last attempt overall&#39; condition..</param>
    /// <param name="LastResultByColumnConditionSettings">The settings for a &#39;last result by column&#39; condition..</param>
    /// <param name="LastResultOverallConditionSettings">The settings for a &#39;last result overall&#39; condition..</param>
    /// <param name="DataActionConditionSettings">The settings for a &#39;data action&#39; condition..</param>
    public DigitalCondition(bool? Inverted = null, ContactColumnConditionSettings ContactColumnConditionSettings = null, ContactAddressConditionSettings ContactAddressConditionSettings = null, ContactAddressTypeConditionSettings ContactAddressTypeConditionSettings = null, LastAttemptByColumnConditionSettings LastAttemptByColumnConditionSettings = null, LastAttemptOverallConditionSettings LastAttemptOverallConditionSettings = null, LastResultByColumnConditionSettings LastResultByColumnConditionSettings = null, LastResultOverallConditionSettings LastResultOverallConditionSettings = null, DataActionConditionSettings DataActionConditionSettings = null)
    {
        this.Inverted = Inverted;
        this.ContactColumnConditionSettings = ContactColumnConditionSettings;
        this.ContactAddressConditionSettings = ContactAddressConditionSettings;
        this.ContactAddressTypeConditionSettings = ContactAddressTypeConditionSettings;
        this.LastAttemptByColumnConditionSettings = LastAttemptByColumnConditionSettings;
        this.LastAttemptOverallConditionSettings = LastAttemptOverallConditionSettings;
        this.LastResultByColumnConditionSettings = LastResultByColumnConditionSettings;
        this.LastResultOverallConditionSettings = LastResultOverallConditionSettings;
        this.DataActionConditionSettings = DataActionConditionSettings;

    }



    /// <summary>
    /// If true, inverts the result of evaluating this condition. Default is false.
    /// </summary>
    /// <value>If true, inverts the result of evaluating this condition. Default is false.</value>
    [JsonPropertyName("inverted")]
    public bool? Inverted { get; set; }



    /// <summary>
    /// The settings for a &#39;contact list column&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;contact list column&#39; condition.</value>
    [JsonPropertyName("contactColumnConditionSettings")]
    public ContactColumnConditionSettings ContactColumnConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;contact address&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;contact address&#39; condition.</value>
    [JsonPropertyName("contactAddressConditionSettings")]
    public ContactAddressConditionSettings ContactAddressConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;contact address type&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;contact address type&#39; condition.</value>
    [JsonPropertyName("contactAddressTypeConditionSettings")]
    public ContactAddressTypeConditionSettings ContactAddressTypeConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;last attempt by column&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;last attempt by column&#39; condition.</value>
    [JsonPropertyName("lastAttemptByColumnConditionSettings")]
    public LastAttemptByColumnConditionSettings LastAttemptByColumnConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;last attempt overall&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;last attempt overall&#39; condition.</value>
    [JsonPropertyName("lastAttemptOverallConditionSettings")]
    public LastAttemptOverallConditionSettings LastAttemptOverallConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;last result by column&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;last result by column&#39; condition.</value>
    [JsonPropertyName("lastResultByColumnConditionSettings")]
    public LastResultByColumnConditionSettings LastResultByColumnConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;last result overall&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;last result overall&#39; condition.</value>
    [JsonPropertyName("lastResultOverallConditionSettings")]
    public LastResultOverallConditionSettings LastResultOverallConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;data action&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;data action&#39; condition.</value>
    [JsonPropertyName("dataActionConditionSettings")]
    public DataActionConditionSettings DataActionConditionSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DigitalCondition {\n");

        sb.Append("  Inverted: ").Append(Inverted).Append("\n");
        sb.Append("  ContactColumnConditionSettings: ").Append(ContactColumnConditionSettings).Append("\n");
        sb.Append("  ContactAddressConditionSettings: ").Append(ContactAddressConditionSettings).Append("\n");
        sb.Append("  ContactAddressTypeConditionSettings: ").Append(ContactAddressTypeConditionSettings).Append("\n");
        sb.Append("  LastAttemptByColumnConditionSettings: ").Append(LastAttemptByColumnConditionSettings).Append("\n");
        sb.Append("  LastAttemptOverallConditionSettings: ").Append(LastAttemptOverallConditionSettings).Append("\n");
        sb.Append("  LastResultByColumnConditionSettings: ").Append(LastResultByColumnConditionSettings).Append("\n");
        sb.Append("  LastResultOverallConditionSettings: ").Append(LastResultOverallConditionSettings).Append("\n");
        sb.Append("  DataActionConditionSettings: ").Append(DataActionConditionSettings).Append("\n");
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
        return Equals(obj as DigitalCondition);
    }

    /// <summary>
    /// Returns true if DigitalCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of DigitalCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DigitalCondition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Inverted == other.Inverted ||
                Inverted != null &&
                Inverted.Equals(other.Inverted)
            ) &&
            (
                ContactColumnConditionSettings == other.ContactColumnConditionSettings ||
                ContactColumnConditionSettings != null &&
                ContactColumnConditionSettings.Equals(other.ContactColumnConditionSettings)
            ) &&
            (
                ContactAddressConditionSettings == other.ContactAddressConditionSettings ||
                ContactAddressConditionSettings != null &&
                ContactAddressConditionSettings.Equals(other.ContactAddressConditionSettings)
            ) &&
            (
                ContactAddressTypeConditionSettings == other.ContactAddressTypeConditionSettings ||
                ContactAddressTypeConditionSettings != null &&
                ContactAddressTypeConditionSettings.Equals(other.ContactAddressTypeConditionSettings)
            ) &&
            (
                LastAttemptByColumnConditionSettings == other.LastAttemptByColumnConditionSettings ||
                LastAttemptByColumnConditionSettings != null &&
                LastAttemptByColumnConditionSettings.Equals(other.LastAttemptByColumnConditionSettings)
            ) &&
            (
                LastAttemptOverallConditionSettings == other.LastAttemptOverallConditionSettings ||
                LastAttemptOverallConditionSettings != null &&
                LastAttemptOverallConditionSettings.Equals(other.LastAttemptOverallConditionSettings)
            ) &&
            (
                LastResultByColumnConditionSettings == other.LastResultByColumnConditionSettings ||
                LastResultByColumnConditionSettings != null &&
                LastResultByColumnConditionSettings.Equals(other.LastResultByColumnConditionSettings)
            ) &&
            (
                LastResultOverallConditionSettings == other.LastResultOverallConditionSettings ||
                LastResultOverallConditionSettings != null &&
                LastResultOverallConditionSettings.Equals(other.LastResultOverallConditionSettings)
            ) &&
            (
                DataActionConditionSettings == other.DataActionConditionSettings ||
                DataActionConditionSettings != null &&
                DataActionConditionSettings.Equals(other.DataActionConditionSettings)
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
            if (Inverted != null)
            {
                hash = hash * 59 + Inverted.GetHashCode();
            }

            if (ContactColumnConditionSettings != null)
            {
                hash = hash * 59 + ContactColumnConditionSettings.GetHashCode();
            }

            if (ContactAddressConditionSettings != null)
            {
                hash = hash * 59 + ContactAddressConditionSettings.GetHashCode();
            }

            if (ContactAddressTypeConditionSettings != null)
            {
                hash = hash * 59 + ContactAddressTypeConditionSettings.GetHashCode();
            }

            if (LastAttemptByColumnConditionSettings != null)
            {
                hash = hash * 59 + LastAttemptByColumnConditionSettings.GetHashCode();
            }

            if (LastAttemptOverallConditionSettings != null)
            {
                hash = hash * 59 + LastAttemptOverallConditionSettings.GetHashCode();
            }

            if (LastResultByColumnConditionSettings != null)
            {
                hash = hash * 59 + LastResultByColumnConditionSettings.GetHashCode();
            }

            if (LastResultOverallConditionSettings != null)
            {
                hash = hash * 59 + LastResultOverallConditionSettings.GetHashCode();
            }

            if (DataActionConditionSettings != null)
            {
                hash = hash * 59 + DataActionConditionSettings.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// DigitalCondition
/// </summary>
[DataContract]
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
    [DataMember(Name = "inverted", EmitDefaultValue = false)]
    public bool? Inverted { get; set; }



    /// <summary>
    /// The settings for a &#39;contact list column&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;contact list column&#39; condition.</value>
    [DataMember(Name = "contactColumnConditionSettings", EmitDefaultValue = false)]
    public ContactColumnConditionSettings ContactColumnConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;contact address&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;contact address&#39; condition.</value>
    [DataMember(Name = "contactAddressConditionSettings", EmitDefaultValue = false)]
    public ContactAddressConditionSettings ContactAddressConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;contact address type&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;contact address type&#39; condition.</value>
    [DataMember(Name = "contactAddressTypeConditionSettings", EmitDefaultValue = false)]
    public ContactAddressTypeConditionSettings ContactAddressTypeConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;last attempt by column&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;last attempt by column&#39; condition.</value>
    [DataMember(Name = "lastAttemptByColumnConditionSettings", EmitDefaultValue = false)]
    public LastAttemptByColumnConditionSettings LastAttemptByColumnConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;last attempt overall&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;last attempt overall&#39; condition.</value>
    [DataMember(Name = "lastAttemptOverallConditionSettings", EmitDefaultValue = false)]
    public LastAttemptOverallConditionSettings LastAttemptOverallConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;last result by column&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;last result by column&#39; condition.</value>
    [DataMember(Name = "lastResultByColumnConditionSettings", EmitDefaultValue = false)]
    public LastResultByColumnConditionSettings LastResultByColumnConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;last result overall&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;last result overall&#39; condition.</value>
    [DataMember(Name = "lastResultOverallConditionSettings", EmitDefaultValue = false)]
    public LastResultOverallConditionSettings LastResultOverallConditionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;data action&#39; condition.
    /// </summary>
    /// <value>The settings for a &#39;data action&#39; condition.</value>
    [DataMember(Name = "dataActionConditionSettings", EmitDefaultValue = false)]
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
        return this.Equals(obj as DigitalCondition);
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
                this.Inverted == other.Inverted ||
                this.Inverted != null &&
                this.Inverted.Equals(other.Inverted)
            ) &&
            (
                this.ContactColumnConditionSettings == other.ContactColumnConditionSettings ||
                this.ContactColumnConditionSettings != null &&
                this.ContactColumnConditionSettings.Equals(other.ContactColumnConditionSettings)
            ) &&
            (
                this.ContactAddressConditionSettings == other.ContactAddressConditionSettings ||
                this.ContactAddressConditionSettings != null &&
                this.ContactAddressConditionSettings.Equals(other.ContactAddressConditionSettings)
            ) &&
            (
                this.ContactAddressTypeConditionSettings == other.ContactAddressTypeConditionSettings ||
                this.ContactAddressTypeConditionSettings != null &&
                this.ContactAddressTypeConditionSettings.Equals(other.ContactAddressTypeConditionSettings)
            ) &&
            (
                this.LastAttemptByColumnConditionSettings == other.LastAttemptByColumnConditionSettings ||
                this.LastAttemptByColumnConditionSettings != null &&
                this.LastAttemptByColumnConditionSettings.Equals(other.LastAttemptByColumnConditionSettings)
            ) &&
            (
                this.LastAttemptOverallConditionSettings == other.LastAttemptOverallConditionSettings ||
                this.LastAttemptOverallConditionSettings != null &&
                this.LastAttemptOverallConditionSettings.Equals(other.LastAttemptOverallConditionSettings)
            ) &&
            (
                this.LastResultByColumnConditionSettings == other.LastResultByColumnConditionSettings ||
                this.LastResultByColumnConditionSettings != null &&
                this.LastResultByColumnConditionSettings.Equals(other.LastResultByColumnConditionSettings)
            ) &&
            (
                this.LastResultOverallConditionSettings == other.LastResultOverallConditionSettings ||
                this.LastResultOverallConditionSettings != null &&
                this.LastResultOverallConditionSettings.Equals(other.LastResultOverallConditionSettings)
            ) &&
            (
                this.DataActionConditionSettings == other.DataActionConditionSettings ||
                this.DataActionConditionSettings != null &&
                this.DataActionConditionSettings.Equals(other.DataActionConditionSettings)
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
            if (this.Inverted != null)
            {
                hash = hash * 59 + this.Inverted.GetHashCode();
            }

            if (this.ContactColumnConditionSettings != null)
            {
                hash = hash * 59 + this.ContactColumnConditionSettings.GetHashCode();
            }

            if (this.ContactAddressConditionSettings != null)
            {
                hash = hash * 59 + this.ContactAddressConditionSettings.GetHashCode();
            }

            if (this.ContactAddressTypeConditionSettings != null)
            {
                hash = hash * 59 + this.ContactAddressTypeConditionSettings.GetHashCode();
            }

            if (this.LastAttemptByColumnConditionSettings != null)
            {
                hash = hash * 59 + this.LastAttemptByColumnConditionSettings.GetHashCode();
            }

            if (this.LastAttemptOverallConditionSettings != null)
            {
                hash = hash * 59 + this.LastAttemptOverallConditionSettings.GetHashCode();
            }

            if (this.LastResultByColumnConditionSettings != null)
            {
                hash = hash * 59 + this.LastResultByColumnConditionSettings.GetHashCode();
            }

            if (this.LastResultOverallConditionSettings != null)
            {
                hash = hash * 59 + this.LastResultOverallConditionSettings.GetHashCode();
            }

            if (this.DataActionConditionSettings != null)
            {
                hash = hash * 59 + this.DataActionConditionSettings.GetHashCode();
            }

            return hash;
        }
    }
}

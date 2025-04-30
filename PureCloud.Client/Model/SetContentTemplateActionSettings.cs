using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// SetContentTemplateActionSettings
/// </summary>
[DataContract]
public partial class SetContentTemplateActionSettings : IEquatable<SetContentTemplateActionSettings>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SetContentTemplateActionSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SetContentTemplateActionSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SetContentTemplateActionSettings" /> class.
    /// </summary>
    /// <param name="SmsContentTemplateId">A string of sms contentTemplateId. (required).</param>
    /// <param name="EmailContentTemplateId">A string of email contentTemplateId. (required).</param>
    public SetContentTemplateActionSettings(string SmsContentTemplateId = null, string EmailContentTemplateId = null)
    {
        this.SmsContentTemplateId = SmsContentTemplateId;
        this.EmailContentTemplateId = EmailContentTemplateId;

    }



    /// <summary>
    /// A string of sms contentTemplateId.
    /// </summary>
    /// <value>A string of sms contentTemplateId.</value>
    [DataMember(Name = "smsContentTemplateId", EmitDefaultValue = false)]
    public string SmsContentTemplateId { get; set; }



    /// <summary>
    /// A string of email contentTemplateId.
    /// </summary>
    /// <value>A string of email contentTemplateId.</value>
    [DataMember(Name = "emailContentTemplateId", EmitDefaultValue = false)]
    public string EmailContentTemplateId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SetContentTemplateActionSettings {\n");

        sb.Append("  SmsContentTemplateId: ").Append(SmsContentTemplateId).Append("\n");
        sb.Append("  EmailContentTemplateId: ").Append(EmailContentTemplateId).Append("\n");
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
        return this.Equals(obj as SetContentTemplateActionSettings);
    }

    /// <summary>
    /// Returns true if SetContentTemplateActionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of SetContentTemplateActionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SetContentTemplateActionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.SmsContentTemplateId == other.SmsContentTemplateId ||
                this.SmsContentTemplateId != null &&
                this.SmsContentTemplateId.Equals(other.SmsContentTemplateId)
            ) &&
            (
                this.EmailContentTemplateId == other.EmailContentTemplateId ||
                this.EmailContentTemplateId != null &&
                this.EmailContentTemplateId.Equals(other.EmailContentTemplateId)
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
            if (this.SmsContentTemplateId != null)
            {
                hash = hash * 59 + this.SmsContentTemplateId.GetHashCode();
            }

            if (this.EmailContentTemplateId != null)
            {
                hash = hash * 59 + this.EmailContentTemplateId.GetHashCode();
            }

            return hash;
        }
    }
}

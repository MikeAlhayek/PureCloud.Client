using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// DigitalAction
/// </summary>
[DataContract]
public partial class DigitalAction : IEquatable<DigitalAction>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DigitalAction" /> class.
    /// </summary>
    /// <param name="UpdateContactColumnActionSettings">The settings for an &#39;update contact column&#39; action..</param>
    /// <param name="DoNotSendActionSettings">The settings for a &#39;do not send&#39; action..</param>
    /// <param name="AppendToDncActionSettings">The settings for an &#39;Append to DNC&#39; action..</param>
    /// <param name="MarkContactUncontactableActionSettings">The settings for a &#39;mark contact uncontactable&#39; action..</param>
    /// <param name="MarkContactAddressUncontactableActionSettings">The settings for an &#39;mark contact address uncontactable&#39; action..</param>
    /// <param name="SetContentTemplateActionSettings">The settings for a &#39;Set content template&#39; action..</param>
    /// <param name="SetSmsPhoneNumberActionSettings">The settings for a &#39;set sms phone number&#39; action..</param>
    public DigitalAction(UpdateContactColumnActionSettings UpdateContactColumnActionSettings = null, object DoNotSendActionSettings = null, AppendToDncActionSettings AppendToDncActionSettings = null, MarkContactUncontactableActionSettings MarkContactUncontactableActionSettings = null, object MarkContactAddressUncontactableActionSettings = null, SetContentTemplateActionSettings SetContentTemplateActionSettings = null, SetSmsPhoneNumberActionSettings SetSmsPhoneNumberActionSettings = null)
    {
        this.UpdateContactColumnActionSettings = UpdateContactColumnActionSettings;
        this.DoNotSendActionSettings = DoNotSendActionSettings;
        this.AppendToDncActionSettings = AppendToDncActionSettings;
        this.MarkContactUncontactableActionSettings = MarkContactUncontactableActionSettings;
        this.MarkContactAddressUncontactableActionSettings = MarkContactAddressUncontactableActionSettings;
        this.SetContentTemplateActionSettings = SetContentTemplateActionSettings;
        this.SetSmsPhoneNumberActionSettings = SetSmsPhoneNumberActionSettings;

    }



    /// <summary>
    /// The settings for an &#39;update contact column&#39; action.
    /// </summary>
    /// <value>The settings for an &#39;update contact column&#39; action.</value>
    [DataMember(Name = "updateContactColumnActionSettings", EmitDefaultValue = false)]
    public UpdateContactColumnActionSettings UpdateContactColumnActionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;do not send&#39; action.
    /// </summary>
    /// <value>The settings for a &#39;do not send&#39; action.</value>
    [DataMember(Name = "doNotSendActionSettings", EmitDefaultValue = false)]
    public object DoNotSendActionSettings { get; set; }



    /// <summary>
    /// The settings for an &#39;Append to DNC&#39; action.
    /// </summary>
    /// <value>The settings for an &#39;Append to DNC&#39; action.</value>
    [DataMember(Name = "appendToDncActionSettings", EmitDefaultValue = false)]
    public AppendToDncActionSettings AppendToDncActionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;mark contact uncontactable&#39; action.
    /// </summary>
    /// <value>The settings for a &#39;mark contact uncontactable&#39; action.</value>
    [DataMember(Name = "markContactUncontactableActionSettings", EmitDefaultValue = false)]
    public MarkContactUncontactableActionSettings MarkContactUncontactableActionSettings { get; set; }



    /// <summary>
    /// The settings for an &#39;mark contact address uncontactable&#39; action.
    /// </summary>
    /// <value>The settings for an &#39;mark contact address uncontactable&#39; action.</value>
    [DataMember(Name = "markContactAddressUncontactableActionSettings", EmitDefaultValue = false)]
    public object MarkContactAddressUncontactableActionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;Set content template&#39; action.
    /// </summary>
    /// <value>The settings for a &#39;Set content template&#39; action.</value>
    [DataMember(Name = "setContentTemplateActionSettings", EmitDefaultValue = false)]
    public SetContentTemplateActionSettings SetContentTemplateActionSettings { get; set; }



    /// <summary>
    /// The settings for a &#39;set sms phone number&#39; action.
    /// </summary>
    /// <value>The settings for a &#39;set sms phone number&#39; action.</value>
    [DataMember(Name = "setSmsPhoneNumberActionSettings", EmitDefaultValue = false)]
    public SetSmsPhoneNumberActionSettings SetSmsPhoneNumberActionSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DigitalAction {\n");

        sb.Append("  UpdateContactColumnActionSettings: ").Append(UpdateContactColumnActionSettings).Append("\n");
        sb.Append("  DoNotSendActionSettings: ").Append(DoNotSendActionSettings).Append("\n");
        sb.Append("  AppendToDncActionSettings: ").Append(AppendToDncActionSettings).Append("\n");
        sb.Append("  MarkContactUncontactableActionSettings: ").Append(MarkContactUncontactableActionSettings).Append("\n");
        sb.Append("  MarkContactAddressUncontactableActionSettings: ").Append(MarkContactAddressUncontactableActionSettings).Append("\n");
        sb.Append("  SetContentTemplateActionSettings: ").Append(SetContentTemplateActionSettings).Append("\n");
        sb.Append("  SetSmsPhoneNumberActionSettings: ").Append(SetSmsPhoneNumberActionSettings).Append("\n");
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
        return Equals(obj as DigitalAction);
    }

    /// <summary>
    /// Returns true if DigitalAction instances are equal
    /// </summary>
    /// <param name="other">Instance of DigitalAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DigitalAction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UpdateContactColumnActionSettings == other.UpdateContactColumnActionSettings ||
                UpdateContactColumnActionSettings != null &&
                UpdateContactColumnActionSettings.Equals(other.UpdateContactColumnActionSettings)
            ) &&
            (
                DoNotSendActionSettings == other.DoNotSendActionSettings ||
                DoNotSendActionSettings != null &&
                DoNotSendActionSettings.Equals(other.DoNotSendActionSettings)
            ) &&
            (
                AppendToDncActionSettings == other.AppendToDncActionSettings ||
                AppendToDncActionSettings != null &&
                AppendToDncActionSettings.Equals(other.AppendToDncActionSettings)
            ) &&
            (
                MarkContactUncontactableActionSettings == other.MarkContactUncontactableActionSettings ||
                MarkContactUncontactableActionSettings != null &&
                MarkContactUncontactableActionSettings.Equals(other.MarkContactUncontactableActionSettings)
            ) &&
            (
                MarkContactAddressUncontactableActionSettings == other.MarkContactAddressUncontactableActionSettings ||
                MarkContactAddressUncontactableActionSettings != null &&
                MarkContactAddressUncontactableActionSettings.Equals(other.MarkContactAddressUncontactableActionSettings)
            ) &&
            (
                SetContentTemplateActionSettings == other.SetContentTemplateActionSettings ||
                SetContentTemplateActionSettings != null &&
                SetContentTemplateActionSettings.Equals(other.SetContentTemplateActionSettings)
            ) &&
            (
                SetSmsPhoneNumberActionSettings == other.SetSmsPhoneNumberActionSettings ||
                SetSmsPhoneNumberActionSettings != null &&
                SetSmsPhoneNumberActionSettings.Equals(other.SetSmsPhoneNumberActionSettings)
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
            if (UpdateContactColumnActionSettings != null)
            {
                hash = hash * 59 + UpdateContactColumnActionSettings.GetHashCode();
            }

            if (DoNotSendActionSettings != null)
            {
                hash = hash * 59 + DoNotSendActionSettings.GetHashCode();
            }

            if (AppendToDncActionSettings != null)
            {
                hash = hash * 59 + AppendToDncActionSettings.GetHashCode();
            }

            if (MarkContactUncontactableActionSettings != null)
            {
                hash = hash * 59 + MarkContactUncontactableActionSettings.GetHashCode();
            }

            if (MarkContactAddressUncontactableActionSettings != null)
            {
                hash = hash * 59 + MarkContactAddressUncontactableActionSettings.GetHashCode();
            }

            if (SetContentTemplateActionSettings != null)
            {
                hash = hash * 59 + SetContentTemplateActionSettings.GetHashCode();
            }

            if (SetSmsPhoneNumberActionSettings != null)
            {
                hash = hash * 59 + SetSmsPhoneNumberActionSettings.GetHashCode();
            }

            return hash;
        }
    }
}

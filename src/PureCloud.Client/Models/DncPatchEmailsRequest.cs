using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DncPatchEmailsRequest
/// </summary>

public partial class DncPatchEmailsRequest : IEquatable<DncPatchEmailsRequest>
{
    /// <summary>
    /// The action to perform
    /// </summary>
    /// <value>The action to perform</value>
    
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Add for "Add"
        /// </summary>
        [EnumMember(Value = "Add")]
        Add,

        /// <summary>
        /// Enum Remove for "Remove"
        /// </summary>
        [EnumMember(Value = "Remove")]
        Remove
    }
    /// <summary>
    /// The action to perform
    /// </summary>
    /// <value>The action to perform</value>
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DncPatchEmailsRequest" /> class.
    /// </summary>
    /// <param name="Action">The action to perform.</param>
    /// <param name="EmailAddresses">The list of email addresses to Add to / Remove from the DNC list .</param>
    /// <param name="ExpirationDateTime">Expiration date for DNC email addresses in yyyy-MM-ddTHH:mmZ format.</param>
    public DncPatchEmailsRequest(ActionEnum? Action = null, List<string> EmailAddresses = null, string ExpirationDateTime = null)
    {
        this.Action = Action;
        this.EmailAddresses = EmailAddresses;
        this.ExpirationDateTime = ExpirationDateTime;

    }





    /// <summary>
    /// The list of email addresses to Add to / Remove from the DNC list 
    /// </summary>
    /// <value>The list of email addresses to Add to / Remove from the DNC list </value>
    [JsonPropertyName("emailAddresses")]
    public List<string> EmailAddresses { get; set; }



    /// <summary>
    /// Expiration date for DNC email addresses in yyyy-MM-ddTHH:mmZ format
    /// </summary>
    /// <value>Expiration date for DNC email addresses in yyyy-MM-ddTHH:mmZ format</value>
    [JsonPropertyName("expirationDateTime")]
    public string ExpirationDateTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DncPatchEmailsRequest {\n");

        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
        sb.Append("  ExpirationDateTime: ").Append(ExpirationDateTime).Append("\n");
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
        return Equals(obj as DncPatchEmailsRequest);
    }

    /// <summary>
    /// Returns true if DncPatchEmailsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of DncPatchEmailsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DncPatchEmailsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                EmailAddresses == other.EmailAddresses ||
                EmailAddresses != null &&
                EmailAddresses.SequenceEqual(other.EmailAddresses)
            ) &&
            (
                ExpirationDateTime == other.ExpirationDateTime ||
                ExpirationDateTime != null &&
                ExpirationDateTime.Equals(other.ExpirationDateTime)
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
            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (EmailAddresses != null)
            {
                hash = hash * 59 + EmailAddresses.GetHashCode();
            }

            if (ExpirationDateTime != null)
            {
                hash = hash * 59 + ExpirationDateTime.GetHashCode();
            }

            return hash;
        }
    }
}

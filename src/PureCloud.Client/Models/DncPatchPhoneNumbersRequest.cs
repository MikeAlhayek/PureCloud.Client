using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DncPatchPhoneNumbersRequest
/// </summary>

public partial class DncPatchPhoneNumbersRequest : IEquatable<DncPatchPhoneNumbersRequest>
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
    /// Initializes a new instance of the <see cref="DncPatchPhoneNumbersRequest" /> class.
    /// </summary>
    /// <param name="Action">The action to perform.</param>
    /// <param name="PhoneNumbers">The list of phone numbers to Add to / Remove from the DNC list .</param>
    /// <param name="ExpirationDateTime">Expiration date for DNC phone numbers in yyyy-MM-ddTHH:mmZ format.</param>
    public DncPatchPhoneNumbersRequest(ActionEnum? Action = null, List<string> PhoneNumbers = null, string ExpirationDateTime = null)
    {
        this.Action = Action;
        this.PhoneNumbers = PhoneNumbers;
        this.ExpirationDateTime = ExpirationDateTime;

    }





    /// <summary>
    /// The list of phone numbers to Add to / Remove from the DNC list 
    /// </summary>
    /// <value>The list of phone numbers to Add to / Remove from the DNC list </value>
    [JsonPropertyName("phoneNumbers")]
    public List<string> PhoneNumbers { get; set; }



    /// <summary>
    /// Expiration date for DNC phone numbers in yyyy-MM-ddTHH:mmZ format
    /// </summary>
    /// <value>Expiration date for DNC phone numbers in yyyy-MM-ddTHH:mmZ format</value>
    [JsonPropertyName("expirationDateTime")]
    public string ExpirationDateTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DncPatchPhoneNumbersRequest {\n");

        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
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
        return Equals(obj as DncPatchPhoneNumbersRequest);
    }

    /// <summary>
    /// Returns true if DncPatchPhoneNumbersRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of DncPatchPhoneNumbersRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DncPatchPhoneNumbersRequest other)
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
                PhoneNumbers == other.PhoneNumbers ||
                PhoneNumbers != null &&
                PhoneNumbers.SequenceEqual(other.PhoneNumbers)
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

            if (PhoneNumbers != null)
            {
                hash = hash * 59 + PhoneNumbers.GetHashCode();
            }

            if (ExpirationDateTime != null)
            {
                hash = hash * 59 + ExpirationDateTime.GetHashCode();
            }

            return hash;
        }
    }
}

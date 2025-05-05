using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TransferToExternalRequest
/// </summary>

public partial class TransferToExternalRequest : IEquatable<TransferToExternalRequest>
{
    /// <summary>
    /// The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.
    /// </summary>
    /// <value>The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.</value>
    
    public enum TransferTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Attended for "Attended"
        /// </summary>
        [EnumMember(Value = "Attended")]
        Attended,

        /// <summary>
        /// Enum Unattended for "Unattended"
        /// </summary>
        [EnumMember(Value = "Unattended")]
        Unattended
    }
    /// <summary>
    /// The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.
    /// </summary>
    /// <value>The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended.</value>
    [JsonPropertyName("transferType")]
    public TransferTypeEnum? TransferType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="TransferToExternalRequest" /> class.
    /// </summary>
    /// <param name="TransferType">The type of transfer to perform. Attended, where the initiating agent maintains ownership of the conversation until the intended recipient accepts the transfer, or Unattended, where the initiating agent immediately disconnects. Default is Unattended..</param>
    /// <param name="KeepInternalMessageAlive">If true, the digital internal message will NOT be terminated..</param>
    /// <param name="Address">The address (like phone number) of the external contact..</param>
    public TransferToExternalRequest(TransferTypeEnum? TransferType = null, bool? KeepInternalMessageAlive = null, string Address = null)
    {
        this.TransferType = TransferType;
        this.KeepInternalMessageAlive = KeepInternalMessageAlive;
        this.Address = Address;

    }





    /// <summary>
    /// If true, the digital internal message will NOT be terminated.
    /// </summary>
    /// <value>If true, the digital internal message will NOT be terminated.</value>
    [JsonPropertyName("keepInternalMessageAlive")]
    public bool? KeepInternalMessageAlive { get; set; }



    /// <summary>
    /// The address (like phone number) of the external contact.
    /// </summary>
    /// <value>The address (like phone number) of the external contact.</value>
    [JsonPropertyName("address")]
    public string Address { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TransferToExternalRequest {\n");

        sb.Append("  TransferType: ").Append(TransferType).Append("\n");
        sb.Append("  KeepInternalMessageAlive: ").Append(KeepInternalMessageAlive).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
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
        return Equals(obj as TransferToExternalRequest);
    }

    /// <summary>
    /// Returns true if TransferToExternalRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TransferToExternalRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TransferToExternalRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TransferType == other.TransferType ||
                TransferType != null &&
                TransferType.Equals(other.TransferType)
            ) &&
            (
                KeepInternalMessageAlive == other.KeepInternalMessageAlive ||
                KeepInternalMessageAlive != null &&
                KeepInternalMessageAlive.Equals(other.KeepInternalMessageAlive)
            ) &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
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
            if (TransferType != null)
            {
                hash = hash * 59 + TransferType.GetHashCode();
            }

            if (KeepInternalMessageAlive != null)
            {
                hash = hash * 59 + KeepInternalMessageAlive.GetHashCode();
            }

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            return hash;
        }
    }
}

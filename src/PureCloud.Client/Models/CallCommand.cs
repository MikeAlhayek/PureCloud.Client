using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallCommand
/// </summary>

public partial class CallCommand : IEquatable<CallCommand>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CallCommand" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CallCommand() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CallCommand" /> class.
    /// </summary>
    /// <param name="CallNumber">The phone number to dial for this call. (required).</param>
    /// <param name="PhoneColumn">For a dialer preview or scheduled callback, the phone column associated with the phone number.</param>
    public CallCommand(string CallNumber = null, string PhoneColumn = null)
    {
        this.CallNumber = CallNumber;
        this.PhoneColumn = PhoneColumn;

    }



    /// <summary>
    /// The phone number to dial for this call.
    /// </summary>
    /// <value>The phone number to dial for this call.</value>
    [JsonPropertyName("callNumber")]
    public string CallNumber { get; set; }



    /// <summary>
    /// For a dialer preview or scheduled callback, the phone column associated with the phone number
    /// </summary>
    /// <value>For a dialer preview or scheduled callback, the phone column associated with the phone number</value>
    [JsonPropertyName("phoneColumn")]
    public string PhoneColumn { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallCommand {\n");

        sb.Append("  CallNumber: ").Append(CallNumber).Append("\n");
        sb.Append("  PhoneColumn: ").Append(PhoneColumn).Append("\n");
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
        return Equals(obj as CallCommand);
    }

    /// <summary>
    /// Returns true if CallCommand instances are equal
    /// </summary>
    /// <param name="other">Instance of CallCommand to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallCommand other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CallNumber == other.CallNumber ||
                CallNumber != null &&
                CallNumber.Equals(other.CallNumber)
            ) &&
            (
                PhoneColumn == other.PhoneColumn ||
                PhoneColumn != null &&
                PhoneColumn.Equals(other.PhoneColumn)
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
            if (CallNumber != null)
            {
                hash = hash * 59 + CallNumber.GetHashCode();
            }

            if (PhoneColumn != null)
            {
                hash = hash * 59 + PhoneColumn.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkErrorInfoDetails
/// </summary>
[DataContract]
public partial class TrunkErrorInfoDetails : IEquatable<TrunkErrorInfoDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkErrorInfoDetails" /> class.
    /// </summary>
    /// <param name="Code">Code.</param>
    /// <param name="Message">Message.</param>
    /// <param name="Hostname">Hostname.</param>
    public TrunkErrorInfoDetails(string Code = null, string Message = null, string Hostname = null)
    {
        this.Code = Code;
        this.Message = Message;
        this.Hostname = Hostname;

    }



    /// <summary>
    /// Gets or Sets Code
    /// </summary>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; set; }



    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets Hostname
    /// </summary>
    [DataMember(Name = "hostname", EmitDefaultValue = false)]
    public string Hostname { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkErrorInfoDetails {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Hostname: ").Append(Hostname).Append("\n");
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
        return Equals(obj as TrunkErrorInfoDetails);
    }

    /// <summary>
    /// Returns true if TrunkErrorInfoDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkErrorInfoDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkErrorInfoDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Hostname == other.Hostname ||
                Hostname != null &&
                Hostname.Equals(other.Hostname)
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
            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Hostname != null)
            {
                hash = hash * 59 + Hostname.GetHashCode();
            }

            return hash;
        }
    }
}

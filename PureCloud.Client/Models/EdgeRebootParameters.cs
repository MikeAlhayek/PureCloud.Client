using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeRebootParameters
/// </summary>
[DataContract]
public partial class EdgeRebootParameters : IEquatable<EdgeRebootParameters>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeRebootParameters" /> class.
    /// </summary>
    /// <param name="CallDrainingWaitTimeSeconds">The number of seconds to wait for call draining to complete before initiating the reboot. A value of 0 will prevent call draining and all calls will disconnect immediately..</param>
    public EdgeRebootParameters(int? CallDrainingWaitTimeSeconds = null)
    {
        this.CallDrainingWaitTimeSeconds = CallDrainingWaitTimeSeconds;

    }



    /// <summary>
    /// The number of seconds to wait for call draining to complete before initiating the reboot. A value of 0 will prevent call draining and all calls will disconnect immediately.
    /// </summary>
    /// <value>The number of seconds to wait for call draining to complete before initiating the reboot. A value of 0 will prevent call draining and all calls will disconnect immediately.</value>
    [DataMember(Name = "callDrainingWaitTimeSeconds", EmitDefaultValue = false)]
    public int? CallDrainingWaitTimeSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeRebootParameters {\n");

        sb.Append("  CallDrainingWaitTimeSeconds: ").Append(CallDrainingWaitTimeSeconds).Append("\n");
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
        return Equals(obj as EdgeRebootParameters);
    }

    /// <summary>
    /// Returns true if EdgeRebootParameters instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeRebootParameters to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeRebootParameters other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CallDrainingWaitTimeSeconds == other.CallDrainingWaitTimeSeconds ||
                CallDrainingWaitTimeSeconds != null &&
                CallDrainingWaitTimeSeconds.Equals(other.CallDrainingWaitTimeSeconds)
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
            if (CallDrainingWaitTimeSeconds != null)
            {
                hash = hash * 59 + CallDrainingWaitTimeSeconds.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeServiceStateRequest
/// </summary>
[DataContract]
public partial class EdgeServiceStateRequest : IEquatable<EdgeServiceStateRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeServiceStateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EdgeServiceStateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeServiceStateRequest" /> class.
    /// </summary>
    /// <param name="InService">A boolean that sets the Edge in-service or out-of-service. (required).</param>
    /// <param name="CallDrainingWaitTimeSeconds">The number of seconds to wait for call draining to complete before initiating the reboot. A value of 0 will prevent call draining and all calls will disconnect immediately..</param>
    public EdgeServiceStateRequest(bool? InService = null, int? CallDrainingWaitTimeSeconds = null)
    {
        this.InService = InService;
        this.CallDrainingWaitTimeSeconds = CallDrainingWaitTimeSeconds;

    }



    /// <summary>
    /// A boolean that sets the Edge in-service or out-of-service.
    /// </summary>
    /// <value>A boolean that sets the Edge in-service or out-of-service.</value>
    [DataMember(Name = "inService", EmitDefaultValue = false)]
    public bool? InService { get; set; }



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
        sb.Append("class EdgeServiceStateRequest {\n");

        sb.Append("  InService: ").Append(InService).Append("\n");
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
        return Equals(obj as EdgeServiceStateRequest);
    }

    /// <summary>
    /// Returns true if EdgeServiceStateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeServiceStateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeServiceStateRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                InService == other.InService ||
                InService != null &&
                InService.Equals(other.InService)
            ) &&
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
            if (InService != null)
            {
                hash = hash * 59 + InService.GetHashCode();
            }

            if (CallDrainingWaitTimeSeconds != null)
            {
                hash = hash * 59 + CallDrainingWaitTimeSeconds.GetHashCode();
            }

            return hash;
        }
    }
}

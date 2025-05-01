using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// TrunkMetricsCalls
/// </summary>
[DataContract]
public partial class TrunkMetricsCalls : IEquatable<TrunkMetricsCalls>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrunkMetricsCalls" /> class.
    /// </summary>
    /// <param name="InboundCallCount">InboundCallCount.</param>
    /// <param name="OutboundCallCount">OutboundCallCount.</param>
    public TrunkMetricsCalls(int? InboundCallCount = null, int? OutboundCallCount = null)
    {
        this.InboundCallCount = InboundCallCount;
        this.OutboundCallCount = OutboundCallCount;

    }



    /// <summary>
    /// Gets or Sets InboundCallCount
    /// </summary>
    [DataMember(Name = "inboundCallCount", EmitDefaultValue = false)]
    public int? InboundCallCount { get; set; }



    /// <summary>
    /// Gets or Sets OutboundCallCount
    /// </summary>
    [DataMember(Name = "outboundCallCount", EmitDefaultValue = false)]
    public int? OutboundCallCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrunkMetricsCalls {\n");

        sb.Append("  InboundCallCount: ").Append(InboundCallCount).Append("\n");
        sb.Append("  OutboundCallCount: ").Append(OutboundCallCount).Append("\n");
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
        return Equals(obj as TrunkMetricsCalls);
    }

    /// <summary>
    /// Returns true if TrunkMetricsCalls instances are equal
    /// </summary>
    /// <param name="other">Instance of TrunkMetricsCalls to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrunkMetricsCalls other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                InboundCallCount == other.InboundCallCount ||
                InboundCallCount != null &&
                InboundCallCount.Equals(other.InboundCallCount)
            ) &&
            (
                OutboundCallCount == other.OutboundCallCount ||
                OutboundCallCount != null &&
                OutboundCallCount.Equals(other.OutboundCallCount)
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
            if (InboundCallCount != null)
            {
                hash = hash * 59 + InboundCallCount.GetHashCode();
            }

            if (OutboundCallCount != null)
            {
                hash = hash * 59 + OutboundCallCount.GetHashCode();
            }

            return hash;
        }
    }
}

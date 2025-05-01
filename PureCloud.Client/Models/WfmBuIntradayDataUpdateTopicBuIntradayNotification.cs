using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuIntradayDataUpdateTopicBuIntradayNotification
/// </summary>
[DataContract]
public partial class WfmBuIntradayDataUpdateTopicBuIntradayNotification : IEquatable<WfmBuIntradayDataUpdateTopicBuIntradayNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuIntradayDataUpdateTopicBuIntradayNotification" /> class.
    /// </summary>
    /// <param name="OperationId">OperationId.</param>
    /// <param name="Result">Result.</param>
    public WfmBuIntradayDataUpdateTopicBuIntradayNotification(string OperationId = null, WfmBuIntradayDataUpdateTopicBuIntradayResult Result = null)
    {
        this.OperationId = OperationId;
        this.Result = Result;

    }



    /// <summary>
    /// Gets or Sets OperationId
    /// </summary>
    [DataMember(Name = "operationId", EmitDefaultValue = false)]
    public string OperationId { get; set; }



    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    [DataMember(Name = "result", EmitDefaultValue = false)]
    public WfmBuIntradayDataUpdateTopicBuIntradayResult Result { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuIntradayDataUpdateTopicBuIntradayNotification {\n");

        sb.Append("  OperationId: ").Append(OperationId).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
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
        return Equals(obj as WfmBuIntradayDataUpdateTopicBuIntradayNotification);
    }

    /// <summary>
    /// Returns true if WfmBuIntradayDataUpdateTopicBuIntradayNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuIntradayDataUpdateTopicBuIntradayNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuIntradayDataUpdateTopicBuIntradayNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OperationId == other.OperationId ||
                OperationId != null &&
                OperationId.Equals(other.OperationId)
            ) &&
            (
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
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
            if (OperationId != null)
            {
                hash = hash * 59 + OperationId.GetHashCode();
            }

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchShiftTradeRequest
/// </summary>
[DataContract]
public partial class PatchShiftTradeRequest : IEquatable<PatchShiftTradeRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PatchShiftTradeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PatchShiftTradeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchShiftTradeRequest" /> class.
    /// </summary>
    /// <param name="ReceivingUserId">Update the ID of the receiving user to direct the request at a specific user, or set the wrapped id to null to open up a trade to be matched by any user..</param>
    /// <param name="Expiration">Update the expiration time for this shift trade..</param>
    /// <param name="AcceptableIntervals">Update the acceptable intervals the initiating user is willing to accept in trade. Setting the enclosed list to empty will make this a one sided trade request.</param>
    /// <param name="Metadata">Version metadata (required).</param>
    public PatchShiftTradeRequest(ValueWrapperString ReceivingUserId = null, ValueWrapperDate Expiration = null, ListWrapperInterval AcceptableIntervals = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.ReceivingUserId = ReceivingUserId;
        this.Expiration = Expiration;
        this.AcceptableIntervals = AcceptableIntervals;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// Update the ID of the receiving user to direct the request at a specific user, or set the wrapped id to null to open up a trade to be matched by any user.
    /// </summary>
    /// <value>Update the ID of the receiving user to direct the request at a specific user, or set the wrapped id to null to open up a trade to be matched by any user.</value>
    [DataMember(Name = "receivingUserId", EmitDefaultValue = false)]
    public ValueWrapperString ReceivingUserId { get; set; }



    /// <summary>
    /// Update the expiration time for this shift trade.
    /// </summary>
    /// <value>Update the expiration time for this shift trade.</value>
    [DataMember(Name = "expiration", EmitDefaultValue = false)]
    public ValueWrapperDate Expiration { get; set; }



    /// <summary>
    /// Update the acceptable intervals the initiating user is willing to accept in trade. Setting the enclosed list to empty will make this a one sided trade request
    /// </summary>
    /// <value>Update the acceptable intervals the initiating user is willing to accept in trade. Setting the enclosed list to empty will make this a one sided trade request</value>
    [DataMember(Name = "acceptableIntervals", EmitDefaultValue = false)]
    public ListWrapperInterval AcceptableIntervals { get; set; }



    /// <summary>
    /// Version metadata
    /// </summary>
    /// <value>Version metadata</value>
    [DataMember(Name = "metadata", EmitDefaultValue = false)]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchShiftTradeRequest {\n");

        sb.Append("  ReceivingUserId: ").Append(ReceivingUserId).Append("\n");
        sb.Append("  Expiration: ").Append(Expiration).Append("\n");
        sb.Append("  AcceptableIntervals: ").Append(AcceptableIntervals).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as PatchShiftTradeRequest);
    }

    /// <summary>
    /// Returns true if PatchShiftTradeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchShiftTradeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchShiftTradeRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ReceivingUserId == other.ReceivingUserId ||
                ReceivingUserId != null &&
                ReceivingUserId.Equals(other.ReceivingUserId)
            ) &&
            (
                Expiration == other.Expiration ||
                Expiration != null &&
                Expiration.Equals(other.Expiration)
            ) &&
            (
                AcceptableIntervals == other.AcceptableIntervals ||
                AcceptableIntervals != null &&
                AcceptableIntervals.Equals(other.AcceptableIntervals)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
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
            if (ReceivingUserId != null)
            {
                hash = hash * 59 + ReceivingUserId.GetHashCode();
            }

            if (Expiration != null)
            {
                hash = hash * 59 + Expiration.GetHashCode();
            }

            if (AcceptableIntervals != null)
            {
                hash = hash * 59 + AcceptableIntervals.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}

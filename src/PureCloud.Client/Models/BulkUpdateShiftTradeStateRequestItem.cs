using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkUpdateShiftTradeStateRequestItem
/// </summary>

public partial class BulkUpdateShiftTradeStateRequestItem : IEquatable<BulkUpdateShiftTradeStateRequestItem>
{
    /// <summary>
    /// The new state to set on the shift trade
    /// </summary>
    /// <value>The new state to set on the shift trade</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unmatched for "Unmatched"
        /// </summary>
        [EnumMember(Value = "Unmatched")]
        Unmatched,

        /// <summary>
        /// Enum Matched for "Matched"
        /// </summary>
        [EnumMember(Value = "Matched")]
        Matched,

        /// <summary>
        /// Enum Approved for "Approved"
        /// </summary>
        [EnumMember(Value = "Approved")]
        Approved,

        /// <summary>
        /// Enum Denied for "Denied"
        /// </summary>
        [EnumMember(Value = "Denied")]
        Denied,

        /// <summary>
        /// Enum Expired for "Expired"
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired,

        /// <summary>
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled
    }
    /// <summary>
    /// The new state to set on the shift trade
    /// </summary>
    /// <value>The new state to set on the shift trade</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BulkUpdateShiftTradeStateRequestItem" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BulkUpdateShiftTradeStateRequestItem() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkUpdateShiftTradeStateRequestItem" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="State">The new state to set on the shift trade (required).</param>
    /// <param name="Metadata">Version metadata for the shift trade (required).</param>
    public BulkUpdateShiftTradeStateRequestItem(string Id = null, StateEnum? State = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.Id = Id;
        this.State = State;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Version metadata for the shift trade
    /// </summary>
    /// <value>Version metadata for the shift trade</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkUpdateShiftTradeStateRequestItem {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as BulkUpdateShiftTradeStateRequestItem);
    }

    /// <summary>
    /// Returns true if BulkUpdateShiftTradeStateRequestItem instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkUpdateShiftTradeStateRequestItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkUpdateShiftTradeStateRequestItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}

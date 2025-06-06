using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentUpdateAlternativeShiftTradeRequest
/// </summary>

public partial class AgentUpdateAlternativeShiftTradeRequest : IEquatable<AgentUpdateAlternativeShiftTradeRequest>
{
    /// <summary>
    /// The new state of this alternative shift trade
    /// </summary>
    /// <value>The new state of this alternative shift trade</value>
    
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
        /// Enum Canceled for "Canceled"
        /// </summary>
        [EnumMember(Value = "Canceled")]
        Canceled
    }
    /// <summary>
    /// The new state of this alternative shift trade
    /// </summary>
    /// <value>The new state of this alternative shift trade</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentUpdateAlternativeShiftTradeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AgentUpdateAlternativeShiftTradeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentUpdateAlternativeShiftTradeRequest" /> class.
    /// </summary>
    /// <param name="State">The new state of this alternative shift trade.</param>
    /// <param name="Metadata">Version metadata for this alternative shift trade (required).</param>
    public AgentUpdateAlternativeShiftTradeRequest(StateEnum? State = null, WfmVersionedEntityMetadata Metadata = null)
    {
        this.State = State;
        this.Metadata = Metadata;

    }





    /// <summary>
    /// Version metadata for this alternative shift trade
    /// </summary>
    /// <value>Version metadata for this alternative shift trade</value>
    [JsonPropertyName("metadata")]
    public WfmVersionedEntityMetadata Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentUpdateAlternativeShiftTradeRequest {\n");

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
        return Equals(obj as AgentUpdateAlternativeShiftTradeRequest);
    }

    /// <summary>
    /// Returns true if AgentUpdateAlternativeShiftTradeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentUpdateAlternativeShiftTradeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentUpdateAlternativeShiftTradeRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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

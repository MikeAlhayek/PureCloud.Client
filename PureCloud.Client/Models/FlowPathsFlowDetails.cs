using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowPathsFlowDetails
/// </summary>
[DataContract]
public partial class FlowPathsFlowDetails : IEquatable<FlowPathsFlowDetails>
{
    /// <summary>
    /// The type of the flow.
    /// </summary>
    /// <value>The type of the flow.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Digitalbot for "DigitalBot"
        /// </summary>
        [EnumMember(Value = "DigitalBot")]
        Digitalbot,

        /// <summary>
        /// Enum Bot for "Bot"
        /// </summary>
        [EnumMember(Value = "Bot")]
        Bot,

        /// <summary>
        /// Enum Inboundcall for "InboundCall"
        /// </summary>
        [EnumMember(Value = "InboundCall")]
        Inboundcall,

        /// <summary>
        /// Enum Securecall for "SecureCall"
        /// </summary>
        [EnumMember(Value = "SecureCall")]
        Securecall,

        /// <summary>
        /// Enum Inboundshortmessage for "InboundShortMessage"
        /// </summary>
        [EnumMember(Value = "InboundShortMessage")]
        Inboundshortmessage,

        /// <summary>
        /// Enum Inboundemail for "InboundEmail"
        /// </summary>
        [EnumMember(Value = "InboundEmail")]
        Inboundemail,

        /// <summary>
        /// Enum Outboundcall for "OutboundCall"
        /// </summary>
        [EnumMember(Value = "OutboundCall")]
        Outboundcall
    }
    /// <summary>
    /// The type of the flow.
    /// </summary>
    /// <value>The type of the flow.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowPathsFlowDetails" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowPathsFlowDetails() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowPathsFlowDetails" /> class.
    /// </summary>
    /// <param name="Version">The version of the flow. (required).</param>
    /// <param name="Type">The type of the flow. (required).</param>
    /// <param name="Count">Count of all journeys that include this element in the given flow. (required).</param>
    public FlowPathsFlowDetails(string Version = null, TypeEnum? Type = null, int? Count = null)
    {
        this.Version = Version;
        this.Type = Type;
        this.Count = Count;

    }



    /// <summary>
    /// The version of the flow.
    /// </summary>
    /// <value>The version of the flow.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public string Version { get; set; }





    /// <summary>
    /// Count of all journeys that include this element in the given flow.
    /// </summary>
    /// <value>Count of all journeys that include this element in the given flow.</value>
    [DataMember(Name = "count", EmitDefaultValue = false)]
    public int? Count { get; set; }



    /// <summary>
    /// The identifier of the flow.
    /// </summary>
    /// <value>The identifier of the flow.</value>
    [DataMember(Name = "flow", EmitDefaultValue = false)]
    public AddressableEntityRef Flow { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowPathsFlowDetails {\n");

        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
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
        return Equals(obj as FlowPathsFlowDetails);
    }

    /// <summary>
    /// Returns true if FlowPathsFlowDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowPathsFlowDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowPathsFlowDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
            ) &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
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
            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            return hash;
        }
    }
}

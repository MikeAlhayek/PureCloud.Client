using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EventCondition
/// </summary>
[DataContract]
public partial class EventCondition : IEquatable<EventCondition>
{
    /// <summary>
    /// The comparison operator.
    /// </summary>
    /// <value>The comparison operator.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Containsall for "containsAll"
        /// </summary>
        [EnumMember(Value = "containsAll")]
        Containsall,

        /// <summary>
        /// Enum Containsany for "containsAny"
        /// </summary>
        [EnumMember(Value = "containsAny")]
        Containsany,

        /// <summary>
        /// Enum Notcontainsall for "notContainsAll"
        /// </summary>
        [EnumMember(Value = "notContainsAll")]
        Notcontainsall,

        /// <summary>
        /// Enum Notcontainsany for "notContainsAny"
        /// </summary>
        [EnumMember(Value = "notContainsAny")]
        Notcontainsany,

        /// <summary>
        /// Enum Equal for "equal"
        /// </summary>
        [EnumMember(Value = "equal")]
        Equal,

        /// <summary>
        /// Enum Notequal for "notEqual"
        /// </summary>
        [EnumMember(Value = "notEqual")]
        Notequal,

        /// <summary>
        /// Enum Greaterthan for "greaterThan"
        /// </summary>
        [EnumMember(Value = "greaterThan")]
        Greaterthan,

        /// <summary>
        /// Enum Greaterthanorequal for "greaterThanOrEqual"
        /// </summary>
        [EnumMember(Value = "greaterThanOrEqual")]
        Greaterthanorequal,

        /// <summary>
        /// Enum Lessthan for "lessThan"
        /// </summary>
        [EnumMember(Value = "lessThan")]
        Lessthan,

        /// <summary>
        /// Enum Lessthanorequal for "lessThanOrEqual"
        /// </summary>
        [EnumMember(Value = "lessThanOrEqual")]
        Lessthanorequal,

        /// <summary>
        /// Enum Startswith for "startsWith"
        /// </summary>
        [EnumMember(Value = "startsWith")]
        Startswith,

        /// <summary>
        /// Enum Endswith for "endsWith"
        /// </summary>
        [EnumMember(Value = "endsWith")]
        Endswith
    }
    /// <summary>
    /// The stream type for which this condition can be satisfied.
    /// </summary>
    /// <value>The stream type for which this condition can be satisfied.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StreamTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Web for "Web"
        /// </summary>
        [EnumMember(Value = "Web")]
        Web,

        /// <summary>
        /// Enum Custom for "Custom"
        /// </summary>
        [EnumMember(Value = "Custom")]
        Custom,

        /// <summary>
        /// Enum Conversation for "Conversation"
        /// </summary>
        [EnumMember(Value = "Conversation")]
        Conversation,

        /// <summary>
        /// Enum App for "App"
        /// </summary>
        [EnumMember(Value = "App")]
        App
    }
    /// <summary>
    /// The comparison operator.
    /// </summary>
    /// <value>The comparison operator.</value>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// The stream type for which this condition can be satisfied.
    /// </summary>
    /// <value>The stream type for which this condition can be satisfied.</value>
    [DataMember(Name = "streamType", EmitDefaultValue = false)]
    public StreamTypeEnum? StreamType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventCondition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EventCondition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EventCondition" /> class.
    /// </summary>
    /// <param name="Key">The event key. (required).</param>
    /// <param name="Values">The event values. (required).</param>
    /// <param name="Operator">The comparison operator..</param>
    /// <param name="StreamType">The stream type for which this condition can be satisfied. (required).</param>
    /// <param name="SessionType">The session type for which this condition can be satisfied. (required).</param>
    /// <param name="EventName">The name of the event for which this condition can be satisfied..</param>
    public EventCondition(string Key = null, List<string> Values = null, OperatorEnum? Operator = null, StreamTypeEnum? StreamType = null, string SessionType = null, string EventName = null)
    {
        this.Key = Key;
        this.Values = Values;
        this.Operator = Operator;
        this.StreamType = StreamType;
        this.SessionType = SessionType;
        this.EventName = EventName;

    }



    /// <summary>
    /// The event key.
    /// </summary>
    /// <value>The event key.</value>
    [DataMember(Name = "key", EmitDefaultValue = false)]
    public string Key { get; set; }



    /// <summary>
    /// The event values.
    /// </summary>
    /// <value>The event values.</value>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<string> Values { get; set; }







    /// <summary>
    /// The session type for which this condition can be satisfied.
    /// </summary>
    /// <value>The session type for which this condition can be satisfied.</value>
    [DataMember(Name = "sessionType", EmitDefaultValue = false)]
    public string SessionType { get; set; }



    /// <summary>
    /// The name of the event for which this condition can be satisfied.
    /// </summary>
    /// <value>The name of the event for which this condition can be satisfied.</value>
    [DataMember(Name = "eventName", EmitDefaultValue = false)]
    public string EventName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventCondition {\n");

        sb.Append("  Key: ").Append(Key).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  StreamType: ").Append(StreamType).Append("\n");
        sb.Append("  SessionType: ").Append(SessionType).Append("\n");
        sb.Append("  EventName: ").Append(EventName).Append("\n");
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
        return Equals(obj as EventCondition);
    }

    /// <summary>
    /// Returns true if EventCondition instances are equal
    /// </summary>
    /// <param name="other">Instance of EventCondition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventCondition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Key == other.Key ||
                Key != null &&
                Key.Equals(other.Key)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                StreamType == other.StreamType ||
                StreamType != null &&
                StreamType.Equals(other.StreamType)
            ) &&
            (
                SessionType == other.SessionType ||
                SessionType != null &&
                SessionType.Equals(other.SessionType)
            ) &&
            (
                EventName == other.EventName ||
                EventName != null &&
                EventName.Equals(other.EventName)
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
            if (Key != null)
            {
                hash = hash * 59 + Key.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (StreamType != null)
            {
                hash = hash * 59 + StreamType.GetHashCode();
            }

            if (SessionType != null)
            {
                hash = hash * 59 + SessionType.GetHashCode();
            }

            if (EventName != null)
            {
                hash = hash * 59 + EventName.GetHashCode();
            }

            return hash;
        }
    }
}

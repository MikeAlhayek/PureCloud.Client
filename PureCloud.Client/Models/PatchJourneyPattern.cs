using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchJourneyPattern
/// </summary>

public partial class PatchJourneyPattern : IEquatable<PatchJourneyPattern>
{
    /// <summary>
    /// The stream type for which this pattern can be matched on.
    /// </summary>
    /// <value>The stream type for which this pattern can be matched on.</value>
    
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
    /// The stream type for which this pattern can be matched on.
    /// </summary>
    /// <value>The stream type for which this pattern can be matched on.</value>
    [JsonPropertyName("streamType")]
    public StreamTypeEnum? StreamType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchJourneyPattern" /> class.
    /// </summary>
    /// <param name="Criteria">A list of one or more criteria to satisfy..</param>
    /// <param name="Count">The number of times the pattern must match..</param>
    /// <param name="StreamType">The stream type for which this pattern can be matched on..</param>
    /// <param name="SessionType">The session type for which this pattern can be matched on..</param>
    /// <param name="EventName">The name of the event for which this pattern can be matched on..</param>
    public PatchJourneyPattern(List<PatchCriteria> Criteria = null, int? Count = null, StreamTypeEnum? StreamType = null, string SessionType = null, string EventName = null)
    {
        this.Criteria = Criteria;
        this.Count = Count;
        this.StreamType = StreamType;
        this.SessionType = SessionType;
        this.EventName = EventName;

    }



    /// <summary>
    /// A list of one or more criteria to satisfy.
    /// </summary>
    /// <value>A list of one or more criteria to satisfy.</value>
    [JsonPropertyName("criteria")]
    public List<PatchCriteria> Criteria { get; set; }



    /// <summary>
    /// The number of times the pattern must match.
    /// </summary>
    /// <value>The number of times the pattern must match.</value>
    [JsonPropertyName("count")]
    public int? Count { get; set; }





    /// <summary>
    /// The session type for which this pattern can be matched on.
    /// </summary>
    /// <value>The session type for which this pattern can be matched on.</value>
    [JsonPropertyName("sessionType")]
    public string SessionType { get; set; }



    /// <summary>
    /// The name of the event for which this pattern can be matched on.
    /// </summary>
    /// <value>The name of the event for which this pattern can be matched on.</value>
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchJourneyPattern {\n");

        sb.Append("  Criteria: ").Append(Criteria).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
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
        return Equals(obj as PatchJourneyPattern);
    }

    /// <summary>
    /// Returns true if PatchJourneyPattern instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchJourneyPattern to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchJourneyPattern other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Criteria == other.Criteria ||
                Criteria != null &&
                Criteria.SequenceEqual(other.Criteria)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
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
            if (Criteria != null)
            {
                hash = hash * 59 + Criteria.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
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

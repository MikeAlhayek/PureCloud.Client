using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Segment
/// </summary>
[DataContract]
public partial class Segment : IEquatable<Segment>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Segment" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Segment() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Segment" /> class.
    /// </summary>
    /// <param name="StartTime">The timestamp when this segment began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="EndTime">The timestamp when this segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="Type">The activity taking place for the participant in the segment..</param>
    /// <param name="HowEnded">A description of the event that ended the segment..</param>
    /// <param name="DisconnectType">A description of the event that disconnected the segment.</param>
    public Segment(DateTime? StartTime = null, DateTime? EndTime = null, string Type = null, string HowEnded = null, string DisconnectType = null)
    {
        this.StartTime = StartTime;
        this.EndTime = EndTime;
        this.Type = Type;
        this.HowEnded = HowEnded;
        this.DisconnectType = DisconnectType;

    }



    /// <summary>
    /// The timestamp when this segment began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this segment began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startTime", EmitDefaultValue = false)]
    public DateTime? StartTime { get; set; }



    /// <summary>
    /// The timestamp when this segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this segment ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "endTime", EmitDefaultValue = false)]
    public DateTime? EndTime { get; set; }



    /// <summary>
    /// The activity taking place for the participant in the segment.
    /// </summary>
    /// <value>The activity taking place for the participant in the segment.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// A description of the event that ended the segment.
    /// </summary>
    /// <value>A description of the event that ended the segment.</value>
    [DataMember(Name = "howEnded", EmitDefaultValue = false)]
    public string HowEnded { get; set; }



    /// <summary>
    /// A description of the event that disconnected the segment
    /// </summary>
    /// <value>A description of the event that disconnected the segment</value>
    [DataMember(Name = "disconnectType", EmitDefaultValue = false)]
    public string DisconnectType { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Segment {\n");

        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  HowEnded: ").Append(HowEnded).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
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
        return Equals(obj as Segment);
    }

    /// <summary>
    /// Returns true if Segment instances are equal
    /// </summary>
    /// <param name="other">Instance of Segment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Segment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartTime == other.StartTime ||
                StartTime != null &&
                StartTime.Equals(other.StartTime)
            ) &&
            (
                EndTime == other.EndTime ||
                EndTime != null &&
                EndTime.Equals(other.EndTime)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                HowEnded == other.HowEnded ||
                HowEnded != null &&
                HowEnded.Equals(other.HowEnded)
            ) &&
            (
                DisconnectType == other.DisconnectType ||
                DisconnectType != null &&
                DisconnectType.Equals(other.DisconnectType)
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
            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (HowEnded != null)
            {
                hash = hash * 59 + HowEnded.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            return hash;
        }
    }
}

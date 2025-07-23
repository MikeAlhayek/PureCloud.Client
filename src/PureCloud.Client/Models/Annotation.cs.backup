using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Annotation
/// </summary>

public partial class Annotation : IEquatable<Annotation>
{
    /// <summary>
    /// Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause
    /// </summary>
    /// <value>Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause</value>
    
    public enum ReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Hold for "Hold"
        /// </summary>
        [EnumMember(Value = "Hold")]
        Hold,

        /// <summary>
        /// Enum Securepause for "SecurePause"
        /// </summary>
        [EnumMember(Value = "SecurePause")]
        Securepause,

        /// <summary>
        /// Enum Floworqueue for "FlowOrQueue"
        /// </summary>
        [EnumMember(Value = "FlowOrQueue")]
        Floworqueue,

        /// <summary>
        /// Enum Pause for "Pause"
        /// </summary>
        [EnumMember(Value = "Pause")]
        Pause
    }
    /// <summary>
    /// Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause
    /// </summary>
    /// <value>Reason for a pause annotation. Valid values: Hold,SecurePause,FlowOrQueue,Pause</value>
    [JsonPropertyName("reason")]
    public ReasonEnum? Reason { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Annotation" /> class.
    /// </summary>
    /// <param name="Id">Annotation id. All pause annotations on a recording will share an ID value, bookmark annotations will have unique IDs, and hold annotations will have randomly generated UUIDs (i.e. the ID will change at each request)..</param>
    /// <param name="Name">Name.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Location">Offset of annotation in milliseconds..</param>
    /// <param name="DurationMs">Duration of annotation in milliseconds..</param>
    /// <param name="AbsoluteLocation">Offset of annotation (milliseconds) from start of recording (after removing the cumulative duration of all pauses)..</param>
    /// <param name="AbsoluteDurationMs">Duration of annotation (milliseconds)..</param>
    /// <param name="RecordingLocation">Offset of annotation (milliseconds) from start of recording, adjusted for any recording cuts.</param>
    /// <param name="RecordingDurationMs">Duration of annotation (milliseconds), adjusted for any recording cuts..</param>
    /// <param name="User">User that created this annotation (if any)..</param>
    /// <param name="Description">Text of annotation. Maximum character limit is 500..</param>
    public Annotation(string Id = null, string Name = null, string Type = null, long? Location = null, long? DurationMs = null, long? AbsoluteLocation = null, long? AbsoluteDurationMs = null, long? RecordingLocation = null, long? RecordingDurationMs = null, User User = null, string Description = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Type = Type;
        this.Location = Location;
        this.DurationMs = DurationMs;
        this.AbsoluteLocation = AbsoluteLocation;
        this.AbsoluteDurationMs = AbsoluteDurationMs;
        this.RecordingLocation = RecordingLocation;
        this.RecordingDurationMs = RecordingDurationMs;
        this.User = User;
        this.Description = Description;

    }



    /// <summary>
    /// Annotation id. All pause annotations on a recording will share an ID value, bookmark annotations will have unique IDs, and hold annotations will have randomly generated UUIDs (i.e. the ID will change at each request).
    /// </summary>
    /// <value>Annotation id. All pause annotations on a recording will share an ID value, bookmark annotations will have unique IDs, and hold annotations will have randomly generated UUIDs (i.e. the ID will change at each request).</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// Offset of annotation in milliseconds.
    /// </summary>
    /// <value>Offset of annotation in milliseconds.</value>
    [JsonPropertyName("location")]
    public long? Location { get; set; }



    /// <summary>
    /// Duration of annotation in milliseconds.
    /// </summary>
    /// <value>Duration of annotation in milliseconds.</value>
    [JsonPropertyName("durationMs")]
    public long? DurationMs { get; set; }



    /// <summary>
    /// Offset of annotation (milliseconds) from start of recording (after removing the cumulative duration of all pauses).
    /// </summary>
    /// <value>Offset of annotation (milliseconds) from start of recording (after removing the cumulative duration of all pauses).</value>
    [JsonPropertyName("absoluteLocation")]
    public long? AbsoluteLocation { get; set; }



    /// <summary>
    /// Duration of annotation (milliseconds).
    /// </summary>
    /// <value>Duration of annotation (milliseconds).</value>
    [JsonPropertyName("absoluteDurationMs")]
    public long? AbsoluteDurationMs { get; set; }



    /// <summary>
    /// Offset of annotation (milliseconds) from start of recording, adjusted for any recording cuts
    /// </summary>
    /// <value>Offset of annotation (milliseconds) from start of recording, adjusted for any recording cuts</value>
    [JsonPropertyName("recordingLocation")]
    public long? RecordingLocation { get; set; }



    /// <summary>
    /// Duration of annotation (milliseconds), adjusted for any recording cuts.
    /// </summary>
    /// <value>Duration of annotation (milliseconds), adjusted for any recording cuts.</value>
    [JsonPropertyName("recordingDurationMs")]
    public long? RecordingDurationMs { get; set; }



    /// <summary>
    /// User that created this annotation (if any).
    /// </summary>
    /// <value>User that created this annotation (if any).</value>
    [JsonPropertyName("user")]
    public User User { get; set; }



    /// <summary>
    /// Text of annotation. Maximum character limit is 500.
    /// </summary>
    /// <value>Text of annotation. Maximum character limit is 500.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }





    /// <summary>
    /// List of annotations
    /// </summary>
    /// <value>List of annotations</value>
    [JsonPropertyName("annotations")]
    public List<Annotation> Annotations { get; set; }



    /// <summary>
    /// Offset of annotation (milliseconds) from start of the recording before removing the cumulative duration of all pauses before this annotation
    /// </summary>
    /// <value>Offset of annotation (milliseconds) from start of the recording before removing the cumulative duration of all pauses before this annotation</value>
    [JsonPropertyName("realtimeLocation")]
    public long? RealtimeLocation { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Annotation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
        sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
        sb.Append("  AbsoluteLocation: ").Append(AbsoluteLocation).Append("\n");
        sb.Append("  AbsoluteDurationMs: ").Append(AbsoluteDurationMs).Append("\n");
        sb.Append("  RecordingLocation: ").Append(RecordingLocation).Append("\n");
        sb.Append("  RecordingDurationMs: ").Append(RecordingDurationMs).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  Annotations: ").Append(Annotations).Append("\n");
        sb.Append("  RealtimeLocation: ").Append(RealtimeLocation).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as Annotation);
    }

    /// <summary>
    /// Returns true if Annotation instances are equal
    /// </summary>
    /// <param name="other">Instance of Annotation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Annotation other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Location == other.Location ||
                Location != null &&
                Location.Equals(other.Location)
            ) &&
            (
                DurationMs == other.DurationMs ||
                DurationMs != null &&
                DurationMs.Equals(other.DurationMs)
            ) &&
            (
                AbsoluteLocation == other.AbsoluteLocation ||
                AbsoluteLocation != null &&
                AbsoluteLocation.Equals(other.AbsoluteLocation)
            ) &&
            (
                AbsoluteDurationMs == other.AbsoluteDurationMs ||
                AbsoluteDurationMs != null &&
                AbsoluteDurationMs.Equals(other.AbsoluteDurationMs)
            ) &&
            (
                RecordingLocation == other.RecordingLocation ||
                RecordingLocation != null &&
                RecordingLocation.Equals(other.RecordingLocation)
            ) &&
            (
                RecordingDurationMs == other.RecordingDurationMs ||
                RecordingDurationMs != null &&
                RecordingDurationMs.Equals(other.RecordingDurationMs)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
            ) &&
            (
                Annotations == other.Annotations ||
                Annotations != null &&
                Annotations.SequenceEqual(other.Annotations)
            ) &&
            (
                RealtimeLocation == other.RealtimeLocation ||
                RealtimeLocation != null &&
                RealtimeLocation.Equals(other.RealtimeLocation)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Location != null)
            {
                hash = hash * 59 + Location.GetHashCode();
            }

            if (DurationMs != null)
            {
                hash = hash * 59 + DurationMs.GetHashCode();
            }

            if (AbsoluteLocation != null)
            {
                hash = hash * 59 + AbsoluteLocation.GetHashCode();
            }

            if (AbsoluteDurationMs != null)
            {
                hash = hash * 59 + AbsoluteDurationMs.GetHashCode();
            }

            if (RecordingLocation != null)
            {
                hash = hash * 59 + RecordingLocation.GetHashCode();
            }

            if (RecordingDurationMs != null)
            {
                hash = hash * 59 + RecordingDurationMs.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            if (Annotations != null)
            {
                hash = hash * 59 + Annotations.GetHashCode();
            }

            if (RealtimeLocation != null)
            {
                hash = hash * 59 + RealtimeLocation.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

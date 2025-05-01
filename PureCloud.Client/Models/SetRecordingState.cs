using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SetRecordingState
/// </summary>
[DataContract]
public partial class SetRecordingState : IEquatable<SetRecordingState>
{
    /// <summary>
    /// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings.
    /// </summary>
    /// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecordingStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,

        /// <summary>
        /// Enum Paused for "PAUSED"
        /// </summary>
        [EnumMember(Value = "PAUSED")]
        Paused,

        /// <summary>
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None
    }
    /// <summary>
    /// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings.
    /// </summary>
    /// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings.</value>
    [DataMember(Name = "recordingState", EmitDefaultValue = false)]
    public RecordingStateEnum? RecordingState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SetRecordingState" /> class.
    /// </summary>
    /// <param name="RecordingState">On update, &#39;paused&#39; initiates a secure pause, &#39;active&#39; resumes any paused recordings..</param>
    public SetRecordingState(RecordingStateEnum? RecordingState = null)
    {
        this.RecordingState = RecordingState;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SetRecordingState {\n");

        sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
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
        return Equals(obj as SetRecordingState);
    }

    /// <summary>
    /// Returns true if SetRecordingState instances are equal
    /// </summary>
    /// <param name="other">Instance of SetRecordingState to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SetRecordingState other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RecordingState == other.RecordingState ||
                RecordingState != null &&
                RecordingState.Equals(other.RecordingState)
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
            if (RecordingState != null)
            {
                hash = hash * 59 + RecordingState.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyAppEventsNotificationEventAction
/// </summary>

public partial class JourneyAppEventsNotificationEventAction : IEquatable<JourneyAppEventsNotificationEventAction>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    
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
        /// Enum Accepted for "accepted"
        /// </summary>
        [EnumMember(Value = "accepted")]
        Accepted,

        /// <summary>
        /// Enum Rejected for "rejected"
        /// </summary>
        [EnumMember(Value = "rejected")]
        Rejected,

        /// <summary>
        /// Enum Timedout for "timedout"
        /// </summary>
        [EnumMember(Value = "timedout")]
        Timedout,

        /// <summary>
        /// Enum Errored for "errored"
        /// </summary>
        [EnumMember(Value = "errored")]
        Errored,

        /// <summary>
        /// Enum Ignored for "ignored"
        /// </summary>
        [EnumMember(Value = "ignored")]
        Ignored,

        /// <summary>
        /// Enum Qualified for "qualified"
        /// </summary>
        [EnumMember(Value = "qualified")]
        Qualified,

        /// <summary>
        /// Enum Offered for "offered"
        /// </summary>
        [EnumMember(Value = "offered")]
        Offered,

        /// <summary>
        /// Enum Started for "started"
        /// </summary>
        [EnumMember(Value = "started")]
        Started,

        /// <summary>
        /// Enum Engaged for "engaged"
        /// </summary>
        [EnumMember(Value = "engaged")]
        Engaged,

        /// <summary>
        /// Enum Qualifiedoutsideschedule for "qualifiedOutsideSchedule"
        /// </summary>
        [EnumMember(Value = "qualifiedOutsideSchedule")]
        Qualifiedoutsideschedule,

        /// <summary>
        /// Enum Offeredoutsideschedule for "offeredOutsideSchedule"
        /// </summary>
        [EnumMember(Value = "offeredOutsideSchedule")]
        Offeredoutsideschedule,

        /// <summary>
        /// Enum Abandoned for "abandoned"
        /// </summary>
        [EnumMember(Value = "abandoned")]
        Abandoned,

        /// <summary>
        /// Enum Completed for "completed"
        /// </summary>
        [EnumMember(Value = "completed")]
        Completed,

        /// <summary>
        /// Enum Frequencycapreached for "frequencyCapReached"
        /// </summary>
        [EnumMember(Value = "frequencyCapReached")]
        Frequencycapreached
    }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Webchat for "webchat"
        /// </summary>
        [EnumMember(Value = "webchat")]
        Webchat,

        /// <summary>
        /// Enum Webmessagingoffer for "webMessagingOffer"
        /// </summary>
        [EnumMember(Value = "webMessagingOffer")]
        Webmessagingoffer,

        /// <summary>
        /// Enum Contentoffer for "contentOffer"
        /// </summary>
        [EnumMember(Value = "contentOffer")]
        Contentoffer,

        /// <summary>
        /// Enum Architectflow for "architectFlow"
        /// </summary>
        [EnumMember(Value = "architectFlow")]
        Architectflow
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyAppEventsNotificationEventAction" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="CreatedDate">CreatedDate.</param>
    /// <param name="State">State.</param>
    /// <param name="MediaType">MediaType.</param>
    /// <param name="Prompt">Prompt.</param>
    public JourneyAppEventsNotificationEventAction(string Id = null, DateTime? CreatedDate = null, StateEnum? State = null, MediaTypeEnum? MediaType = null, string Prompt = null)
    {
        this.Id = Id;
        this.CreatedDate = CreatedDate;
        this.State = State;
        this.MediaType = MediaType;
        this.Prompt = Prompt;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }







    /// <summary>
    /// Gets or Sets Prompt
    /// </summary>
    [JsonPropertyName("prompt")]
    public string Prompt { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyAppEventsNotificationEventAction {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Prompt: ").Append(Prompt).Append("\n");
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
        return Equals(obj as JourneyAppEventsNotificationEventAction);
    }

    /// <summary>
    /// Returns true if JourneyAppEventsNotificationEventAction instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyAppEventsNotificationEventAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyAppEventsNotificationEventAction other)
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
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                Prompt == other.Prompt ||
                Prompt != null &&
                Prompt.Equals(other.Prompt)
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

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (Prompt != null)
            {
                hash = hash * 59 + Prompt.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EventAction
/// </summary>
[DataContract]
public partial class EventAction : IEquatable<EventAction>
{
    /// <summary>
    /// Current state of the action (e.g. qualified, succeeded, errored).
    /// </summary>
    /// <value>Current state of the action (e.g. qualified, succeeded, errored).</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// The media type used to deliver the action (e.g. email, webhook).
    /// </summary>
    /// <value>The media type used to deliver the action (e.g. email, webhook).</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Integrationaction for "integrationAction"
        /// </summary>
        [EnumMember(Value = "integrationAction")]
        Integrationaction,

        /// <summary>
        /// Enum Architectflow for "architectFlow"
        /// </summary>
        [EnumMember(Value = "architectFlow")]
        Architectflow,

        /// <summary>
        /// Enum Openaction for "openAction"
        /// </summary>
        [EnumMember(Value = "openAction")]
        Openaction
    }
    /// <summary>
    /// Current state of the action (e.g. qualified, succeeded, errored).
    /// </summary>
    /// <value>Current state of the action (e.g. qualified, succeeded, errored).</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// The media type used to deliver the action (e.g. email, webhook).
    /// </summary>
    /// <value>The media type used to deliver the action (e.g. email, webhook).</value>
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public MediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventAction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EventAction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EventAction" /> class.
    /// </summary>
    /// <param name="Id">ID of the action. (required).</param>
    /// <param name="State">Current state of the action (e.g. qualified, succeeded, errored). (required).</param>
    /// <param name="MediaType">The media type used to deliver the action (e.g. email, webhook). (required).</param>
    /// <param name="Prompt">Prompt of the action to be displayed/sent to the visitor. (required).</param>
    /// <param name="CreatedDate">Timestamp indicating when the action was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public EventAction(string Id = null, StateEnum? State = null, MediaTypeEnum? MediaType = null, string Prompt = null, DateTime? CreatedDate = null)
    {
        this.Id = Id;
        this.State = State;
        this.MediaType = MediaType;
        this.Prompt = Prompt;
        this.CreatedDate = CreatedDate;

    }



    /// <summary>
    /// ID of the action.
    /// </summary>
    /// <value>ID of the action.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }







    /// <summary>
    /// Prompt of the action to be displayed/sent to the visitor.
    /// </summary>
    /// <value>Prompt of the action to be displayed/sent to the visitor.</value>
    [DataMember(Name = "prompt", EmitDefaultValue = false)]
    public string Prompt { get; set; }



    /// <summary>
    /// Timestamp indicating when the action was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the action was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "createdDate", EmitDefaultValue = false)]
    public DateTime? CreatedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventAction {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Prompt: ").Append(Prompt).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
        return this.Equals(obj as EventAction);
    }

    /// <summary>
    /// Returns true if EventAction instances are equal
    /// </summary>
    /// <param name="other">Instance of EventAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventAction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.State == other.State ||
                this.State != null &&
                this.State.Equals(other.State)
            ) &&
            (
                this.MediaType == other.MediaType ||
                this.MediaType != null &&
                this.MediaType.Equals(other.MediaType)
            ) &&
            (
                this.Prompt == other.Prompt ||
                this.Prompt != null &&
                this.Prompt.Equals(other.Prompt)
            ) &&
            (
                this.CreatedDate == other.CreatedDate ||
                this.CreatedDate != null &&
                this.CreatedDate.Equals(other.CreatedDate)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.State != null)
            {
                hash = hash * 59 + this.State.GetHashCode();
            }

            if (this.MediaType != null)
            {
                hash = hash * 59 + this.MediaType.GetHashCode();
            }

            if (this.Prompt != null)
            {
                hash = hash * 59 + this.Prompt.GetHashCode();
            }

            if (this.CreatedDate != null)
            {
                hash = hash * 59 + this.CreatedDate.GetHashCode();
            }

            return hash;
        }
    }
}

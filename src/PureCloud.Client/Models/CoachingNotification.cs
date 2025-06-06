using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CoachingNotification
/// </summary>

public partial class CoachingNotification : IEquatable<CoachingNotification>
{
    /// <summary>
    /// Action causing the notification.
    /// </summary>
    /// <value>Action causing the notification.</value>
    
    public enum ActionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Create for "Create"
        /// </summary>
        [EnumMember(Value = "Create")]
        Create,

        /// <summary>
        /// Enum Update for "Update"
        /// </summary>
        [EnumMember(Value = "Update")]
        Update,

        /// <summary>
        /// Enum Delete for "Delete"
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete,

        /// <summary>
        /// Enum Statuschange for "StatusChange"
        /// </summary>
        [EnumMember(Value = "StatusChange")]
        Statuschange
    }
    /// <summary>
    /// The relationship of this user to this notification's appointment
    /// </summary>
    /// <value>The relationship of this user to this notification's appointment</value>
    
    public enum RelationshipEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Attendee for "Attendee"
        /// </summary>
        [EnumMember(Value = "Attendee")]
        Attendee,

        /// <summary>
        /// Enum Creator for "Creator"
        /// </summary>
        [EnumMember(Value = "Creator")]
        Creator,

        /// <summary>
        /// Enum Facilitator for "Facilitator"
        /// </summary>
        [EnumMember(Value = "Facilitator")]
        Facilitator
    }
    /// <summary>
    /// The status of the appointment for this notification
    /// </summary>
    /// <value>The status of the appointment for this notification</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Scheduled for "Scheduled"
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Invalidschedule for "InvalidSchedule"
        /// </summary>
        [EnumMember(Value = "InvalidSchedule")]
        Invalidschedule
    }
    /// <summary>
    /// Action causing the notification.
    /// </summary>
    /// <value>Action causing the notification.</value>
    [JsonPropertyName("actionType")]
    public ActionTypeEnum? ActionType { get; set; }
    /// <summary>
    /// The relationship of this user to this notification's appointment
    /// </summary>
    /// <value>The relationship of this user to this notification's appointment</value>
    [JsonPropertyName("relationship")]
    public RelationshipEnum? Relationship { get; set; }
    /// <summary>
    /// The status of the appointment for this notification
    /// </summary>
    /// <value>The status of the appointment for this notification</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingNotification" /> class.
    /// </summary>
    /// <param name="MarkedAsRead">Indicates if notification is read or unread.</param>
    public CoachingNotification(bool? MarkedAsRead = null)
    {
        this.MarkedAsRead = MarkedAsRead;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the appointment for this notification.
    /// </summary>
    /// <value>The name of the appointment for this notification.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Indicates if notification is read or unread
    /// </summary>
    /// <value>Indicates if notification is read or unread</value>
    [JsonPropertyName("markedAsRead")]
    public bool? MarkedAsRead { get; set; }







    /// <summary>
    /// The start time of the appointment relating to this notification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time of the appointment relating to this notification. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// The duration of the appointment on this notification
    /// </summary>
    /// <value>The duration of the appointment on this notification</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }





    /// <summary>
    /// The user of this notification
    /// </summary>
    /// <value>The user of this notification</value>
    [JsonPropertyName("user")]
    public UserReference User { get; set; }



    /// <summary>
    /// The appointment
    /// </summary>
    /// <value>The appointment</value>
    [JsonPropertyName("appointment")]
    public CoachingAppointmentResponse Appointment { get; set; }



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
        sb.Append("class CoachingNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  MarkedAsRead: ").Append(MarkedAsRead).Append("\n");
        sb.Append("  ActionType: ").Append(ActionType).Append("\n");
        sb.Append("  Relationship: ").Append(Relationship).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Appointment: ").Append(Appointment).Append("\n");
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
        return Equals(obj as CoachingNotification);
    }

    /// <summary>
    /// Returns true if CoachingNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of CoachingNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CoachingNotification other)
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
                MarkedAsRead == other.MarkedAsRead ||
                MarkedAsRead != null &&
                MarkedAsRead.Equals(other.MarkedAsRead)
            ) &&
            (
                ActionType == other.ActionType ||
                ActionType != null &&
                ActionType.Equals(other.ActionType)
            ) &&
            (
                Relationship == other.Relationship ||
                Relationship != null &&
                Relationship.Equals(other.Relationship)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                LengthInMinutes == other.LengthInMinutes ||
                LengthInMinutes != null &&
                LengthInMinutes.Equals(other.LengthInMinutes)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Appointment == other.Appointment ||
                Appointment != null &&
                Appointment.Equals(other.Appointment)
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

            if (MarkedAsRead != null)
            {
                hash = hash * 59 + MarkedAsRead.GetHashCode();
            }

            if (ActionType != null)
            {
                hash = hash * 59 + ActionType.GetHashCode();
            }

            if (Relationship != null)
            {
                hash = hash * 59 + Relationship.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (LengthInMinutes != null)
            {
                hash = hash * 59 + LengthInMinutes.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Appointment != null)
            {
                hash = hash * 59 + Appointment.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

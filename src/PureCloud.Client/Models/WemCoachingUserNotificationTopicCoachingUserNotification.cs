using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WemCoachingUserNotificationTopicCoachingUserNotification
/// </summary>

public partial class WemCoachingUserNotificationTopicCoachingUserNotification : IEquatable<WemCoachingUserNotificationTopicCoachingUserNotification>
{
    /// <summary>
    /// Gets or Sets ActionType
    /// </summary>
    
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
    /// Gets or Sets Relationship
    /// </summary>
    
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
        /// Enum Facilitator for "Facilitator"
        /// </summary>
        [EnumMember(Value = "Facilitator")]
        Facilitator,

        /// <summary>
        /// Enum Creator for "Creator"
        /// </summary>
        [EnumMember(Value = "Creator")]
        Creator
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
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
    /// Gets or Sets ActionType
    /// </summary>
    [JsonPropertyName("actionType")]
    public ActionTypeEnum? ActionType { get; set; }
    /// <summary>
    /// Gets or Sets Relationship
    /// </summary>
    [JsonPropertyName("relationship")]
    public RelationshipEnum? Relationship { get; set; }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WemCoachingUserNotificationTopicCoachingUserNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="MarkedAsRead">MarkedAsRead.</param>
    /// <param name="ActionType">ActionType.</param>
    /// <param name="Relationship">Relationship.</param>
    /// <param name="Appointment">Appointment.</param>
    /// <param name="DateStart">DateStart.</param>
    /// <param name="LengthInMinutes">LengthInMinutes.</param>
    /// <param name="Status">Status.</param>
    public WemCoachingUserNotificationTopicCoachingUserNotification(string Id = null, string Name = null, bool? MarkedAsRead = null, ActionTypeEnum? ActionType = null, RelationshipEnum? Relationship = null, WemCoachingUserNotificationTopicCoachingAppointmentReference Appointment = null, DateTime? DateStart = null, long? LengthInMinutes = null, StatusEnum? Status = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.MarkedAsRead = MarkedAsRead;
        this.ActionType = ActionType;
        this.Relationship = Relationship;
        this.Appointment = Appointment;
        this.DateStart = DateStart;
        this.LengthInMinutes = LengthInMinutes;
        this.Status = Status;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets MarkedAsRead
    /// </summary>
    [JsonPropertyName("markedAsRead")]
    public bool? MarkedAsRead { get; set; }







    /// <summary>
    /// Gets or Sets Appointment
    /// </summary>
    [JsonPropertyName("appointment")]
    public WemCoachingUserNotificationTopicCoachingAppointmentReference Appointment { get; set; }



    /// <summary>
    /// Gets or Sets DateStart
    /// </summary>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// Gets or Sets LengthInMinutes
    /// </summary>
    [JsonPropertyName("lengthInMinutes")]
    public long? LengthInMinutes { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WemCoachingUserNotificationTopicCoachingUserNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  MarkedAsRead: ").Append(MarkedAsRead).Append("\n");
        sb.Append("  ActionType: ").Append(ActionType).Append("\n");
        sb.Append("  Relationship: ").Append(Relationship).Append("\n");
        sb.Append("  Appointment: ").Append(Appointment).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as WemCoachingUserNotificationTopicCoachingUserNotification);
    }

    /// <summary>
    /// Returns true if WemCoachingUserNotificationTopicCoachingUserNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WemCoachingUserNotificationTopicCoachingUserNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WemCoachingUserNotificationTopicCoachingUserNotification other)
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
                Appointment == other.Appointment ||
                Appointment != null &&
                Appointment.Equals(other.Appointment)
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

            if (Appointment != null)
            {
                hash = hash * 59 + Appointment.GetHashCode();
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

            return hash;
        }
    }
}

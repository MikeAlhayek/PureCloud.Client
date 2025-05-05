using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Coaching appointment response
/// </summary>

public partial class CoachingAppointmentResponse : IEquatable<CoachingAppointmentResponse>
{
    /// <summary>
    /// The status of coaching appointment
    /// </summary>
    /// <value>The status of coaching appointment</value>
    
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
    /// The status of coaching appointment
    /// </summary>
    /// <value>The status of coaching appointment</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CoachingAppointmentResponse" /> class.
    /// </summary>
    public CoachingAppointmentResponse()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of coaching appointment
    /// </summary>
    /// <value>The name of coaching appointment</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }



    /// <summary>
    /// The description of coaching appointment
    /// </summary>
    /// <value>The description of coaching appointment</value>
    [JsonPropertyName("description")]
    public string Description { get; private set; }



    /// <summary>
    /// The date/time the coaching appointment starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the coaching appointment starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; private set; }



    /// <summary>
    /// The duration of coaching appointment in minutes
    /// </summary>
    /// <value>The duration of coaching appointment in minutes</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; private set; }





    /// <summary>
    /// The facilitator of coaching appointment
    /// </summary>
    /// <value>The facilitator of coaching appointment</value>
    [JsonPropertyName("facilitator")]
    public UserReference Facilitator { get; private set; }



    /// <summary>
    /// The list of attendees attending the coaching
    /// </summary>
    /// <value>The list of attendees attending the coaching</value>
    [JsonPropertyName("attendees")]
    public List<UserReference> Attendees { get; private set; }



    /// <summary>
    /// The user who created the coaching appointment
    /// </summary>
    /// <value>The user who created the coaching appointment</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; private set; }



    /// <summary>
    /// The date/time the coaching appointment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the coaching appointment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The last user to modify the coaching appointment
    /// </summary>
    /// <value>The last user to modify the coaching appointment</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; private set; }



    /// <summary>
    /// The date/time the coaching appointment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the coaching appointment was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The list of conversations associated with coaching appointment.
    /// </summary>
    /// <value>The list of conversations associated with coaching appointment.</value>
    [JsonPropertyName("conversations")]
    public List<ConversationReference> Conversations { get; private set; }



    /// <summary>
    /// The list of documents associated with coaching appointment.
    /// </summary>
    /// <value>The list of documents associated with coaching appointment.</value>
    [JsonPropertyName("documents")]
    public List<DocumentReference> Documents { get; private set; }



    /// <summary>
    /// Whether the appointment is overdue.
    /// </summary>
    /// <value>Whether the appointment is overdue.</value>
    [JsonPropertyName("isOverdue")]
    public bool? IsOverdue { get; private set; }



    /// <summary>
    /// The Workforce Management schedule the appointment is associated with.
    /// </summary>
    /// <value>The Workforce Management schedule the appointment is associated with.</value>
    [JsonPropertyName("wfmSchedule")]
    public WfmScheduleReference WfmSchedule { get; private set; }



    /// <summary>
    /// The date/time the coaching appointment was set to completed status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the coaching appointment was set to completed status. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCompleted")]
    public DateTime? DateCompleted { get; private set; }



    /// <summary>
    /// The list of external links related to the appointment
    /// </summary>
    /// <value>The list of external links related to the appointment</value>
    [JsonPropertyName("externalLinks")]
    public List<string> ExternalLinks { get; private set; }



    /// <summary>
    /// The location of the appointment
    /// </summary>
    /// <value>The location of the appointment</value>
    [JsonPropertyName("location")]
    public string Location { get; private set; }



    /// <summary>
    /// Whether to share the insight data
    /// </summary>
    /// <value>Whether to share the insight data</value>
    [JsonPropertyName("shareInsightsData")]
    public bool? ShareInsightsData { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CoachingAppointmentResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Facilitator: ").Append(Facilitator).Append("\n");
        sb.Append("  Attendees: ").Append(Attendees).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Conversations: ").Append(Conversations).Append("\n");
        sb.Append("  Documents: ").Append(Documents).Append("\n");
        sb.Append("  IsOverdue: ").Append(IsOverdue).Append("\n");
        sb.Append("  WfmSchedule: ").Append(WfmSchedule).Append("\n");
        sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
        sb.Append("  ExternalLinks: ").Append(ExternalLinks).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
        sb.Append("  ShareInsightsData: ").Append(ShareInsightsData).Append("\n");
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
        return Equals(obj as CoachingAppointmentResponse);
    }

    /// <summary>
    /// Returns true if CoachingAppointmentResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of CoachingAppointmentResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CoachingAppointmentResponse other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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
                Facilitator == other.Facilitator ||
                Facilitator != null &&
                Facilitator.Equals(other.Facilitator)
            ) &&
            (
                Attendees == other.Attendees ||
                Attendees != null &&
                Attendees.SequenceEqual(other.Attendees)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Conversations == other.Conversations ||
                Conversations != null &&
                Conversations.SequenceEqual(other.Conversations)
            ) &&
            (
                Documents == other.Documents ||
                Documents != null &&
                Documents.SequenceEqual(other.Documents)
            ) &&
            (
                IsOverdue == other.IsOverdue ||
                IsOverdue != null &&
                IsOverdue.Equals(other.IsOverdue)
            ) &&
            (
                WfmSchedule == other.WfmSchedule ||
                WfmSchedule != null &&
                WfmSchedule.Equals(other.WfmSchedule)
            ) &&
            (
                DateCompleted == other.DateCompleted ||
                DateCompleted != null &&
                DateCompleted.Equals(other.DateCompleted)
            ) &&
            (
                ExternalLinks == other.ExternalLinks ||
                ExternalLinks != null &&
                ExternalLinks.SequenceEqual(other.ExternalLinks)
            ) &&
            (
                Location == other.Location ||
                Location != null &&
                Location.Equals(other.Location)
            ) &&
            (
                ShareInsightsData == other.ShareInsightsData ||
                ShareInsightsData != null &&
                ShareInsightsData.Equals(other.ShareInsightsData)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
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

            if (Facilitator != null)
            {
                hash = hash * 59 + Facilitator.GetHashCode();
            }

            if (Attendees != null)
            {
                hash = hash * 59 + Attendees.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Conversations != null)
            {
                hash = hash * 59 + Conversations.GetHashCode();
            }

            if (Documents != null)
            {
                hash = hash * 59 + Documents.GetHashCode();
            }

            if (IsOverdue != null)
            {
                hash = hash * 59 + IsOverdue.GetHashCode();
            }

            if (WfmSchedule != null)
            {
                hash = hash * 59 + WfmSchedule.GetHashCode();
            }

            if (DateCompleted != null)
            {
                hash = hash * 59 + DateCompleted.GetHashCode();
            }

            if (ExternalLinks != null)
            {
                hash = hash * 59 + ExternalLinks.GetHashCode();
            }

            if (Location != null)
            {
                hash = hash * 59 + Location.GetHashCode();
            }

            if (ShareInsightsData != null)
            {
                hash = hash * 59 + ShareInsightsData.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Create coaching appointment request
/// </summary>

public partial class CreateCoachingAppointmentRequest : IEquatable<CreateCoachingAppointmentRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateCoachingAppointmentRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateCoachingAppointmentRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateCoachingAppointmentRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of coaching appointment. (required).</param>
    /// <param name="Description">The description of coaching appointment. (required).</param>
    /// <param name="DateStart">The date/time the coaching appointment starts. Times will be rounded down to the minute. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="LengthInMinutes">The duration of coaching appointment in minutes. (required).</param>
    /// <param name="FacilitatorId">The facilitator ID of coaching appointment..</param>
    /// <param name="AttendeeIds">IDs of attendees in the coaching appointment. (required).</param>
    /// <param name="ConversationIds">IDs of conversations associated with this coaching appointment..</param>
    /// <param name="DocumentIds">IDs of documents associated with this coaching appointment..</param>
    /// <param name="WfmSchedule">The Workforce Management schedule the appointment is associated with..</param>
    /// <param name="ExternalLinks">The list of external links related to the appointment.</param>
    /// <param name="Location">The location of the appointment.</param>
    /// <param name="ShareInsightsData">Whether to share the insight data.</param>
    public CreateCoachingAppointmentRequest(string Name = null, string Description = null, DateTime? DateStart = null, int? LengthInMinutes = null, string FacilitatorId = null, List<string> AttendeeIds = null, List<string> ConversationIds = null, List<string> DocumentIds = null, WfmScheduleReference WfmSchedule = null, List<string> ExternalLinks = null, string Location = null, bool? ShareInsightsData = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.DateStart = DateStart;
        this.LengthInMinutes = LengthInMinutes;
        this.FacilitatorId = FacilitatorId;
        this.AttendeeIds = AttendeeIds;
        this.ConversationIds = ConversationIds;
        this.DocumentIds = DocumentIds;
        this.WfmSchedule = WfmSchedule;
        this.ExternalLinks = ExternalLinks;
        this.Location = Location;
        this.ShareInsightsData = ShareInsightsData;

    }



    /// <summary>
    /// The name of coaching appointment.
    /// </summary>
    /// <value>The name of coaching appointment.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The description of coaching appointment.
    /// </summary>
    /// <value>The description of coaching appointment.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The date/time the coaching appointment starts. Times will be rounded down to the minute. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date/time the coaching appointment starts. Times will be rounded down to the minute. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// The duration of coaching appointment in minutes.
    /// </summary>
    /// <value>The duration of coaching appointment in minutes.</value>
    [JsonPropertyName("lengthInMinutes")]
    public int? LengthInMinutes { get; set; }



    /// <summary>
    /// The facilitator ID of coaching appointment.
    /// </summary>
    /// <value>The facilitator ID of coaching appointment.</value>
    [JsonPropertyName("facilitatorId")]
    public string FacilitatorId { get; set; }



    /// <summary>
    /// IDs of attendees in the coaching appointment.
    /// </summary>
    /// <value>IDs of attendees in the coaching appointment.</value>
    [JsonPropertyName("attendeeIds")]
    public List<string> AttendeeIds { get; set; }



    /// <summary>
    /// IDs of conversations associated with this coaching appointment.
    /// </summary>
    /// <value>IDs of conversations associated with this coaching appointment.</value>
    [JsonPropertyName("conversationIds")]
    public List<string> ConversationIds { get; set; }



    /// <summary>
    /// IDs of documents associated with this coaching appointment.
    /// </summary>
    /// <value>IDs of documents associated with this coaching appointment.</value>
    [JsonPropertyName("documentIds")]
    public List<string> DocumentIds { get; set; }



    /// <summary>
    /// The Workforce Management schedule the appointment is associated with.
    /// </summary>
    /// <value>The Workforce Management schedule the appointment is associated with.</value>
    [JsonPropertyName("wfmSchedule")]
    public WfmScheduleReference WfmSchedule { get; set; }



    /// <summary>
    /// The list of external links related to the appointment
    /// </summary>
    /// <value>The list of external links related to the appointment</value>
    [JsonPropertyName("externalLinks")]
    public List<string> ExternalLinks { get; set; }



    /// <summary>
    /// The location of the appointment
    /// </summary>
    /// <value>The location of the appointment</value>
    [JsonPropertyName("location")]
    public string Location { get; set; }



    /// <summary>
    /// Whether to share the insight data
    /// </summary>
    /// <value>Whether to share the insight data</value>
    [JsonPropertyName("shareInsightsData")]
    public bool? ShareInsightsData { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateCoachingAppointmentRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  LengthInMinutes: ").Append(LengthInMinutes).Append("\n");
        sb.Append("  FacilitatorId: ").Append(FacilitatorId).Append("\n");
        sb.Append("  AttendeeIds: ").Append(AttendeeIds).Append("\n");
        sb.Append("  ConversationIds: ").Append(ConversationIds).Append("\n");
        sb.Append("  DocumentIds: ").Append(DocumentIds).Append("\n");
        sb.Append("  WfmSchedule: ").Append(WfmSchedule).Append("\n");
        sb.Append("  ExternalLinks: ").Append(ExternalLinks).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
        sb.Append("  ShareInsightsData: ").Append(ShareInsightsData).Append("\n");
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
        return Equals(obj as CreateCoachingAppointmentRequest);
    }

    /// <summary>
    /// Returns true if CreateCoachingAppointmentRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateCoachingAppointmentRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateCoachingAppointmentRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                FacilitatorId == other.FacilitatorId ||
                FacilitatorId != null &&
                FacilitatorId.Equals(other.FacilitatorId)
            ) &&
            (
                AttendeeIds == other.AttendeeIds ||
                AttendeeIds != null &&
                AttendeeIds.SequenceEqual(other.AttendeeIds)
            ) &&
            (
                ConversationIds == other.ConversationIds ||
                ConversationIds != null &&
                ConversationIds.SequenceEqual(other.ConversationIds)
            ) &&
            (
                DocumentIds == other.DocumentIds ||
                DocumentIds != null &&
                DocumentIds.SequenceEqual(other.DocumentIds)
            ) &&
            (
                WfmSchedule == other.WfmSchedule ||
                WfmSchedule != null &&
                WfmSchedule.Equals(other.WfmSchedule)
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

            if (FacilitatorId != null)
            {
                hash = hash * 59 + FacilitatorId.GetHashCode();
            }

            if (AttendeeIds != null)
            {
                hash = hash * 59 + AttendeeIds.GetHashCode();
            }

            if (ConversationIds != null)
            {
                hash = hash * 59 + ConversationIds.GetHashCode();
            }

            if (DocumentIds != null)
            {
                hash = hash * 59 + DocumentIds.GetHashCode();
            }

            if (WfmSchedule != null)
            {
                hash = hash * 59 + WfmSchedule.GetHashCode();
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

            return hash;
        }
    }
}

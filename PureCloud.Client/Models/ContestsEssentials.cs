using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestsEssentials
/// </summary>
[DataContract]
public partial class ContestsEssentials : IEquatable<ContestsEssentials>
{
    /// <summary>
    /// The Contest status
    /// </summary>
    /// <value>The Contest status</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Upcoming for "Upcoming"
        /// </summary>
        [EnumMember(Value = "Upcoming")]
        Upcoming,

        /// <summary>
        /// Enum Ongoing for "Ongoing"
        /// </summary>
        [EnumMember(Value = "Ongoing")]
        Ongoing,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Recentlycompleted for "RecentlyCompleted"
        /// </summary>
        [EnumMember(Value = "RecentlyCompleted")]
        Recentlycompleted,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Cancelled for "Cancelled"
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled
    }
    /// <summary>
    /// The Contest status
    /// </summary>
    /// <value>The Contest status</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContestsEssentials" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContestsEssentials() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestsEssentials" /> class.
    /// </summary>
    /// <param name="Title">The Contest title (required).</param>
    /// <param name="Status">The Contest status.</param>
    /// <param name="DateStart">Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="DateEnd">End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="Profile">The performance profile.</param>
    /// <param name="ParticipantCount">The Number of participants in the contest.</param>
    /// <param name="DateAnnounced">The Contest&#39;s Announcement datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="DateFinalized">The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateCancelled">The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateScoresModified">The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Metrics">The Contest&#39;s Metrics (required).</param>
    /// <param name="RequestingParticipantContestInfo">The Most Recent Contest Info for the requesting participant.</param>
    public ContestsEssentials(string Title = null, StatusEnum? Status = null, string DateStart = null, string DateEnd = null, ContestProfile Profile = null, int? ParticipantCount = null, DateTime? DateAnnounced = null, DateTime? DateFinalized = null, DateTime? DateCancelled = null, DateTime? DateModified = null, DateTime? DateScoresModified = null, List<ContestMetrics> Metrics = null, ContestRequesingParticipantDailyInfo RequestingParticipantContestInfo = null)
    {
        this.Title = Title;
        this.Status = Status;
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;
        this.Profile = Profile;
        this.ParticipantCount = ParticipantCount;
        this.DateAnnounced = DateAnnounced;
        this.DateFinalized = DateFinalized;
        this.DateCancelled = DateCancelled;
        this.DateModified = DateModified;
        this.DateScoresModified = DateScoresModified;
        this.Metrics = Metrics;
        this.RequestingParticipantContestInfo = RequestingParticipantContestInfo;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The Contest title
    /// </summary>
    /// <value>The Contest title</value>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }





    /// <summary>
    /// Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateStart", EmitDefaultValue = false)]
    public string DateStart { get; set; }



    /// <summary>
    /// End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateEnd", EmitDefaultValue = false)]
    public string DateEnd { get; set; }



    /// <summary>
    /// The performance profile
    /// </summary>
    /// <value>The performance profile</value>
    [DataMember(Name = "profile", EmitDefaultValue = false)]
    public ContestProfile Profile { get; set; }



    /// <summary>
    /// The Number of participants in the contest
    /// </summary>
    /// <value>The Number of participants in the contest</value>
    [DataMember(Name = "participantCount", EmitDefaultValue = false)]
    public int? ParticipantCount { get; set; }



    /// <summary>
    /// The Contest&#39;s Announcement datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s Announcement datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateAnnounced", EmitDefaultValue = false)]
    public DateTime? DateAnnounced { get; set; }



    /// <summary>
    /// The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateFinalized", EmitDefaultValue = false)]
    public DateTime? DateFinalized { get; set; }



    /// <summary>
    /// The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCancelled", EmitDefaultValue = false)]
    public DateTime? DateCancelled { get; set; }



    /// <summary>
    /// The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateScoresModified", EmitDefaultValue = false)]
    public DateTime? DateScoresModified { get; set; }



    /// <summary>
    /// The Contest&#39;s Metrics
    /// </summary>
    /// <value>The Contest&#39;s Metrics</value>
    [DataMember(Name = "metrics", EmitDefaultValue = false)]
    public List<ContestMetrics> Metrics { get; set; }



    /// <summary>
    /// The Most Recent Contest Info for the requesting participant
    /// </summary>
    /// <value>The Most Recent Contest Info for the requesting participant</value>
    [DataMember(Name = "requestingParticipantContestInfo", EmitDefaultValue = false)]
    public ContestRequesingParticipantDailyInfo RequestingParticipantContestInfo { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestsEssentials {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
        sb.Append("  Profile: ").Append(Profile).Append("\n");
        sb.Append("  ParticipantCount: ").Append(ParticipantCount).Append("\n");
        sb.Append("  DateAnnounced: ").Append(DateAnnounced).Append("\n");
        sb.Append("  DateFinalized: ").Append(DateFinalized).Append("\n");
        sb.Append("  DateCancelled: ").Append(DateCancelled).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateScoresModified: ").Append(DateScoresModified).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  RequestingParticipantContestInfo: ").Append(RequestingParticipantContestInfo).Append("\n");
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
        return Equals(obj as ContestsEssentials);
    }

    /// <summary>
    /// Returns true if ContestsEssentials instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestsEssentials to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestsEssentials other)
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
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
            ) &&
            (
                Profile == other.Profile ||
                Profile != null &&
                Profile.Equals(other.Profile)
            ) &&
            (
                ParticipantCount == other.ParticipantCount ||
                ParticipantCount != null &&
                ParticipantCount.Equals(other.ParticipantCount)
            ) &&
            (
                DateAnnounced == other.DateAnnounced ||
                DateAnnounced != null &&
                DateAnnounced.Equals(other.DateAnnounced)
            ) &&
            (
                DateFinalized == other.DateFinalized ||
                DateFinalized != null &&
                DateFinalized.Equals(other.DateFinalized)
            ) &&
            (
                DateCancelled == other.DateCancelled ||
                DateCancelled != null &&
                DateCancelled.Equals(other.DateCancelled)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                DateScoresModified == other.DateScoresModified ||
                DateScoresModified != null &&
                DateScoresModified.Equals(other.DateScoresModified)
            ) &&
            (
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                RequestingParticipantContestInfo == other.RequestingParticipantContestInfo ||
                RequestingParticipantContestInfo != null &&
                RequestingParticipantContestInfo.Equals(other.RequestingParticipantContestInfo)
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

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            if (Profile != null)
            {
                hash = hash * 59 + Profile.GetHashCode();
            }

            if (ParticipantCount != null)
            {
                hash = hash * 59 + ParticipantCount.GetHashCode();
            }

            if (DateAnnounced != null)
            {
                hash = hash * 59 + DateAnnounced.GetHashCode();
            }

            if (DateFinalized != null)
            {
                hash = hash * 59 + DateFinalized.GetHashCode();
            }

            if (DateCancelled != null)
            {
                hash = hash * 59 + DateCancelled.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DateScoresModified != null)
            {
                hash = hash * 59 + DateScoresModified.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (RequestingParticipantContestInfo != null)
            {
                hash = hash * 59 + RequestingParticipantContestInfo.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

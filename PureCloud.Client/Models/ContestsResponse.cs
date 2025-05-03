using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestsResponse
/// </summary>

public partial class ContestsResponse : IEquatable<ContestsResponse>
{
    /// <summary>
    /// The Contest winning criteria
    /// </summary>
    /// <value>The Contest winning criteria</value>
    
    public enum WinningCriteriaEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Highestoverallscore for "HighestOverallScore"
        /// </summary>
        [EnumMember(Value = "HighestOverallScore")]
        Highestoverallscore,

        /// <summary>
        /// Enum Highestoverallpercentofgoal for "HighestOverallPercentOfGoal"
        /// </summary>
        [EnumMember(Value = "HighestOverallPercentOfGoal")]
        Highestoverallpercentofgoal
    }
    /// <summary>
    /// The Contest anonymization
    /// </summary>
    /// <value>The Contest anonymization</value>
    
    public enum AnonymizationEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Noanonymization for "NoAnonymization"
        /// </summary>
        [EnumMember(Value = "NoAnonymization")]
        Noanonymization,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All,

        /// <summary>
        /// Enum Allexcepttop for "AllExceptTop"
        /// </summary>
        [EnumMember(Value = "AllExceptTop")]
        Allexcepttop
    }
    /// <summary>
    /// The Contest status
    /// </summary>
    /// <value>The Contest status</value>
    
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
    /// The Contest winning criteria
    /// </summary>
    /// <value>The Contest winning criteria</value>
    [JsonPropertyName("winningCriteria")]
    public WinningCriteriaEnum? WinningCriteria { get; set; }
    /// <summary>
    /// The Contest anonymization
    /// </summary>
    /// <value>The Contest anonymization</value>
    [JsonPropertyName("anonymization")]
    public AnonymizationEnum? Anonymization { get; set; }
    /// <summary>
    /// The Contest status
    /// </summary>
    /// <value>The Contest status</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContestsResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContestsResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestsResponse" /> class.
    /// </summary>
    /// <param name="Division">The division for this performance profile associate to.</param>
    /// <param name="Title">The Contest title (required).</param>
    /// <param name="Description">The Contest description (required).</param>
    /// <param name="DateStart">Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="DateEnd">End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd (required).</param>
    /// <param name="WinningCriteria">The Contest winning criteria (required).</param>
    /// <param name="DateAnnounced">The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="AnnouncementTimezone">The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London (required).</param>
    /// <param name="Anonymization">The Contest anonymization (required).</param>
    /// <param name="Metrics">The Contest&#39;s Metrics (required).</param>
    /// <param name="Prizes">The Contest Prizes (required).</param>
    /// <param name="Version">The Contest Version.</param>
    /// <param name="CreatedBy">The creator of the contest.</param>
    /// <param name="Profile">The performance profile.</param>
    /// <param name="Participants">The Contest&#39;s participants.</param>
    /// <param name="Status">The Contest status.</param>
    /// <param name="ParticipantCount">The Number of participants in the contest.</param>
    /// <param name="DateFinalized">The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateCancelled">The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateScoresModified">The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Winners">The Contest Winners.</param>
    /// <param name="DisqualifiedAgents">The Contest&#39;s disqualified agents, returned when a contest is complete.</param>
    public ContestsResponse(WritableDivision Division = null, string Title = null, string Description = null, string DateStart = null, string DateEnd = null, WinningCriteriaEnum? WinningCriteria = null, DateTime? DateAnnounced = null, string AnnouncementTimezone = null, AnonymizationEnum? Anonymization = null, List<ContestMetrics> Metrics = null, List<ContestPrizes> Prizes = null, int? Version = null, UserReference CreatedBy = null, ContestProfile Profile = null, List<UserReference> Participants = null, StatusEnum? Status = null, int? ParticipantCount = null, DateTime? DateFinalized = null, DateTime? DateCancelled = null, DateTime? DateModified = null, DateTime? DateScoresModified = null, List<ContestWinners> Winners = null, List<ContestDisqualifiedAgents> DisqualifiedAgents = null)
    {
        this.Division = Division;
        this.Title = Title;
        this.Description = Description;
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;
        this.WinningCriteria = WinningCriteria;
        this.DateAnnounced = DateAnnounced;
        this.AnnouncementTimezone = AnnouncementTimezone;
        this.Anonymization = Anonymization;
        this.Metrics = Metrics;
        this.Prizes = Prizes;
        this.Version = Version;
        this.CreatedBy = CreatedBy;
        this.Profile = Profile;
        this.Participants = Participants;
        this.Status = Status;
        this.ParticipantCount = ParticipantCount;
        this.DateFinalized = DateFinalized;
        this.DateCancelled = DateCancelled;
        this.DateModified = DateModified;
        this.DateScoresModified = DateScoresModified;
        this.Winners = Winners;
        this.DisqualifiedAgents = DisqualifiedAgents;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The division for this performance profile associate to
    /// </summary>
    /// <value>The division for this performance profile associate to</value>
    [JsonPropertyName("division")]
    public WritableDivision Division { get; set; }



    /// <summary>
    /// The Contest title
    /// </summary>
    /// <value>The Contest title</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// The Contest description
    /// </summary>
    /// <value>The Contest description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStart")]
    public string DateStart { get; set; }



    /// <summary>
    /// End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End date of the contest. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEnd")]
    public string DateEnd { get; set; }





    /// <summary>
    /// The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s Announcement Datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateAnnounced")]
    public DateTime? DateAnnounced { get; set; }



    /// <summary>
    /// The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
    /// </summary>
    /// <value>The Contest&#39;s Announcement Timezone. Valid values are strings of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
    [JsonPropertyName("announcementTimezone")]
    public string AnnouncementTimezone { get; set; }





    /// <summary>
    /// The Contest&#39;s Metrics
    /// </summary>
    /// <value>The Contest&#39;s Metrics</value>
    [JsonPropertyName("metrics")]
    public List<ContestMetrics> Metrics { get; set; }



    /// <summary>
    /// The Contest Prizes
    /// </summary>
    /// <value>The Contest Prizes</value>
    [JsonPropertyName("prizes")]
    public List<ContestPrizes> Prizes { get; set; }



    /// <summary>
    /// The Contest Version
    /// </summary>
    /// <value>The Contest Version</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The creator of the contest
    /// </summary>
    /// <value>The creator of the contest</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The performance profile
    /// </summary>
    /// <value>The performance profile</value>
    [JsonPropertyName("profile")]
    public ContestProfile Profile { get; set; }



    /// <summary>
    /// The Contest&#39;s participants
    /// </summary>
    /// <value>The Contest&#39;s participants</value>
    [JsonPropertyName("participants")]
    public List<UserReference> Participants { get; set; }





    /// <summary>
    /// The Number of participants in the contest
    /// </summary>
    /// <value>The Number of participants in the contest</value>
    [JsonPropertyName("participantCount")]
    public int? ParticipantCount { get; set; }



    /// <summary>
    /// The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s finalize datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateFinalized")]
    public DateTime? DateFinalized { get; set; }



    /// <summary>
    /// The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s cancelled datetime, returned when a contest is complete. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCancelled")]
    public DateTime? DateCancelled { get; set; }



    /// <summary>
    /// The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Contest&#39;s last modified datetime. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The datetime the contest scores were last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateScoresModified")]
    public DateTime? DateScoresModified { get; set; }



    /// <summary>
    /// The Contest Winners
    /// </summary>
    /// <value>The Contest Winners</value>
    [JsonPropertyName("winners")]
    public List<ContestWinners> Winners { get; set; }



    /// <summary>
    /// The Contest&#39;s disqualified agents, returned when a contest is complete
    /// </summary>
    /// <value>The Contest&#39;s disqualified agents, returned when a contest is complete</value>
    [JsonPropertyName("disqualifiedAgents")]
    public List<ContestDisqualifiedAgents> DisqualifiedAgents { get; set; }



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
        sb.Append("class ContestsResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
        sb.Append("  WinningCriteria: ").Append(WinningCriteria).Append("\n");
        sb.Append("  DateAnnounced: ").Append(DateAnnounced).Append("\n");
        sb.Append("  AnnouncementTimezone: ").Append(AnnouncementTimezone).Append("\n");
        sb.Append("  Anonymization: ").Append(Anonymization).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  Prizes: ").Append(Prizes).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  Profile: ").Append(Profile).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  ParticipantCount: ").Append(ParticipantCount).Append("\n");
        sb.Append("  DateFinalized: ").Append(DateFinalized).Append("\n");
        sb.Append("  DateCancelled: ").Append(DateCancelled).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateScoresModified: ").Append(DateScoresModified).Append("\n");
        sb.Append("  Winners: ").Append(Winners).Append("\n");
        sb.Append("  DisqualifiedAgents: ").Append(DisqualifiedAgents).Append("\n");
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
        return Equals(obj as ContestsResponse);
    }

    /// <summary>
    /// Returns true if ContestsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestsResponse other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
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
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
            ) &&
            (
                WinningCriteria == other.WinningCriteria ||
                WinningCriteria != null &&
                WinningCriteria.Equals(other.WinningCriteria)
            ) &&
            (
                DateAnnounced == other.DateAnnounced ||
                DateAnnounced != null &&
                DateAnnounced.Equals(other.DateAnnounced)
            ) &&
            (
                AnnouncementTimezone == other.AnnouncementTimezone ||
                AnnouncementTimezone != null &&
                AnnouncementTimezone.Equals(other.AnnouncementTimezone)
            ) &&
            (
                Anonymization == other.Anonymization ||
                Anonymization != null &&
                Anonymization.Equals(other.Anonymization)
            ) &&
            (
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.SequenceEqual(other.Metrics)
            ) &&
            (
                Prizes == other.Prizes ||
                Prizes != null &&
                Prizes.SequenceEqual(other.Prizes)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                Profile == other.Profile ||
                Profile != null &&
                Profile.Equals(other.Profile)
            ) &&
            (
                Participants == other.Participants ||
                Participants != null &&
                Participants.SequenceEqual(other.Participants)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                ParticipantCount == other.ParticipantCount ||
                ParticipantCount != null &&
                ParticipantCount.Equals(other.ParticipantCount)
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
                Winners == other.Winners ||
                Winners != null &&
                Winners.SequenceEqual(other.Winners)
            ) &&
            (
                DisqualifiedAgents == other.DisqualifiedAgents ||
                DisqualifiedAgents != null &&
                DisqualifiedAgents.SequenceEqual(other.DisqualifiedAgents)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            if (WinningCriteria != null)
            {
                hash = hash * 59 + WinningCriteria.GetHashCode();
            }

            if (DateAnnounced != null)
            {
                hash = hash * 59 + DateAnnounced.GetHashCode();
            }

            if (AnnouncementTimezone != null)
            {
                hash = hash * 59 + AnnouncementTimezone.GetHashCode();
            }

            if (Anonymization != null)
            {
                hash = hash * 59 + Anonymization.GetHashCode();
            }

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (Prizes != null)
            {
                hash = hash * 59 + Prizes.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (Profile != null)
            {
                hash = hash * 59 + Profile.GetHashCode();
            }

            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (ParticipantCount != null)
            {
                hash = hash * 59 + ParticipantCount.GetHashCode();
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

            if (Winners != null)
            {
                hash = hash * 59 + Winners.GetHashCode();
            }

            if (DisqualifiedAgents != null)
            {
                hash = hash * 59 + DisqualifiedAgents.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

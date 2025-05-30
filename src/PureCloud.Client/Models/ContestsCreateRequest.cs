using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestsCreateRequest
/// </summary>

public partial class ContestsCreateRequest : IEquatable<ContestsCreateRequest>
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
    /// Initializes a new instance of the <see cref="ContestsCreateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContestsCreateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestsCreateRequest" /> class.
    /// </summary>
    /// <param name="Division">The division for this performance profile associate to. Only set for DEFAULT profile..</param>
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
    /// <param name="ProfileId">The Contest profile (required).</param>
    /// <param name="ParticipantIds">The Contest&#39;s participants (required).</param>
    public ContestsCreateRequest(WritableDivision Division = null, string Title = null, string Description = null, string DateStart = null, string DateEnd = null, WinningCriteriaEnum? WinningCriteria = null, DateTime? DateAnnounced = null, string AnnouncementTimezone = null, AnonymizationEnum? Anonymization = null, List<ContestMetrics> Metrics = null, List<ContestPrizes> Prizes = null, string ProfileId = null, List<string> ParticipantIds = null)
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
        this.ProfileId = ProfileId;
        this.ParticipantIds = ParticipantIds;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The division for this performance profile associate to. Only set for DEFAULT profile.
    /// </summary>
    /// <value>The division for this performance profile associate to. Only set for DEFAULT profile.</value>
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
    /// The Contest profile
    /// </summary>
    /// <value>The Contest profile</value>
    [JsonPropertyName("profileId")]
    public string ProfileId { get; set; }



    /// <summary>
    /// The Contest&#39;s participants
    /// </summary>
    /// <value>The Contest&#39;s participants</value>
    [JsonPropertyName("participantIds")]
    public List<string> ParticipantIds { get; set; }



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
        sb.Append("class ContestsCreateRequest {\n");

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
        sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
        sb.Append("  ParticipantIds: ").Append(ParticipantIds).Append("\n");
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
        return Equals(obj as ContestsCreateRequest);
    }

    /// <summary>
    /// Returns true if ContestsCreateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestsCreateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestsCreateRequest other)
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
                ProfileId == other.ProfileId ||
                ProfileId != null &&
                ProfileId.Equals(other.ProfileId)
            ) &&
            (
                ParticipantIds == other.ParticipantIds ||
                ParticipantIds != null &&
                ParticipantIds.SequenceEqual(other.ParticipantIds)
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

            if (ProfileId != null)
            {
                hash = hash * 59 + ProfileId.GetHashCode();
            }

            if (ParticipantIds != null)
            {
                hash = hash * 59 + ParticipantIds.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

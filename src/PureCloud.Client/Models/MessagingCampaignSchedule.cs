using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessagingCampaignSchedule
/// </summary>

public partial class MessagingCampaignSchedule : IEquatable<MessagingCampaignSchedule>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingCampaignSchedule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessagingCampaignSchedule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingCampaignSchedule" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="Intervals">A list of intervals during which to run the associated Campaign. (required).</param>
    /// <param name="Recurrences">Recurring schedules of the campaign.</param>
    /// <param name="TimeZone">The time zone for this messaging campaign schedule. Defaults to UTC if empty or not provided. See here for a list of valid time zones https://www.iana.org/time-zones.</param>
    /// <param name="MessagingCampaign">The Campaign that this messaging campaign schedule is for. (required).</param>
    public MessagingCampaignSchedule(string Name = null, int? Version = null, List<ScheduleInterval> Intervals = null, List<Reoccurrence> Recurrences = null, string TimeZone = null, DivisionedDomainEntityRef MessagingCampaign = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.Intervals = Intervals;
        this.Recurrences = Recurrences;
        this.TimeZone = TimeZone;
        this.MessagingCampaign = MessagingCampaign;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// A list of intervals during which to run the associated Campaign.
    /// </summary>
    /// <value>A list of intervals during which to run the associated Campaign.</value>
    [JsonPropertyName("intervals")]
    public List<ScheduleInterval> Intervals { get; set; }



    /// <summary>
    /// Recurring schedules of the campaign
    /// </summary>
    /// <value>Recurring schedules of the campaign</value>
    [JsonPropertyName("recurrences")]
    public List<Reoccurrence> Recurrences { get; set; }



    /// <summary>
    /// The time zone for this messaging campaign schedule. Defaults to UTC if empty or not provided. See here for a list of valid time zones https://www.iana.org/time-zones
    /// </summary>
    /// <value>The time zone for this messaging campaign schedule. Defaults to UTC if empty or not provided. See here for a list of valid time zones https://www.iana.org/time-zones</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }



    /// <summary>
    /// The Campaign that this messaging campaign schedule is for.
    /// </summary>
    /// <value>The Campaign that this messaging campaign schedule is for.</value>
    [JsonPropertyName("messagingCampaign")]
    public DivisionedDomainEntityRef MessagingCampaign { get; set; }



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
        sb.Append("class MessagingCampaignSchedule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Intervals: ").Append(Intervals).Append("\n");
        sb.Append("  Recurrences: ").Append(Recurrences).Append("\n");
        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  MessagingCampaign: ").Append(MessagingCampaign).Append("\n");
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
        return Equals(obj as MessagingCampaignSchedule);
    }

    /// <summary>
    /// Returns true if MessagingCampaignSchedule instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingCampaignSchedule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingCampaignSchedule other)
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Intervals == other.Intervals ||
                Intervals != null &&
                Intervals.SequenceEqual(other.Intervals)
            ) &&
            (
                Recurrences == other.Recurrences ||
                Recurrences != null &&
                Recurrences.SequenceEqual(other.Recurrences)
            ) &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                MessagingCampaign == other.MessagingCampaign ||
                MessagingCampaign != null &&
                MessagingCampaign.Equals(other.MessagingCampaign)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Intervals != null)
            {
                hash = hash * 59 + Intervals.GetHashCode();
            }

            if (Recurrences != null)
            {
                hash = hash * 59 + Recurrences.GetHashCode();
            }

            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (MessagingCampaign != null)
            {
                hash = hash * 59 + MessagingCampaign.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

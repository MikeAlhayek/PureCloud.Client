using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AttemptLimits
/// </summary>

public partial class AttemptLimits : IEquatable<AttemptLimits>
{
    /// <summary>
    /// After how long the number of attempts will be set back to 0. Defaults to NEVER.
    /// </summary>
    /// <value>After how long the number of attempts will be set back to 0. Defaults to NEVER.</value>
    
    public enum ResetPeriodEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Never for "NEVER"
        /// </summary>
        [EnumMember(Value = "NEVER")]
        Never,

        /// <summary>
        /// Enum Today for "TODAY"
        /// </summary>
        [EnumMember(Value = "TODAY")]
        Today
    }
    /// <summary>
    /// After how long the number of attempts will be set back to 0. Defaults to NEVER.
    /// </summary>
    /// <value>After how long the number of attempts will be set back to 0. Defaults to NEVER.</value>
    [JsonPropertyName("resetPeriod")]
    public ResetPeriodEnum? ResetPeriod { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AttemptLimits" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="MaxAttemptsPerContact">The maximum number of times a contact can be called within the resetPeriod. Required if maxAttemptsPerNumber is not defined..</param>
    /// <param name="MaxAttemptsPerNumber">The maximum number of times a phone number can be called within the resetPeriod. Required if maxAttemptsPerContact is not defined..</param>
    /// <param name="TimeZoneId">If the resetPeriod is TODAY, this specifies the timezone in which TODAY occurs. Required if the resetPeriod is TODAY..</param>
    /// <param name="ResetPeriod">After how long the number of attempts will be set back to 0. Defaults to NEVER..</param>
    /// <param name="RecallEntries">Configuration for recall attempts..</param>
    public AttemptLimits(string Name = null, int? Version = null, int? MaxAttemptsPerContact = null, int? MaxAttemptsPerNumber = null, string TimeZoneId = null, ResetPeriodEnum? ResetPeriod = null, Dictionary<string, RecallEntry> RecallEntries = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.MaxAttemptsPerContact = MaxAttemptsPerContact;
        this.MaxAttemptsPerNumber = MaxAttemptsPerNumber;
        this.TimeZoneId = TimeZoneId;
        this.ResetPeriod = ResetPeriod;
        this.RecallEntries = RecallEntries;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



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
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// The maximum number of times a contact can be called within the resetPeriod. Required if maxAttemptsPerNumber is not defined.
    /// </summary>
    /// <value>The maximum number of times a contact can be called within the resetPeriod. Required if maxAttemptsPerNumber is not defined.</value>
    [JsonPropertyName("maxAttemptsPerContact")]
    public int? MaxAttemptsPerContact { get; set; }



    /// <summary>
    /// The maximum number of times a phone number can be called within the resetPeriod. Required if maxAttemptsPerContact is not defined.
    /// </summary>
    /// <value>The maximum number of times a phone number can be called within the resetPeriod. Required if maxAttemptsPerContact is not defined.</value>
    [JsonPropertyName("maxAttemptsPerNumber")]
    public int? MaxAttemptsPerNumber { get; set; }



    /// <summary>
    /// If the resetPeriod is TODAY, this specifies the timezone in which TODAY occurs. Required if the resetPeriod is TODAY.
    /// </summary>
    /// <value>If the resetPeriod is TODAY, this specifies the timezone in which TODAY occurs. Required if the resetPeriod is TODAY.</value>
    [JsonPropertyName("timeZoneId")]
    public string TimeZoneId { get; set; }





    /// <summary>
    /// Configuration for recall attempts.
    /// </summary>
    /// <value>Configuration for recall attempts.</value>
    [JsonPropertyName("recallEntries")]
    public Dictionary<string, RecallEntry> RecallEntries { get; set; }



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
        sb.Append("class AttemptLimits {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  MaxAttemptsPerContact: ").Append(MaxAttemptsPerContact).Append("\n");
        sb.Append("  MaxAttemptsPerNumber: ").Append(MaxAttemptsPerNumber).Append("\n");
        sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
        sb.Append("  ResetPeriod: ").Append(ResetPeriod).Append("\n");
        sb.Append("  RecallEntries: ").Append(RecallEntries).Append("\n");
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
        return Equals(obj as AttemptLimits);
    }

    /// <summary>
    /// Returns true if AttemptLimits instances are equal
    /// </summary>
    /// <param name="other">Instance of AttemptLimits to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AttemptLimits other)
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
                MaxAttemptsPerContact == other.MaxAttemptsPerContact ||
                MaxAttemptsPerContact != null &&
                MaxAttemptsPerContact.Equals(other.MaxAttemptsPerContact)
            ) &&
            (
                MaxAttemptsPerNumber == other.MaxAttemptsPerNumber ||
                MaxAttemptsPerNumber != null &&
                MaxAttemptsPerNumber.Equals(other.MaxAttemptsPerNumber)
            ) &&
            (
                TimeZoneId == other.TimeZoneId ||
                TimeZoneId != null &&
                TimeZoneId.Equals(other.TimeZoneId)
            ) &&
            (
                ResetPeriod == other.ResetPeriod ||
                ResetPeriod != null &&
                ResetPeriod.Equals(other.ResetPeriod)
            ) &&
            (
                RecallEntries == other.RecallEntries ||
                RecallEntries != null &&
                RecallEntries.SequenceEqual(other.RecallEntries)
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

            if (MaxAttemptsPerContact != null)
            {
                hash = hash * 59 + MaxAttemptsPerContact.GetHashCode();
            }

            if (MaxAttemptsPerNumber != null)
            {
                hash = hash * 59 + MaxAttemptsPerNumber.GetHashCode();
            }

            if (TimeZoneId != null)
            {
                hash = hash * 59 + TimeZoneId.GetHashCode();
            }

            if (ResetPeriod != null)
            {
                hash = hash * 59 + ResetPeriod.GetHashCode();
            }

            if (RecallEntries != null)
            {
                hash = hash * 59 + RecallEntries.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

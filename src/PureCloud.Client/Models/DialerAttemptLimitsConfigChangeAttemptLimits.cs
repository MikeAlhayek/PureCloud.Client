using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerAttemptLimitsConfigChangeAttemptLimits
/// </summary>

public partial class DialerAttemptLimitsConfigChangeAttemptLimits : IEquatable<DialerAttemptLimitsConfigChangeAttemptLimits>
{
    /// <summary>
    /// After how long the number of attempts will be set back to 0
    /// </summary>
    /// <value>After how long the number of attempts will be set back to 0</value>
    
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
    /// After how long the number of attempts will be set back to 0
    /// </summary>
    /// <value>After how long the number of attempts will be set back to 0</value>
    [JsonPropertyName("resetPeriod")]
    public ResetPeriodEnum? ResetPeriod { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerAttemptLimitsConfigChangeAttemptLimits" /> class.
    /// </summary>
    /// <param name="MaxAttemptsPerContact">MaxAttemptsPerContact.</param>
    /// <param name="MaxAttemptsPerNumber">MaxAttemptsPerNumber.</param>
    /// <param name="TimeZoneId">The timezone is necessary to define when \&quot;today\&quot; starts and ends.</param>
    /// <param name="ResetPeriod">After how long the number of attempts will be set back to 0.</param>
    /// <param name="RecallEntries">Configuration for recall attempts.</param>
    /// <param name="BreadthFirstRecalls">Whether recalls are performed before considering other numbers (true) or after (false).</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    public DialerAttemptLimitsConfigChangeAttemptLimits(long? MaxAttemptsPerContact = null, long? MaxAttemptsPerNumber = null, string TimeZoneId = null, ResetPeriodEnum? ResetPeriod = null, Dictionary<string, DialerAttemptLimitsConfigChangeRecallEntry> RecallEntries = null, bool? BreadthFirstRecalls = null, Dictionary<string, object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
    {
        this.MaxAttemptsPerContact = MaxAttemptsPerContact;
        this.MaxAttemptsPerNumber = MaxAttemptsPerNumber;
        this.TimeZoneId = TimeZoneId;
        this.ResetPeriod = ResetPeriod;
        this.RecallEntries = RecallEntries;
        this.BreadthFirstRecalls = BreadthFirstRecalls;
        this.AdditionalProperties = AdditionalProperties;
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Version = Version;

    }



    /// <summary>
    /// Gets or Sets MaxAttemptsPerContact
    /// </summary>
    [JsonPropertyName("maxAttemptsPerContact")]
    public long? MaxAttemptsPerContact { get; set; }



    /// <summary>
    /// Gets or Sets MaxAttemptsPerNumber
    /// </summary>
    [JsonPropertyName("maxAttemptsPerNumber")]
    public long? MaxAttemptsPerNumber { get; set; }



    /// <summary>
    /// The timezone is necessary to define when \&quot;today\&quot; starts and ends
    /// </summary>
    /// <value>The timezone is necessary to define when \&quot;today\&quot; starts and ends</value>
    [JsonPropertyName("timeZoneId")]
    public string TimeZoneId { get; set; }





    /// <summary>
    /// Configuration for recall attempts
    /// </summary>
    /// <value>Configuration for recall attempts</value>
    [JsonPropertyName("recallEntries")]
    public Dictionary<string, DialerAttemptLimitsConfigChangeRecallEntry> RecallEntries { get; set; }



    /// <summary>
    /// Whether recalls are performed before considering other numbers (true) or after (false)
    /// </summary>
    /// <value>Whether recalls are performed before considering other numbers (true) or after (false)</value>
    [JsonPropertyName("breadthFirstRecalls")]
    public bool? BreadthFirstRecalls { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerAttemptLimitsConfigChangeAttemptLimits {\n");

        sb.Append("  MaxAttemptsPerContact: ").Append(MaxAttemptsPerContact).Append("\n");
        sb.Append("  MaxAttemptsPerNumber: ").Append(MaxAttemptsPerNumber).Append("\n");
        sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
        sb.Append("  ResetPeriod: ").Append(ResetPeriod).Append("\n");
        sb.Append("  RecallEntries: ").Append(RecallEntries).Append("\n");
        sb.Append("  BreadthFirstRecalls: ").Append(BreadthFirstRecalls).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as DialerAttemptLimitsConfigChangeAttemptLimits);
    }

    /// <summary>
    /// Returns true if DialerAttemptLimitsConfigChangeAttemptLimits instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerAttemptLimitsConfigChangeAttemptLimits to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerAttemptLimitsConfigChangeAttemptLimits other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                BreadthFirstRecalls == other.BreadthFirstRecalls ||
                BreadthFirstRecalls != null &&
                BreadthFirstRecalls.Equals(other.BreadthFirstRecalls)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
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

            if (BreadthFirstRecalls != null)
            {
                hash = hash * 59 + BreadthFirstRecalls.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

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

            return hash;
        }
    }
}

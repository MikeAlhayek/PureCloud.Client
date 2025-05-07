using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundSettings
/// </summary>

public partial class OutboundSettings : IEquatable<OutboundSettings>
{
    /// <summary>
    /// The denominator to be used in determining the compliance abandon rate
    /// </summary>
    /// <value>The denominator to be used in determining the compliance abandon rate</value>
    
    public enum ComplianceAbandonRateDenominatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum AllCalls for "ALL_CALLS"
        /// </summary>
        [EnumMember(Value = "ALL_CALLS")]
        AllCalls,

        /// <summary>
        /// Enum CallsThatReachedQueue for "CALLS_THAT_REACHED_QUEUE"
        /// </summary>
        [EnumMember(Value = "CALLS_THAT_REACHED_QUEUE")]
        CallsThatReachedQueue
    }
    /// <summary>
    /// The denominator to be used in determining the compliance abandon rate
    /// </summary>
    /// <value>The denominator to be used in determining the compliance abandon rate</value>
    [JsonPropertyName("complianceAbandonRateDenominator")]
    public ComplianceAbandonRateDenominatorEnum? ComplianceAbandonRateDenominator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundSettings" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="MaxCallsPerAgent">The maximum number of calls that can be placed per agent on any campaign.</param>
    /// <param name="MaxCallsPerAgentDecimal">The maximum number of calls that can be placed per agent on any campaign with decimal precision.</param>
    /// <param name="MaxLineUtilization">The maximum percentage of lines that should be used for Outbound, expressed as a decimal in the range [0.0, 1.0].</param>
    /// <param name="AbandonSeconds">The number of seconds used to determine if a call is abandoned.</param>
    /// <param name="ComplianceAbandonRateDenominator">The denominator to be used in determining the compliance abandon rate.</param>
    /// <param name="AutomaticTimeZoneMapping">The settings for automatic time zone mapping. Note that changing these settings will change them for both voice and messaging campaigns..</param>
    /// <param name="RescheduleTimeZoneSkippedContacts">Whether or not to reschedule time-zone blocked contacts.</param>
    public OutboundSettings(string Name = null, int? Version = null, int? MaxCallsPerAgent = null, double? MaxCallsPerAgentDecimal = null, double? MaxLineUtilization = null, double? AbandonSeconds = null, ComplianceAbandonRateDenominatorEnum? ComplianceAbandonRateDenominator = null, AutomaticTimeZoneMappingSettings AutomaticTimeZoneMapping = null, bool? RescheduleTimeZoneSkippedContacts = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.MaxCallsPerAgent = MaxCallsPerAgent;
        this.MaxCallsPerAgentDecimal = MaxCallsPerAgentDecimal;
        this.MaxLineUtilization = MaxLineUtilization;
        this.AbandonSeconds = AbandonSeconds;
        this.ComplianceAbandonRateDenominator = ComplianceAbandonRateDenominator;
        this.AutomaticTimeZoneMapping = AutomaticTimeZoneMapping;
        this.RescheduleTimeZoneSkippedContacts = RescheduleTimeZoneSkippedContacts;

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
    /// The maximum number of calls that can be placed per agent on any campaign
    /// </summary>
    /// <value>The maximum number of calls that can be placed per agent on any campaign</value>
    [JsonPropertyName("maxCallsPerAgent")]
    public int? MaxCallsPerAgent { get; set; }



    /// <summary>
    /// The maximum number of calls that can be placed per agent on any campaign with decimal precision
    /// </summary>
    /// <value>The maximum number of calls that can be placed per agent on any campaign with decimal precision</value>
    [JsonPropertyName("maxCallsPerAgentDecimal")]
    public double? MaxCallsPerAgentDecimal { get; set; }



    /// <summary>
    /// The maximum number of calls that can be configured to be placed per agent on any campaign
    /// </summary>
    /// <value>The maximum number of calls that can be configured to be placed per agent on any campaign</value>
    [JsonPropertyName("maxConfigurableCallsPerAgent")]
    public int? MaxConfigurableCallsPerAgent { get; set; }



    /// <summary>
    /// The maximum percentage of lines that should be used for Outbound, expressed as a decimal in the range [0.0, 1.0]
    /// </summary>
    /// <value>The maximum percentage of lines that should be used for Outbound, expressed as a decimal in the range [0.0, 1.0]</value>
    [JsonPropertyName("maxLineUtilization")]
    public double? MaxLineUtilization { get; set; }



    /// <summary>
    /// The number of seconds used to determine if a call is abandoned
    /// </summary>
    /// <value>The number of seconds used to determine if a call is abandoned</value>
    [JsonPropertyName("abandonSeconds")]
    public double? AbandonSeconds { get; set; }





    /// <summary>
    /// The settings for automatic time zone mapping. Note that changing these settings will change them for both voice and messaging campaigns.
    /// </summary>
    /// <value>The settings for automatic time zone mapping. Note that changing these settings will change them for both voice and messaging campaigns.</value>
    [JsonPropertyName("automaticTimeZoneMapping")]
    public AutomaticTimeZoneMappingSettings AutomaticTimeZoneMapping { get; set; }



    /// <summary>
    /// Whether or not to reschedule time-zone blocked contacts
    /// </summary>
    /// <value>Whether or not to reschedule time-zone blocked contacts</value>
    [JsonPropertyName("rescheduleTimeZoneSkippedContacts")]
    public bool? RescheduleTimeZoneSkippedContacts { get; set; }



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
        sb.Append("class OutboundSettings {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  MaxCallsPerAgent: ").Append(MaxCallsPerAgent).Append("\n");
        sb.Append("  MaxCallsPerAgentDecimal: ").Append(MaxCallsPerAgentDecimal).Append("\n");
        sb.Append("  MaxConfigurableCallsPerAgent: ").Append(MaxConfigurableCallsPerAgent).Append("\n");
        sb.Append("  MaxLineUtilization: ").Append(MaxLineUtilization).Append("\n");
        sb.Append("  AbandonSeconds: ").Append(AbandonSeconds).Append("\n");
        sb.Append("  ComplianceAbandonRateDenominator: ").Append(ComplianceAbandonRateDenominator).Append("\n");
        sb.Append("  AutomaticTimeZoneMapping: ").Append(AutomaticTimeZoneMapping).Append("\n");
        sb.Append("  RescheduleTimeZoneSkippedContacts: ").Append(RescheduleTimeZoneSkippedContacts).Append("\n");
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
        return Equals(obj as OutboundSettings);
    }

    /// <summary>
    /// Returns true if OutboundSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundSettings other)
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
                MaxCallsPerAgent == other.MaxCallsPerAgent ||
                MaxCallsPerAgent != null &&
                MaxCallsPerAgent.Equals(other.MaxCallsPerAgent)
            ) &&
            (
                MaxCallsPerAgentDecimal == other.MaxCallsPerAgentDecimal ||
                MaxCallsPerAgentDecimal != null &&
                MaxCallsPerAgentDecimal.Equals(other.MaxCallsPerAgentDecimal)
            ) &&
            (
                MaxConfigurableCallsPerAgent == other.MaxConfigurableCallsPerAgent ||
                MaxConfigurableCallsPerAgent != null &&
                MaxConfigurableCallsPerAgent.Equals(other.MaxConfigurableCallsPerAgent)
            ) &&
            (
                MaxLineUtilization == other.MaxLineUtilization ||
                MaxLineUtilization != null &&
                MaxLineUtilization.Equals(other.MaxLineUtilization)
            ) &&
            (
                AbandonSeconds == other.AbandonSeconds ||
                AbandonSeconds != null &&
                AbandonSeconds.Equals(other.AbandonSeconds)
            ) &&
            (
                ComplianceAbandonRateDenominator == other.ComplianceAbandonRateDenominator ||
                ComplianceAbandonRateDenominator != null &&
                ComplianceAbandonRateDenominator.Equals(other.ComplianceAbandonRateDenominator)
            ) &&
            (
                AutomaticTimeZoneMapping == other.AutomaticTimeZoneMapping ||
                AutomaticTimeZoneMapping != null &&
                AutomaticTimeZoneMapping.Equals(other.AutomaticTimeZoneMapping)
            ) &&
            (
                RescheduleTimeZoneSkippedContacts == other.RescheduleTimeZoneSkippedContacts ||
                RescheduleTimeZoneSkippedContacts != null &&
                RescheduleTimeZoneSkippedContacts.Equals(other.RescheduleTimeZoneSkippedContacts)
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

            if (MaxCallsPerAgent != null)
            {
                hash = hash * 59 + MaxCallsPerAgent.GetHashCode();
            }

            if (MaxCallsPerAgentDecimal != null)
            {
                hash = hash * 59 + MaxCallsPerAgentDecimal.GetHashCode();
            }

            if (MaxConfigurableCallsPerAgent != null)
            {
                hash = hash * 59 + MaxConfigurableCallsPerAgent.GetHashCode();
            }

            if (MaxLineUtilization != null)
            {
                hash = hash * 59 + MaxLineUtilization.GetHashCode();
            }

            if (AbandonSeconds != null)
            {
                hash = hash * 59 + AbandonSeconds.GetHashCode();
            }

            if (ComplianceAbandonRateDenominator != null)
            {
                hash = hash * 59 + ComplianceAbandonRateDenominator.GetHashCode();
            }

            if (AutomaticTimeZoneMapping != null)
            {
                hash = hash * 59 + AutomaticTimeZoneMapping.GetHashCode();
            }

            if (RescheduleTimeZoneSkippedContacts != null)
            {
                hash = hash * 59 + RescheduleTimeZoneSkippedContacts.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

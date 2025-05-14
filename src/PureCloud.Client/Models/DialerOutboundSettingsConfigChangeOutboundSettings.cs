using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerOutboundSettingsConfigChangeOutboundSettings
{
    /// <summary>
    /// The denominator to be used in determining the compliance abandon rate
    /// </summary>
    /// <value>The denominator to be used in determining the compliance abandon rate</value>
    public DialerOutboundSettingsConfigChangeOutboundSettingsComplianceAbandonRateDenominatorEnum? ComplianceAbandonRateDenominator { get; set; }

    /// <summary>
    /// The maximum number of calls that can be placed per agent on any campaign
    /// </summary>
    /// <value>The maximum number of calls that can be placed per agent on any campaign</value>
    public long? MaxCallsPerAgent { get; set; }

    /// <summary>
    /// The maximum percentage of lines that should be used for Outbound, expressed as a decimal in the range [0.0, 1.0]
    /// </summary>
    /// <value>The maximum percentage of lines that should be used for Outbound, expressed as a decimal in the range [0.0, 1.0]</value>
    public double? MaxLineUtilization { get; set; }

    /// <summary>
    /// The number of seconds used to determine if a call is abandoned
    /// </summary>
    /// <value>The number of seconds used to determine if a call is abandoned</value>
    public double? AbandonSeconds { get; set; }

    /// <summary>
    /// Gets or Sets AutomaticTimeZoneMapping
    /// </summary>
    public DialerOutboundSettingsConfigChangeAutomaticTimeZoneMappingSettings AutomaticTimeZoneMapping { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    public string Name { get; set; }

    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    public long? Version { get; set; }
}

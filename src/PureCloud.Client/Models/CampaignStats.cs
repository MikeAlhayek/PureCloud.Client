using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignStats
/// </summary>

public partial class CampaignStats : IEquatable<CampaignStats>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignStats" /> class.
    /// </summary>
    public CampaignStats()
    {

    }



    /// <summary>
    /// Information regarding the campaign&#39;s connect rate
    /// </summary>
    /// <value>Information regarding the campaign&#39;s connect rate</value>
    [JsonPropertyName("contactRate")]
    public ConnectRate ContactRate { get; private set; }



    /// <summary>
    /// Number of available agents not currently being utilized
    /// </summary>
    /// <value>Number of available agents not currently being utilized</value>
    [JsonPropertyName("idleAgents")]
    public int? IdleAgents { get; private set; }



    /// <summary>
    /// Number of effective available agents not currently being utilized
    /// </summary>
    /// <value>Number of effective available agents not currently being utilized</value>
    [JsonPropertyName("effectiveIdleAgents")]
    public double? EffectiveIdleAgents { get; private set; }



    /// <summary>
    /// Calls per agent adjusted by pace
    /// </summary>
    /// <value>Calls per agent adjusted by pace</value>
    [JsonPropertyName("adjustedCallsPerAgent")]
    public double? AdjustedCallsPerAgent { get; private set; }



    /// <summary>
    /// Number of campaign calls currently ongoing
    /// </summary>
    /// <value>Number of campaign calls currently ongoing</value>
    [JsonPropertyName("outstandingCalls")]
    public int? OutstandingCalls { get; private set; }



    /// <summary>
    /// Number of campaign calls currently scheduled
    /// </summary>
    /// <value>Number of campaign calls currently scheduled</value>
    [JsonPropertyName("scheduledCalls")]
    public int? ScheduledCalls { get; private set; }



    /// <summary>
    /// Number of campaign calls currently timezone rescheduled
    /// </summary>
    /// <value>Number of campaign calls currently timezone rescheduled</value>
    [JsonPropertyName("timeZoneRescheduledCalls")]
    public int? TimeZoneRescheduledCalls { get; private set; }



    /// <summary>
    /// Number of contacts that don&#39;t match filter. This is currently supported only for Campaigns with dynamic filter on.
    /// </summary>
    /// <value>Number of contacts that don&#39;t match filter. This is currently supported only for Campaigns with dynamic filter on.</value>
    [JsonPropertyName("filteredOutContactsCount")]
    public int? FilteredOutContactsCount { get; private set; }



    /// <summary>
    /// Information on the campaign&#39;s number of Right Party Contacts
    /// </summary>
    /// <value>Information on the campaign&#39;s number of Right Party Contacts</value>
    [JsonPropertyName("rightPartyContactsCount")]
    public int? RightPartyContactsCount { get; private set; }



    /// <summary>
    /// Information on the campaign&#39;s valid attempts
    /// </summary>
    /// <value>Information on the campaign&#39;s valid attempts</value>
    [JsonPropertyName("validAttempts")]
    public int? ValidAttempts { get; private set; }



    /// <summary>
    /// Information on the campaign&#39;s lines utilization
    /// </summary>
    /// <value>Information on the campaign&#39;s lines utilization</value>
    [JsonPropertyName("linesUtilization")]
    public CampaignLinesUtilization LinesUtilization { get; private set; }



    /// <summary>
    /// Information on the campaign&#39;s business category metrics
    /// </summary>
    /// <value>Information on the campaign&#39;s business category metrics</value>
    [JsonPropertyName("businessCategoryMetrics")]
    public CampaignBusinessCategoryMetrics BusinessCategoryMetrics { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignStats {\n");

        sb.Append("  ContactRate: ").Append(ContactRate).Append("\n");
        sb.Append("  IdleAgents: ").Append(IdleAgents).Append("\n");
        sb.Append("  EffectiveIdleAgents: ").Append(EffectiveIdleAgents).Append("\n");
        sb.Append("  AdjustedCallsPerAgent: ").Append(AdjustedCallsPerAgent).Append("\n");
        sb.Append("  OutstandingCalls: ").Append(OutstandingCalls).Append("\n");
        sb.Append("  ScheduledCalls: ").Append(ScheduledCalls).Append("\n");
        sb.Append("  TimeZoneRescheduledCalls: ").Append(TimeZoneRescheduledCalls).Append("\n");
        sb.Append("  FilteredOutContactsCount: ").Append(FilteredOutContactsCount).Append("\n");
        sb.Append("  RightPartyContactsCount: ").Append(RightPartyContactsCount).Append("\n");
        sb.Append("  ValidAttempts: ").Append(ValidAttempts).Append("\n");
        sb.Append("  LinesUtilization: ").Append(LinesUtilization).Append("\n");
        sb.Append("  BusinessCategoryMetrics: ").Append(BusinessCategoryMetrics).Append("\n");
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
        return Equals(obj as CampaignStats);
    }

    /// <summary>
    /// Returns true if CampaignStats instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignStats to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignStats other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ContactRate == other.ContactRate ||
                ContactRate != null &&
                ContactRate.Equals(other.ContactRate)
            ) &&
            (
                IdleAgents == other.IdleAgents ||
                IdleAgents != null &&
                IdleAgents.Equals(other.IdleAgents)
            ) &&
            (
                EffectiveIdleAgents == other.EffectiveIdleAgents ||
                EffectiveIdleAgents != null &&
                EffectiveIdleAgents.Equals(other.EffectiveIdleAgents)
            ) &&
            (
                AdjustedCallsPerAgent == other.AdjustedCallsPerAgent ||
                AdjustedCallsPerAgent != null &&
                AdjustedCallsPerAgent.Equals(other.AdjustedCallsPerAgent)
            ) &&
            (
                OutstandingCalls == other.OutstandingCalls ||
                OutstandingCalls != null &&
                OutstandingCalls.Equals(other.OutstandingCalls)
            ) &&
            (
                ScheduledCalls == other.ScheduledCalls ||
                ScheduledCalls != null &&
                ScheduledCalls.Equals(other.ScheduledCalls)
            ) &&
            (
                TimeZoneRescheduledCalls == other.TimeZoneRescheduledCalls ||
                TimeZoneRescheduledCalls != null &&
                TimeZoneRescheduledCalls.Equals(other.TimeZoneRescheduledCalls)
            ) &&
            (
                FilteredOutContactsCount == other.FilteredOutContactsCount ||
                FilteredOutContactsCount != null &&
                FilteredOutContactsCount.Equals(other.FilteredOutContactsCount)
            ) &&
            (
                RightPartyContactsCount == other.RightPartyContactsCount ||
                RightPartyContactsCount != null &&
                RightPartyContactsCount.Equals(other.RightPartyContactsCount)
            ) &&
            (
                ValidAttempts == other.ValidAttempts ||
                ValidAttempts != null &&
                ValidAttempts.Equals(other.ValidAttempts)
            ) &&
            (
                LinesUtilization == other.LinesUtilization ||
                LinesUtilization != null &&
                LinesUtilization.Equals(other.LinesUtilization)
            ) &&
            (
                BusinessCategoryMetrics == other.BusinessCategoryMetrics ||
                BusinessCategoryMetrics != null &&
                BusinessCategoryMetrics.Equals(other.BusinessCategoryMetrics)
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
            if (ContactRate != null)
            {
                hash = hash * 59 + ContactRate.GetHashCode();
            }

            if (IdleAgents != null)
            {
                hash = hash * 59 + IdleAgents.GetHashCode();
            }

            if (EffectiveIdleAgents != null)
            {
                hash = hash * 59 + EffectiveIdleAgents.GetHashCode();
            }

            if (AdjustedCallsPerAgent != null)
            {
                hash = hash * 59 + AdjustedCallsPerAgent.GetHashCode();
            }

            if (OutstandingCalls != null)
            {
                hash = hash * 59 + OutstandingCalls.GetHashCode();
            }

            if (ScheduledCalls != null)
            {
                hash = hash * 59 + ScheduledCalls.GetHashCode();
            }

            if (TimeZoneRescheduledCalls != null)
            {
                hash = hash * 59 + TimeZoneRescheduledCalls.GetHashCode();
            }

            if (FilteredOutContactsCount != null)
            {
                hash = hash * 59 + FilteredOutContactsCount.GetHashCode();
            }

            if (RightPartyContactsCount != null)
            {
                hash = hash * 59 + RightPartyContactsCount.GetHashCode();
            }

            if (ValidAttempts != null)
            {
                hash = hash * 59 + ValidAttempts.GetHashCode();
            }

            if (LinesUtilization != null)
            {
                hash = hash * 59 + LinesUtilization.GetHashCode();
            }

            if (BusinessCategoryMetrics != null)
            {
                hash = hash * 59 + BusinessCategoryMetrics.GetHashCode();
            }

            return hash;
        }
    }
}

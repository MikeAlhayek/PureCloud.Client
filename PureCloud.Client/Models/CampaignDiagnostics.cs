using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignDiagnostics
/// </summary>
[DataContract]
public partial class CampaignDiagnostics : IEquatable<CampaignDiagnostics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignDiagnostics" /> class.
    /// </summary>
    public CampaignDiagnostics()
    {

    }



    /// <summary>
    /// Campaign properties that can impact which contacts are callable
    /// </summary>
    /// <value>Campaign properties that can impact which contacts are callable</value>
    [DataMember(Name = "callableContacts", EmitDefaultValue = false)]
    public CallableContactsDiagnostic CallableContacts { get; private set; }



    /// <summary>
    /// Information regarding the campaign&#39;s queue
    /// </summary>
    /// <value>Information regarding the campaign&#39;s queue</value>
    [DataMember(Name = "queueUtilizationDiagnostic", EmitDefaultValue = false)]
    public QueueUtilizationDiagnostic QueueUtilizationDiagnostic { get; private set; }



    /// <summary>
    /// Information regarding the campaign&#39;s rule sets
    /// </summary>
    /// <value>Information regarding the campaign&#39;s rule sets</value>
    [DataMember(Name = "ruleSetDiagnostics", EmitDefaultValue = false)]
    public List<RuleSetDiagnostic> RuleSetDiagnostics { get; private set; }



    /// <summary>
    /// Current number of outstanding interactions on the campaign
    /// </summary>
    /// <value>Current number of outstanding interactions on the campaign</value>
    [DataMember(Name = "outstandingInteractionsCount", EmitDefaultValue = false)]
    public int? OutstandingInteractionsCount { get; private set; }



    /// <summary>
    /// Current number of scheduled interactions on the campaign
    /// </summary>
    /// <value>Current number of scheduled interactions on the campaign</value>
    [DataMember(Name = "scheduledInteractionsCount", EmitDefaultValue = false)]
    public int? ScheduledInteractionsCount { get; private set; }



    /// <summary>
    /// Current number of time zone rescheduled calls on the campaign
    /// </summary>
    /// <value>Current number of time zone rescheduled calls on the campaign</value>
    [DataMember(Name = "timeZoneRescheduledCallsCount", EmitDefaultValue = false)]
    public int? TimeZoneRescheduledCallsCount { get; private set; }



    /// <summary>
    /// Number of contacts that don&#39;t match filter. This is currently supported only for Campaigns with dynamic filter on.
    /// </summary>
    /// <value>Number of contacts that don&#39;t match filter. This is currently supported only for Campaigns with dynamic filter on.</value>
    [DataMember(Name = "filteredOutContactsCount", EmitDefaultValue = false)]
    public int? FilteredOutContactsCount { get; private set; }



    /// <summary>
    /// Information regarding the campaign&#39;s skills
    /// </summary>
    /// <value>Information regarding the campaign&#39;s skills</value>
    [DataMember(Name = "campaignSkillStatistics", EmitDefaultValue = false)]
    public CampaignSkillStatistics CampaignSkillStatistics { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignDiagnostics {\n");

        sb.Append("  CallableContacts: ").Append(CallableContacts).Append("\n");
        sb.Append("  QueueUtilizationDiagnostic: ").Append(QueueUtilizationDiagnostic).Append("\n");
        sb.Append("  RuleSetDiagnostics: ").Append(RuleSetDiagnostics).Append("\n");
        sb.Append("  OutstandingInteractionsCount: ").Append(OutstandingInteractionsCount).Append("\n");
        sb.Append("  ScheduledInteractionsCount: ").Append(ScheduledInteractionsCount).Append("\n");
        sb.Append("  TimeZoneRescheduledCallsCount: ").Append(TimeZoneRescheduledCallsCount).Append("\n");
        sb.Append("  FilteredOutContactsCount: ").Append(FilteredOutContactsCount).Append("\n");
        sb.Append("  CampaignSkillStatistics: ").Append(CampaignSkillStatistics).Append("\n");
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
        return Equals(obj as CampaignDiagnostics);
    }

    /// <summary>
    /// Returns true if CampaignDiagnostics instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignDiagnostics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignDiagnostics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CallableContacts == other.CallableContacts ||
                CallableContacts != null &&
                CallableContacts.Equals(other.CallableContacts)
            ) &&
            (
                QueueUtilizationDiagnostic == other.QueueUtilizationDiagnostic ||
                QueueUtilizationDiagnostic != null &&
                QueueUtilizationDiagnostic.Equals(other.QueueUtilizationDiagnostic)
            ) &&
            (
                RuleSetDiagnostics == other.RuleSetDiagnostics ||
                RuleSetDiagnostics != null &&
                RuleSetDiagnostics.SequenceEqual(other.RuleSetDiagnostics)
            ) &&
            (
                OutstandingInteractionsCount == other.OutstandingInteractionsCount ||
                OutstandingInteractionsCount != null &&
                OutstandingInteractionsCount.Equals(other.OutstandingInteractionsCount)
            ) &&
            (
                ScheduledInteractionsCount == other.ScheduledInteractionsCount ||
                ScheduledInteractionsCount != null &&
                ScheduledInteractionsCount.Equals(other.ScheduledInteractionsCount)
            ) &&
            (
                TimeZoneRescheduledCallsCount == other.TimeZoneRescheduledCallsCount ||
                TimeZoneRescheduledCallsCount != null &&
                TimeZoneRescheduledCallsCount.Equals(other.TimeZoneRescheduledCallsCount)
            ) &&
            (
                FilteredOutContactsCount == other.FilteredOutContactsCount ||
                FilteredOutContactsCount != null &&
                FilteredOutContactsCount.Equals(other.FilteredOutContactsCount)
            ) &&
            (
                CampaignSkillStatistics == other.CampaignSkillStatistics ||
                CampaignSkillStatistics != null &&
                CampaignSkillStatistics.Equals(other.CampaignSkillStatistics)
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
            if (CallableContacts != null)
            {
                hash = hash * 59 + CallableContacts.GetHashCode();
            }

            if (QueueUtilizationDiagnostic != null)
            {
                hash = hash * 59 + QueueUtilizationDiagnostic.GetHashCode();
            }

            if (RuleSetDiagnostics != null)
            {
                hash = hash * 59 + RuleSetDiagnostics.GetHashCode();
            }

            if (OutstandingInteractionsCount != null)
            {
                hash = hash * 59 + OutstandingInteractionsCount.GetHashCode();
            }

            if (ScheduledInteractionsCount != null)
            {
                hash = hash * 59 + ScheduledInteractionsCount.GetHashCode();
            }

            if (TimeZoneRescheduledCallsCount != null)
            {
                hash = hash * 59 + TimeZoneRescheduledCallsCount.GetHashCode();
            }

            if (FilteredOutContactsCount != null)
            {
                hash = hash * 59 + FilteredOutContactsCount.GetHashCode();
            }

            if (CampaignSkillStatistics != null)
            {
                hash = hash * 59 + CampaignSkillStatistics.GetHashCode();
            }

            return hash;
        }
    }
}

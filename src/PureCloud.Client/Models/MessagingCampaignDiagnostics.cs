using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MessagingCampaignDiagnostics
/// </summary>

public partial class MessagingCampaignDiagnostics : IEquatable<MessagingCampaignDiagnostics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingCampaignDiagnostics" /> class.
    /// </summary>
    public MessagingCampaignDiagnostics()
    {

    }



    /// <summary>
    /// Current number of time zone rescheduled messages on the campaign
    /// </summary>
    /// <value>Current number of time zone rescheduled messages on the campaign</value>
    [JsonPropertyName("timeZoneRescheduledContactsCount")]
    public int? TimeZoneRescheduledContactsCount { get; set; }



    /// <summary>
    /// Number of contacts that don&#39;t match filter. This is currently supported only for Campaigns with dynamic filter on.
    /// </summary>
    /// <value>Number of contacts that don&#39;t match filter. This is currently supported only for Campaigns with dynamic filter on.</value>
    [JsonPropertyName("filteredOutContactsCount")]
    public int? FilteredOutContactsCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessagingCampaignDiagnostics {\n");

        sb.Append("  TimeZoneRescheduledContactsCount: ").Append(TimeZoneRescheduledContactsCount).Append("\n");
        sb.Append("  FilteredOutContactsCount: ").Append(FilteredOutContactsCount).Append("\n");
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
        return Equals(obj as MessagingCampaignDiagnostics);
    }

    /// <summary>
    /// Returns true if MessagingCampaignDiagnostics instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingCampaignDiagnostics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingCampaignDiagnostics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeZoneRescheduledContactsCount == other.TimeZoneRescheduledContactsCount ||
                TimeZoneRescheduledContactsCount != null &&
                TimeZoneRescheduledContactsCount.Equals(other.TimeZoneRescheduledContactsCount)
            ) &&
            (
                FilteredOutContactsCount == other.FilteredOutContactsCount ||
                FilteredOutContactsCount != null &&
                FilteredOutContactsCount.Equals(other.FilteredOutContactsCount)
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
            if (TimeZoneRescheduledContactsCount != null)
            {
                hash = hash * 59 + TimeZoneRescheduledContactsCount.GetHashCode();
            }

            if (FilteredOutContactsCount != null)
            {
                hash = hash * 59 + FilteredOutContactsCount.GetHashCode();
            }

            return hash;
        }
    }
}

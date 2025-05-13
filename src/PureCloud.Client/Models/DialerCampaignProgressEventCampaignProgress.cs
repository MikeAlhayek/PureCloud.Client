using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCampaignProgressEventCampaignProgress
{
    /// <summary>
    /// Gets or Sets Campaign
    /// </summary>
    public DialerCampaignProgressEventUriReference Campaign { get; set; }

    /// <summary>
    /// The number of contacts that have been called so far
    /// </summary>
    /// <value>The number of contacts that have been called so far</value>
    public double? NumberOfContactsCalled { get; set; }

    /// <summary>
    /// The number of contacts that have been messaged so far
    /// </summary>
    /// <value>The number of contacts that have been messaged so far</value>
    public double? NumberOfContactsMessaged { get; set; }

    /// <summary>
    /// The total number of contacts in the contact list
    /// </summary>
    /// <value>The total number of contacts in the contact list</value>
    public double? TotalNumberOfContacts { get; set; }

    /// <summary>
    /// numberOfContactsContacted/totalNumberOfContacts*100
    /// </summary>
    /// <value>numberOfContactsContacted/totalNumberOfContacts*100</value>
    public long? Percentage { get; set; }

    /// <summary>
    /// A map of skipped reasons and the number of contacts associated with each.
    /// </summary>
    /// <value>A map of skipped reasons and the number of contacts associated with each.</value>
    public Dictionary<string, long?> NumberOfContactsSkipped { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}

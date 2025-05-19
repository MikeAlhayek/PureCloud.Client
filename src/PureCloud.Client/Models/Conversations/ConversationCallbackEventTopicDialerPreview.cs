using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConversationCallbackEventTopicDialerPreview
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The contact associated with this preview data pop
    /// </summary>
    /// <value>The contact associated with this preview data pop</value>
    public string ContactId { get; set; }

    /// <summary>
    /// The contactList associated with this preview data pop.
    /// </summary>
    /// <value>The contactList associated with this preview data pop.</value>
    public string ContactListId { get; set; }

    /// <summary>
    /// The campaignId associated with this preview data pop.
    /// </summary>
    /// <value>The campaignId associated with this preview data pop.</value>
    public string CampaignId { get; set; }

    /// <summary>
    /// The phone number columns associated with this campaign
    /// </summary>
    /// <value>The phone number columns associated with this campaign</value>
    public IEnumerable<ConversationCallbackEventTopicPhoneNumberColumn> PhoneNumberColumns { get; set; }
}

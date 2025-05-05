using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingWhatsappCampaignProgressEventCampaignProgress
/// </summary>

public partial class OutboundMessagingWhatsappCampaignProgressEventCampaignProgress : IEquatable<OutboundMessagingWhatsappCampaignProgressEventCampaignProgress>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingWhatsappCampaignProgressEventCampaignProgress" /> class.
    /// </summary>
    /// <param name="Campaign">Campaign.</param>
    /// <param name="NumberOfContactsCalled">The number of contacts that have been called so far.</param>
    /// <param name="NumberOfContactsMessaged">The number of contacts that have been messaged so far.</param>
    /// <param name="TotalNumberOfContacts">The total number of contacts in the contact list.</param>
    /// <param name="Percentage">numberOfContactsContacted/totalNumberOfContacts*100.</param>
    /// <param name="NumberOfContactsSkipped">A map of skipped reasons and the number of contacts associated with each..</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public OutboundMessagingWhatsappCampaignProgressEventCampaignProgress(OutboundMessagingWhatsappCampaignProgressEventUriReference Campaign = null, double? NumberOfContactsCalled = null, double? NumberOfContactsMessaged = null, double? TotalNumberOfContacts = null, long? Percentage = null, Dictionary<string, long?> NumberOfContactsSkipped = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Campaign = Campaign;
        this.NumberOfContactsCalled = NumberOfContactsCalled;
        this.NumberOfContactsMessaged = NumberOfContactsMessaged;
        this.TotalNumberOfContacts = TotalNumberOfContacts;
        this.Percentage = Percentage;
        this.NumberOfContactsSkipped = NumberOfContactsSkipped;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// Gets or Sets Campaign
    /// </summary>
    [JsonPropertyName("campaign")]
    public OutboundMessagingWhatsappCampaignProgressEventUriReference Campaign { get; set; }



    /// <summary>
    /// The number of contacts that have been called so far
    /// </summary>
    /// <value>The number of contacts that have been called so far</value>
    [JsonPropertyName("numberOfContactsCalled")]
    public double? NumberOfContactsCalled { get; set; }



    /// <summary>
    /// The number of contacts that have been messaged so far
    /// </summary>
    /// <value>The number of contacts that have been messaged so far</value>
    [JsonPropertyName("numberOfContactsMessaged")]
    public double? NumberOfContactsMessaged { get; set; }



    /// <summary>
    /// The total number of contacts in the contact list
    /// </summary>
    /// <value>The total number of contacts in the contact list</value>
    [JsonPropertyName("totalNumberOfContacts")]
    public double? TotalNumberOfContacts { get; set; }



    /// <summary>
    /// numberOfContactsContacted/totalNumberOfContacts*100
    /// </summary>
    /// <value>numberOfContactsContacted/totalNumberOfContacts*100</value>
    [JsonPropertyName("percentage")]
    public long? Percentage { get; set; }



    /// <summary>
    /// A map of skipped reasons and the number of contacts associated with each.
    /// </summary>
    /// <value>A map of skipped reasons and the number of contacts associated with each.</value>
    [JsonPropertyName("numberOfContactsSkipped")]
    public Dictionary<string, long?> NumberOfContactsSkipped { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingWhatsappCampaignProgressEventCampaignProgress {\n");

        sb.Append("  Campaign: ").Append(Campaign).Append("\n");
        sb.Append("  NumberOfContactsCalled: ").Append(NumberOfContactsCalled).Append("\n");
        sb.Append("  NumberOfContactsMessaged: ").Append(NumberOfContactsMessaged).Append("\n");
        sb.Append("  TotalNumberOfContacts: ").Append(TotalNumberOfContacts).Append("\n");
        sb.Append("  Percentage: ").Append(Percentage).Append("\n");
        sb.Append("  NumberOfContactsSkipped: ").Append(NumberOfContactsSkipped).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return Equals(obj as OutboundMessagingWhatsappCampaignProgressEventCampaignProgress);
    }

    /// <summary>
    /// Returns true if OutboundMessagingWhatsappCampaignProgressEventCampaignProgress instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingWhatsappCampaignProgressEventCampaignProgress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingWhatsappCampaignProgressEventCampaignProgress other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Campaign == other.Campaign ||
                Campaign != null &&
                Campaign.Equals(other.Campaign)
            ) &&
            (
                NumberOfContactsCalled == other.NumberOfContactsCalled ||
                NumberOfContactsCalled != null &&
                NumberOfContactsCalled.Equals(other.NumberOfContactsCalled)
            ) &&
            (
                NumberOfContactsMessaged == other.NumberOfContactsMessaged ||
                NumberOfContactsMessaged != null &&
                NumberOfContactsMessaged.Equals(other.NumberOfContactsMessaged)
            ) &&
            (
                TotalNumberOfContacts == other.TotalNumberOfContacts ||
                TotalNumberOfContacts != null &&
                TotalNumberOfContacts.Equals(other.TotalNumberOfContacts)
            ) &&
            (
                Percentage == other.Percentage ||
                Percentage != null &&
                Percentage.Equals(other.Percentage)
            ) &&
            (
                NumberOfContactsSkipped == other.NumberOfContactsSkipped ||
                NumberOfContactsSkipped != null &&
                NumberOfContactsSkipped.SequenceEqual(other.NumberOfContactsSkipped)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (Campaign != null)
            {
                hash = hash * 59 + Campaign.GetHashCode();
            }

            if (NumberOfContactsCalled != null)
            {
                hash = hash * 59 + NumberOfContactsCalled.GetHashCode();
            }

            if (NumberOfContactsMessaged != null)
            {
                hash = hash * 59 + NumberOfContactsMessaged.GetHashCode();
            }

            if (TotalNumberOfContacts != null)
            {
                hash = hash * 59 + TotalNumberOfContacts.GetHashCode();
            }

            if (Percentage != null)
            {
                hash = hash * 59 + Percentage.GetHashCode();
            }

            if (NumberOfContactsSkipped != null)
            {
                hash = hash * 59 + NumberOfContactsSkipped.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}

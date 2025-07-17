using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GDPRSubject
{
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets ExternalContactId
    /// </summary>
    public string ExternalContactId { get; set; }

    /// <summary>
    /// Gets or Sets DialerContactId
    /// </summary>
    public DialerContactId DialerContactId { get; set; }

    /// <summary>
    /// Gets or Sets JourneyCustomer
    /// </summary>
    public GDPRJourneyCustomer JourneyCustomer { get; set; }

    /// <summary>
    /// Gets or Sets SocialHandle
    /// </summary>
    public SocialHandle SocialHandle { get; set; }

    /// <summary>
    /// Gets or Sets ExternalId
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or Sets Addresses
    /// </summary>
    public IEnumerable<string> Addresses { get; set; }

    /// <summary>
    /// Gets or Sets PhoneNumbers
    /// </summary>
    public IEnumerable<string> PhoneNumbers { get; set; }

    /// <summary>
    /// Gets or Sets EmailAddresses
    /// </summary>
    public IEnumerable<string> EmailAddresses { get; set; }
}

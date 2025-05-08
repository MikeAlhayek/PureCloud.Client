using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExternalContactsContactChangedTopicWhatsAppId
{
    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    public ExternalContactsContactChangedTopicPhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    public string DisplayName { get; set; }
}

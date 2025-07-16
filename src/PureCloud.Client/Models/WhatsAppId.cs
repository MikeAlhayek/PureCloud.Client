using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WhatsAppId
{
    /// <summary>
    /// The phone number associated with this WhatsApp account
    /// </summary>
    /// <value>The phone number associated with this WhatsApp account</value>
    public PhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// The displayName of this person&#39;s account in WhatsApp
    /// </summary>
    /// <value>The displayName of this person&#39;s account in WhatsApp</value>
    public string DisplayName { get; set; }
}

using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InboundDomainPatchRequest
/// </summary>

public partial class InboundDomainPatchRequest : IEquatable<InboundDomainPatchRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InboundDomainPatchRequest" /> class.
    /// </summary>
    /// <param name="MailFromSettings">The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false..</param>
    /// <param name="CustomSMTPServer">The custom SMTP server integration to use when sending outbound emails from this domain..</param>
    /// <param name="ImapSettings">The IMAP server integration and settings to use for processing inbound emails..</param>
    public InboundDomainPatchRequest(MailFromResult MailFromSettings = null, DomainEntityRef CustomSMTPServer = null, ImapSettings ImapSettings = null)
    {
        this.MailFromSettings = MailFromSettings;
        this.CustomSMTPServer = CustomSMTPServer;
        this.ImapSettings = ImapSettings;

    }



    /// <summary>
    /// The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false.
    /// </summary>
    /// <value>The DNS settings if the inbound domain is using a custom Mail From. These settings can only be used on InboundDomains where subDomain is false.</value>
    [JsonPropertyName("mailFromSettings")]
    public MailFromResult MailFromSettings { get; set; }



    /// <summary>
    /// The custom SMTP server integration to use when sending outbound emails from this domain.
    /// </summary>
    /// <value>The custom SMTP server integration to use when sending outbound emails from this domain.</value>
    [JsonPropertyName("customSMTPServer")]
    public DomainEntityRef CustomSMTPServer { get; set; }



    /// <summary>
    /// The IMAP server integration and settings to use for processing inbound emails.
    /// </summary>
    /// <value>The IMAP server integration and settings to use for processing inbound emails.</value>
    [JsonPropertyName("imapSettings")]
    public ImapSettings ImapSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InboundDomainPatchRequest {\n");

        sb.Append("  MailFromSettings: ").Append(MailFromSettings).Append("\n");
        sb.Append("  CustomSMTPServer: ").Append(CustomSMTPServer).Append("\n");
        sb.Append("  ImapSettings: ").Append(ImapSettings).Append("\n");
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
        return Equals(obj as InboundDomainPatchRequest);
    }

    /// <summary>
    /// Returns true if InboundDomainPatchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of InboundDomainPatchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InboundDomainPatchRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MailFromSettings == other.MailFromSettings ||
                MailFromSettings != null &&
                MailFromSettings.Equals(other.MailFromSettings)
            ) &&
            (
                CustomSMTPServer == other.CustomSMTPServer ||
                CustomSMTPServer != null &&
                CustomSMTPServer.Equals(other.CustomSMTPServer)
            ) &&
            (
                ImapSettings == other.ImapSettings ||
                ImapSettings != null &&
                ImapSettings.Equals(other.ImapSettings)
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
            if (MailFromSettings != null)
            {
                hash = hash * 59 + MailFromSettings.GetHashCode();
            }

            if (CustomSMTPServer != null)
            {
                hash = hash * 59 + CustomSMTPServer.GetHashCode();
            }

            if (ImapSettings != null)
            {
                hash = hash * 59 + ImapSettings.GetHashCode();
            }

            return hash;
        }
    }
}

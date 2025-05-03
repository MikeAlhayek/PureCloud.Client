using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OrganizationFeatures
/// </summary>

public partial class OrganizationFeatures : IEquatable<OrganizationFeatures>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OrganizationFeatures" /> class.
    /// </summary>
    /// <param name="RealtimeCIC">RealtimeCIC.</param>
    /// <param name="Purecloud">Purecloud.</param>
    /// <param name="Hipaa">Hipaa.</param>
    /// <param name="UcEnabled">UcEnabled.</param>
    /// <param name="Pci">Pci.</param>
    /// <param name="PurecloudVoice">PurecloudVoice.</param>
    /// <param name="XmppFederation">XmppFederation.</param>
    /// <param name="Chat">Chat.</param>
    /// <param name="InformalPhotos">InformalPhotos.</param>
    /// <param name="Directory">Directory.</param>
    /// <param name="ContactCenter">ContactCenter.</param>
    /// <param name="UnifiedCommunications">UnifiedCommunications.</param>
    /// <param name="Custserv">Custserv.</param>
    public OrganizationFeatures(bool? RealtimeCIC = null, bool? PureCloudEnvironment = null, bool? Hipaa = null, bool? UcEnabled = null, bool? Pci = null, bool? PurecloudVoice = null, bool? XmppFederation = null, bool? Chat = null, bool? InformalPhotos = null, bool? Directory = null, bool? ContactCenter = null, bool? UnifiedCommunications = null, bool? Custserv = null)
    {
        this.RealtimeCIC = RealtimeCIC;
        this.PureCloudEnvironment = PureCloudEnvironment;
        this.Hipaa = Hipaa;
        this.UcEnabled = UcEnabled;
        this.Pci = Pci;
        this.PurecloudVoice = PurecloudVoice;
        this.XmppFederation = XmppFederation;
        this.Chat = Chat;
        this.InformalPhotos = InformalPhotos;
        this.Directory = Directory;
        this.ContactCenter = ContactCenter;
        this.UnifiedCommunications = UnifiedCommunications;
        this.Custserv = Custserv;

    }



    /// <summary>
    /// Gets or Sets RealtimeCIC
    /// </summary>
    [JsonPropertyName("realtimeCIC")]
    public bool? RealtimeCIC { get; set; }



    /// <summary>
    /// Gets or Sets Purecloud
    /// </summary>
    [JsonPropertyName("purecloud")]
    public bool? PureCloudEnvironment { get; set; }



    /// <summary>
    /// Gets or Sets Hipaa
    /// </summary>
    [JsonPropertyName("hipaa")]
    public bool? Hipaa { get; set; }



    /// <summary>
    /// Gets or Sets UcEnabled
    /// </summary>
    [JsonPropertyName("ucEnabled")]
    public bool? UcEnabled { get; set; }



    /// <summary>
    /// Gets or Sets Pci
    /// </summary>
    [JsonPropertyName("pci")]
    public bool? Pci { get; set; }



    /// <summary>
    /// Gets or Sets PurecloudVoice
    /// </summary>
    [JsonPropertyName("purecloudVoice")]
    public bool? PurecloudVoice { get; set; }



    /// <summary>
    /// Gets or Sets XmppFederation
    /// </summary>
    [JsonPropertyName("xmppFederation")]
    public bool? XmppFederation { get; set; }



    /// <summary>
    /// Gets or Sets Chat
    /// </summary>
    [JsonPropertyName("chat")]
    public bool? Chat { get; set; }



    /// <summary>
    /// Gets or Sets InformalPhotos
    /// </summary>
    [JsonPropertyName("informalPhotos")]
    public bool? InformalPhotos { get; set; }



    /// <summary>
    /// Gets or Sets Directory
    /// </summary>
    [JsonPropertyName("directory")]
    public bool? Directory { get; set; }



    /// <summary>
    /// Gets or Sets ContactCenter
    /// </summary>
    [JsonPropertyName("contactCenter")]
    public bool? ContactCenter { get; set; }



    /// <summary>
    /// Gets or Sets UnifiedCommunications
    /// </summary>
    [JsonPropertyName("unifiedCommunications")]
    public bool? UnifiedCommunications { get; set; }



    /// <summary>
    /// Gets or Sets Custserv
    /// </summary>
    [JsonPropertyName("custserv")]
    public bool? Custserv { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OrganizationFeatures {\n");

        sb.Append("  RealtimeCIC: ").Append(RealtimeCIC).Append("\n");
        sb.Append("  Purecloud: ").Append(PureCloudEnvironment).Append("\n");
        sb.Append("  Hipaa: ").Append(Hipaa).Append("\n");
        sb.Append("  UcEnabled: ").Append(UcEnabled).Append("\n");
        sb.Append("  Pci: ").Append(Pci).Append("\n");
        sb.Append("  PurecloudVoice: ").Append(PurecloudVoice).Append("\n");
        sb.Append("  XmppFederation: ").Append(XmppFederation).Append("\n");
        sb.Append("  Chat: ").Append(Chat).Append("\n");
        sb.Append("  InformalPhotos: ").Append(InformalPhotos).Append("\n");
        sb.Append("  Directory: ").Append(Directory).Append("\n");
        sb.Append("  ContactCenter: ").Append(ContactCenter).Append("\n");
        sb.Append("  UnifiedCommunications: ").Append(UnifiedCommunications).Append("\n");
        sb.Append("  Custserv: ").Append(Custserv).Append("\n");
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
        return Equals(obj as OrganizationFeatures);
    }

    /// <summary>
    /// Returns true if OrganizationFeatures instances are equal
    /// </summary>
    /// <param name="other">Instance of OrganizationFeatures to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OrganizationFeatures other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RealtimeCIC == other.RealtimeCIC ||
                RealtimeCIC != null &&
                RealtimeCIC.Equals(other.RealtimeCIC)
            ) &&
            (
                PureCloudEnvironment == other.PureCloudEnvironment ||
                PureCloudEnvironment != null &&
                PureCloudEnvironment.Equals(other.PureCloudEnvironment)
            ) &&
            (
                Hipaa == other.Hipaa ||
                Hipaa != null &&
                Hipaa.Equals(other.Hipaa)
            ) &&
            (
                UcEnabled == other.UcEnabled ||
                UcEnabled != null &&
                UcEnabled.Equals(other.UcEnabled)
            ) &&
            (
                Pci == other.Pci ||
                Pci != null &&
                Pci.Equals(other.Pci)
            ) &&
            (
                PurecloudVoice == other.PurecloudVoice ||
                PurecloudVoice != null &&
                PurecloudVoice.Equals(other.PurecloudVoice)
            ) &&
            (
                XmppFederation == other.XmppFederation ||
                XmppFederation != null &&
                XmppFederation.Equals(other.XmppFederation)
            ) &&
            (
                Chat == other.Chat ||
                Chat != null &&
                Chat.Equals(other.Chat)
            ) &&
            (
                InformalPhotos == other.InformalPhotos ||
                InformalPhotos != null &&
                InformalPhotos.Equals(other.InformalPhotos)
            ) &&
            (
                Directory == other.Directory ||
                Directory != null &&
                Directory.Equals(other.Directory)
            ) &&
            (
                ContactCenter == other.ContactCenter ||
                ContactCenter != null &&
                ContactCenter.Equals(other.ContactCenter)
            ) &&
            (
                UnifiedCommunications == other.UnifiedCommunications ||
                UnifiedCommunications != null &&
                UnifiedCommunications.Equals(other.UnifiedCommunications)
            ) &&
            (
                Custserv == other.Custserv ||
                Custserv != null &&
                Custserv.Equals(other.Custserv)
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
            if (RealtimeCIC != null)
            {
                hash = hash * 59 + RealtimeCIC.GetHashCode();
            }

            if (PureCloudEnvironment != null)
            {
                hash = hash * 59 + PureCloudEnvironment.GetHashCode();
            }

            if (Hipaa != null)
            {
                hash = hash * 59 + Hipaa.GetHashCode();
            }

            if (UcEnabled != null)
            {
                hash = hash * 59 + UcEnabled.GetHashCode();
            }

            if (Pci != null)
            {
                hash = hash * 59 + Pci.GetHashCode();
            }

            if (PurecloudVoice != null)
            {
                hash = hash * 59 + PurecloudVoice.GetHashCode();
            }

            if (XmppFederation != null)
            {
                hash = hash * 59 + XmppFederation.GetHashCode();
            }

            if (Chat != null)
            {
                hash = hash * 59 + Chat.GetHashCode();
            }

            if (InformalPhotos != null)
            {
                hash = hash * 59 + InformalPhotos.GetHashCode();
            }

            if (Directory != null)
            {
                hash = hash * 59 + Directory.GetHashCode();
            }

            if (ContactCenter != null)
            {
                hash = hash * 59 + ContactCenter.GetHashCode();
            }

            if (UnifiedCommunications != null)
            {
                hash = hash * 59 + UnifiedCommunications.GetHashCode();
            }

            if (Custserv != null)
            {
                hash = hash * 59 + Custserv.GetHashCode();
            }

            return hash;
        }
    }
}

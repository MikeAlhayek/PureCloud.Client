using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// IpAddressRange
/// </summary>

public partial class IpAddressRange : IEquatable<IpAddressRange>
{
    /// <summary>
    /// Gets or Sets Service
    /// </summary>
    
    public enum ServiceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Dataactions for "data-actions"
        /// </summary>
        [EnumMember(Value = "data-actions")]
        Dataactions,

        /// <summary>
        /// Enum Smtp for "smtp"
        /// </summary>
        [EnumMember(Value = "smtp")]
        Smtp,

        /// <summary>
        /// Enum Imap for "imap"
        /// </summary>
        [EnumMember(Value = "imap")]
        Imap,

        /// <summary>
        /// Enum Graphapi for "graphapi"
        /// </summary>
        [EnumMember(Value = "graphapi")]
        Graphapi,

        /// <summary>
        /// Enum Audiohook for "audiohook"
        /// </summary>
        [EnumMember(Value = "audiohook")]
        Audiohook,

        /// <summary>
        /// Enum Openmessaging for "open-messaging"
        /// </summary>
        [EnumMember(Value = "open-messaging")]
        Openmessaging,

        /// <summary>
        /// Enum Api for "api"
        /// </summary>
        [EnumMember(Value = "api")]
        Api,

        /// <summary>
        /// Enum Audioconnector for "audio-connector"
        /// </summary>
        [EnumMember(Value = "audio-connector")]
        Audioconnector,

        /// <summary>
        /// Enum Byotstt for "byot-stt"
        /// </summary>
        [EnumMember(Value = "byot-stt")]
        Byotstt,

        /// <summary>
        /// Enum Botconnector for "bot-connector"
        /// </summary>
        [EnumMember(Value = "bot-connector")]
        Botconnector,

        /// <summary>
        /// Enum Ttsconnector for "tts-connector"
        /// </summary>
        [EnumMember(Value = "tts-connector")]
        Ttsconnector
    }
    /// <summary>
    /// Gets or Sets Service
    /// </summary>
    [JsonPropertyName("service")]
    public ServiceEnum? Service { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="IpAddressRange" /> class.
    /// </summary>
    /// <param name="Cidr">Cidr.</param>
    /// <param name="Service">Service.</param>
    /// <param name="Region">Region.</param>
    public IpAddressRange(string Cidr = null, ServiceEnum? Service = null, string Region = null)
    {
        this.Cidr = Cidr;
        this.Service = Service;
        this.Region = Region;

    }



    /// <summary>
    /// Gets or Sets Cidr
    /// </summary>
    [JsonPropertyName("cidr")]
    public string Cidr { get; set; }





    /// <summary>
    /// Gets or Sets Region
    /// </summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IpAddressRange {\n");

        sb.Append("  Cidr: ").Append(Cidr).Append("\n");
        sb.Append("  Service: ").Append(Service).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
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
        return Equals(obj as IpAddressRange);
    }

    /// <summary>
    /// Returns true if IpAddressRange instances are equal
    /// </summary>
    /// <param name="other">Instance of IpAddressRange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IpAddressRange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Cidr == other.Cidr ||
                Cidr != null &&
                Cidr.Equals(other.Cidr)
            ) &&
            (
                Service == other.Service ||
                Service != null &&
                Service.Equals(other.Service)
            ) &&
            (
                Region == other.Region ||
                Region != null &&
                Region.Equals(other.Region)
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
            if (Cidr != null)
            {
                hash = hash * 59 + Cidr.GetHashCode();
            }

            if (Service != null)
            {
                hash = hash * 59 + Service.GetHashCode();
            }

            if (Region != null)
            {
                hash = hash * 59 + Region.GetHashCode();
            }

            return hash;
        }
    }
}

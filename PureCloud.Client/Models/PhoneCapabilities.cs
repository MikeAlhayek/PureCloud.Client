using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PhoneCapabilities
/// </summary>

public partial class PhoneCapabilities : IEquatable<PhoneCapabilities>
{
    /// <summary>
    /// Gets or Sets MediaCodecs
    /// </summary>
    
    public enum MediaCodecsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Opus for "audio/opus"
        /// </summary>
        [EnumMember(Value = "audio/opus")]
        Opus,

        /// <summary>
        /// Enum Pcmu for "audio/pcmu"
        /// </summary>
        [EnumMember(Value = "audio/pcmu")]
        Pcmu,

        /// <summary>
        /// Enum Pcma for "audio/pcma"
        /// </summary>
        [EnumMember(Value = "audio/pcma")]
        Pcma,

        /// <summary>
        /// Enum G729 for "audio/g729"
        /// </summary>
        [EnumMember(Value = "audio/g729")]
        G729,

        /// <summary>
        /// Enum G722 for "audio/g722"
        /// </summary>
        [EnumMember(Value = "audio/g722")]
        G722
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="PhoneCapabilities" /> class.
    /// </summary>
    /// <param name="Provisions">Provisions.</param>
    /// <param name="Registers">Registers.</param>
    /// <param name="DualRegisters">DualRegisters.</param>
    /// <param name="HardwareIdType">HardwareIdType.</param>
    /// <param name="AllowReboot">AllowReboot.</param>
    /// <param name="NoRebalance">NoRebalance.</param>
    /// <param name="NoCloudProvisioning">NoCloudProvisioning.</param>
    /// <param name="MediaCodecs">MediaCodecs.</param>
    /// <param name="Cdm">Cdm.</param>
    public PhoneCapabilities(bool? Provisions = null, bool? Registers = null, bool? DualRegisters = null, string HardwareIdType = null, bool? AllowReboot = null, bool? NoRebalance = null, bool? NoCloudProvisioning = null, List<MediaCodecsEnum> MediaCodecs = null, bool? Cdm = null)
    {
        this.Provisions = Provisions;
        this.Registers = Registers;
        this.DualRegisters = DualRegisters;
        this.HardwareIdType = HardwareIdType;
        this.AllowReboot = AllowReboot;
        this.NoRebalance = NoRebalance;
        this.NoCloudProvisioning = NoCloudProvisioning;
        this.MediaCodecs = MediaCodecs;
        this.Cdm = Cdm;

    }



    /// <summary>
    /// Gets or Sets Provisions
    /// </summary>
    [JsonPropertyName("provisions")]
    public bool? Provisions { get; set; }



    /// <summary>
    /// Gets or Sets Registers
    /// </summary>
    [JsonPropertyName("registers")]
    public bool? Registers { get; set; }



    /// <summary>
    /// Gets or Sets DualRegisters
    /// </summary>
    [JsonPropertyName("dualRegisters")]
    public bool? DualRegisters { get; set; }



    /// <summary>
    /// Gets or Sets HardwareIdType
    /// </summary>
    [JsonPropertyName("hardwareIdType")]
    public string HardwareIdType { get; set; }



    /// <summary>
    /// Gets or Sets AllowReboot
    /// </summary>
    [JsonPropertyName("allowReboot")]
    public bool? AllowReboot { get; set; }



    /// <summary>
    /// Gets or Sets NoRebalance
    /// </summary>
    [JsonPropertyName("noRebalance")]
    public bool? NoRebalance { get; set; }



    /// <summary>
    /// Gets or Sets NoCloudProvisioning
    /// </summary>
    [JsonPropertyName("noCloudProvisioning")]
    public bool? NoCloudProvisioning { get; set; }



    /// <summary>
    /// Gets or Sets MediaCodecs
    /// </summary>
    [JsonPropertyName("mediaCodecs")]
    public List<MediaCodecsEnum> MediaCodecs { get; set; }



    /// <summary>
    /// Gets or Sets Cdm
    /// </summary>
    [JsonPropertyName("cdm")]
    public bool? Cdm { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PhoneCapabilities {\n");

        sb.Append("  Provisions: ").Append(Provisions).Append("\n");
        sb.Append("  Registers: ").Append(Registers).Append("\n");
        sb.Append("  DualRegisters: ").Append(DualRegisters).Append("\n");
        sb.Append("  HardwareIdType: ").Append(HardwareIdType).Append("\n");
        sb.Append("  AllowReboot: ").Append(AllowReboot).Append("\n");
        sb.Append("  NoRebalance: ").Append(NoRebalance).Append("\n");
        sb.Append("  NoCloudProvisioning: ").Append(NoCloudProvisioning).Append("\n");
        sb.Append("  MediaCodecs: ").Append(MediaCodecs).Append("\n");
        sb.Append("  Cdm: ").Append(Cdm).Append("\n");
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
        return Equals(obj as PhoneCapabilities);
    }

    /// <summary>
    /// Returns true if PhoneCapabilities instances are equal
    /// </summary>
    /// <param name="other">Instance of PhoneCapabilities to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PhoneCapabilities other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Provisions == other.Provisions ||
                Provisions != null &&
                Provisions.Equals(other.Provisions)
            ) &&
            (
                Registers == other.Registers ||
                Registers != null &&
                Registers.Equals(other.Registers)
            ) &&
            (
                DualRegisters == other.DualRegisters ||
                DualRegisters != null &&
                DualRegisters.Equals(other.DualRegisters)
            ) &&
            (
                HardwareIdType == other.HardwareIdType ||
                HardwareIdType != null &&
                HardwareIdType.Equals(other.HardwareIdType)
            ) &&
            (
                AllowReboot == other.AllowReboot ||
                AllowReboot != null &&
                AllowReboot.Equals(other.AllowReboot)
            ) &&
            (
                NoRebalance == other.NoRebalance ||
                NoRebalance != null &&
                NoRebalance.Equals(other.NoRebalance)
            ) &&
            (
                NoCloudProvisioning == other.NoCloudProvisioning ||
                NoCloudProvisioning != null &&
                NoCloudProvisioning.Equals(other.NoCloudProvisioning)
            ) &&
            (
                MediaCodecs == other.MediaCodecs ||
                MediaCodecs != null &&
                MediaCodecs.SequenceEqual(other.MediaCodecs)
            ) &&
            (
                Cdm == other.Cdm ||
                Cdm != null &&
                Cdm.Equals(other.Cdm)
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
            if (Provisions != null)
            {
                hash = hash * 59 + Provisions.GetHashCode();
            }

            if (Registers != null)
            {
                hash = hash * 59 + Registers.GetHashCode();
            }

            if (DualRegisters != null)
            {
                hash = hash * 59 + DualRegisters.GetHashCode();
            }

            if (HardwareIdType != null)
            {
                hash = hash * 59 + HardwareIdType.GetHashCode();
            }

            if (AllowReboot != null)
            {
                hash = hash * 59 + AllowReboot.GetHashCode();
            }

            if (NoRebalance != null)
            {
                hash = hash * 59 + NoRebalance.GetHashCode();
            }

            if (NoCloudProvisioning != null)
            {
                hash = hash * 59 + NoCloudProvisioning.GetHashCode();
            }

            if (MediaCodecs != null)
            {
                hash = hash * 59 + MediaCodecs.GetHashCode();
            }

            if (Cdm != null)
            {
                hash = hash * 59 + Cdm.GetHashCode();
            }

            return hash;
        }
    }
}

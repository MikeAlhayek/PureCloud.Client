using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings concerning cobrowse
/// </summary>

public partial class CobrowseSettings : IEquatable<CobrowseSettings>
{
    /// <summary>
    /// Gets or Sets Channels
    /// </summary>
    
    public enum ChannelsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Webmessaging for "Webmessaging"
        /// </summary>
        [EnumMember(Value = "Webmessaging")]
        Webmessaging,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="CobrowseSettings" /> class.
    /// </summary>
    /// <param name="Enabled">Whether or not cobrowse is enabled.</param>
    /// <param name="AllowAgentControl">Whether the viewer should have option to request control.</param>
    /// <param name="AllowAgentNavigation">Whether the viewer should have option to request navigation.</param>
    /// <param name="AllowDraw">Should cobrowse draw be enabled.</param>
    /// <param name="MaskSelectors">Mask patterns that will apply to pages being shared.</param>
    /// <param name="Channels">Cobrowse channels for web messenger.</param>
    /// <param name="ReadonlySelectors">Readonly patterns that will apply to pages being shared.</param>
    /// <param name="PauseCriteria">Pause criteria that will pause cobrowse if some of them are met in the user&#39;s URL.</param>
    public CobrowseSettings(bool? Enabled = null, bool? AllowAgentControl = null, bool? AllowAgentNavigation = null, bool? AllowDraw = null, List<string> MaskSelectors = null, List<ChannelsEnum> Channels = null, List<string> ReadonlySelectors = null, List<PauseCriteria> PauseCriteria = null)
    {
        this.Enabled = Enabled;
        this.AllowAgentControl = AllowAgentControl;
        this.AllowAgentNavigation = AllowAgentNavigation;
        this.AllowDraw = AllowDraw;
        this.MaskSelectors = MaskSelectors;
        this.Channels = Channels;
        this.ReadonlySelectors = ReadonlySelectors;
        this.PauseCriteria = PauseCriteria;

    }



    /// <summary>
    /// Whether or not cobrowse is enabled
    /// </summary>
    /// <value>Whether or not cobrowse is enabled</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Whether the viewer should have option to request control
    /// </summary>
    /// <value>Whether the viewer should have option to request control</value>
    [JsonPropertyName("allowAgentControl")]
    public bool? AllowAgentControl { get; set; }



    /// <summary>
    /// Whether the viewer should have option to request navigation
    /// </summary>
    /// <value>Whether the viewer should have option to request navigation</value>
    [JsonPropertyName("allowAgentNavigation")]
    public bool? AllowAgentNavigation { get; set; }



    /// <summary>
    /// Should cobrowse draw be enabled
    /// </summary>
    /// <value>Should cobrowse draw be enabled</value>
    [JsonPropertyName("allowDraw")]
    public bool? AllowDraw { get; set; }



    /// <summary>
    /// Mask patterns that will apply to pages being shared
    /// </summary>
    /// <value>Mask patterns that will apply to pages being shared</value>
    [JsonPropertyName("maskSelectors")]
    public List<string> MaskSelectors { get; set; }



    /// <summary>
    /// Cobrowse channels for web messenger
    /// </summary>
    /// <value>Cobrowse channels for web messenger</value>
    [JsonPropertyName("channels")]
    public List<ChannelsEnum> Channels { get; set; }



    /// <summary>
    /// Readonly patterns that will apply to pages being shared
    /// </summary>
    /// <value>Readonly patterns that will apply to pages being shared</value>
    [JsonPropertyName("readonlySelectors")]
    public List<string> ReadonlySelectors { get; set; }



    /// <summary>
    /// Pause criteria that will pause cobrowse if some of them are met in the user&#39;s URL
    /// </summary>
    /// <value>Pause criteria that will pause cobrowse if some of them are met in the user&#39;s URL</value>
    [JsonPropertyName("pauseCriteria")]
    public List<PauseCriteria> PauseCriteria { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CobrowseSettings {\n");

        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  AllowAgentControl: ").Append(AllowAgentControl).Append("\n");
        sb.Append("  AllowAgentNavigation: ").Append(AllowAgentNavigation).Append("\n");
        sb.Append("  AllowDraw: ").Append(AllowDraw).Append("\n");
        sb.Append("  MaskSelectors: ").Append(MaskSelectors).Append("\n");
        sb.Append("  Channels: ").Append(Channels).Append("\n");
        sb.Append("  ReadonlySelectors: ").Append(ReadonlySelectors).Append("\n");
        sb.Append("  PauseCriteria: ").Append(PauseCriteria).Append("\n");
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
        return Equals(obj as CobrowseSettings);
    }

    /// <summary>
    /// Returns true if CobrowseSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of CobrowseSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CobrowseSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                AllowAgentControl == other.AllowAgentControl ||
                AllowAgentControl != null &&
                AllowAgentControl.Equals(other.AllowAgentControl)
            ) &&
            (
                AllowAgentNavigation == other.AllowAgentNavigation ||
                AllowAgentNavigation != null &&
                AllowAgentNavigation.Equals(other.AllowAgentNavigation)
            ) &&
            (
                AllowDraw == other.AllowDraw ||
                AllowDraw != null &&
                AllowDraw.Equals(other.AllowDraw)
            ) &&
            (
                MaskSelectors == other.MaskSelectors ||
                MaskSelectors != null &&
                MaskSelectors.SequenceEqual(other.MaskSelectors)
            ) &&
            (
                Channels == other.Channels ||
                Channels != null &&
                Channels.SequenceEqual(other.Channels)
            ) &&
            (
                ReadonlySelectors == other.ReadonlySelectors ||
                ReadonlySelectors != null &&
                ReadonlySelectors.SequenceEqual(other.ReadonlySelectors)
            ) &&
            (
                PauseCriteria == other.PauseCriteria ||
                PauseCriteria != null &&
                PauseCriteria.SequenceEqual(other.PauseCriteria)
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
            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (AllowAgentControl != null)
            {
                hash = hash * 59 + AllowAgentControl.GetHashCode();
            }

            if (AllowAgentNavigation != null)
            {
                hash = hash * 59 + AllowAgentNavigation.GetHashCode();
            }

            if (AllowDraw != null)
            {
                hash = hash * 59 + AllowDraw.GetHashCode();
            }

            if (MaskSelectors != null)
            {
                hash = hash * 59 + MaskSelectors.GetHashCode();
            }

            if (Channels != null)
            {
                hash = hash * 59 + Channels.GetHashCode();
            }

            if (ReadonlySelectors != null)
            {
                hash = hash * 59 + ReadonlySelectors.GetHashCode();
            }

            if (PauseCriteria != null)
            {
                hash = hash * 59 + PauseCriteria.GetHashCode();
            }

            return hash;
        }
    }
}

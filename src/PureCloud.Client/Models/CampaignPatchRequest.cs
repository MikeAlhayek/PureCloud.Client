using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Campaign patch request
/// </summary>

public partial class CampaignPatchRequest : IEquatable<CampaignPatchRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignPatchRequest" /> class.
    /// </summary>
    /// <param name="OutboundLineCount">The number of outbound lines to be concurrently dialed..</param>
    /// <param name="AbandonRate">The targeted compliance abandon rate percentage.</param>
    /// <param name="MaxCallsPerAgent">The maximum number of calls that can be placed per agent on this campaign.</param>
    /// <param name="DynamicLineBalancingSettings">Dynamic line balancing settings.</param>
    /// <param name="Queue">The Queue for this Campaign to route calls to..</param>
    public CampaignPatchRequest(int? OutboundLineCount = null, double? AbandonRate = null, double? MaxCallsPerAgent = null, DynamicLineBalancingSettingsPatchRequest DynamicLineBalancingSettings = null, AddressableEntityRef Queue = null)
    {
        this.OutboundLineCount = OutboundLineCount;
        this.AbandonRate = AbandonRate;
        this.MaxCallsPerAgent = MaxCallsPerAgent;
        this.DynamicLineBalancingSettings = DynamicLineBalancingSettings;
        this.Queue = Queue;

    }



    /// <summary>
    /// The number of outbound lines to be concurrently dialed.
    /// </summary>
    /// <value>The number of outbound lines to be concurrently dialed.</value>
    [JsonPropertyName("outboundLineCount")]
    public int? OutboundLineCount { get; set; }



    /// <summary>
    /// The targeted compliance abandon rate percentage
    /// </summary>
    /// <value>The targeted compliance abandon rate percentage</value>
    [JsonPropertyName("abandonRate")]
    public double? AbandonRate { get; set; }



    /// <summary>
    /// The maximum number of calls that can be placed per agent on this campaign
    /// </summary>
    /// <value>The maximum number of calls that can be placed per agent on this campaign</value>
    [JsonPropertyName("maxCallsPerAgent")]
    public double? MaxCallsPerAgent { get; set; }



    /// <summary>
    /// Dynamic line balancing settings
    /// </summary>
    /// <value>Dynamic line balancing settings</value>
    [JsonPropertyName("dynamicLineBalancingSettings")]
    public DynamicLineBalancingSettingsPatchRequest DynamicLineBalancingSettings { get; set; }



    /// <summary>
    /// The Queue for this Campaign to route calls to.
    /// </summary>
    /// <value>The Queue for this Campaign to route calls to.</value>
    [JsonPropertyName("queue")]
    public AddressableEntityRef Queue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignPatchRequest {\n");

        sb.Append("  OutboundLineCount: ").Append(OutboundLineCount).Append("\n");
        sb.Append("  AbandonRate: ").Append(AbandonRate).Append("\n");
        sb.Append("  MaxCallsPerAgent: ").Append(MaxCallsPerAgent).Append("\n");
        sb.Append("  DynamicLineBalancingSettings: ").Append(DynamicLineBalancingSettings).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
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
        return Equals(obj as CampaignPatchRequest);
    }

    /// <summary>
    /// Returns true if CampaignPatchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignPatchRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignPatchRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OutboundLineCount == other.OutboundLineCount ||
                OutboundLineCount != null &&
                OutboundLineCount.Equals(other.OutboundLineCount)
            ) &&
            (
                AbandonRate == other.AbandonRate ||
                AbandonRate != null &&
                AbandonRate.Equals(other.AbandonRate)
            ) &&
            (
                MaxCallsPerAgent == other.MaxCallsPerAgent ||
                MaxCallsPerAgent != null &&
                MaxCallsPerAgent.Equals(other.MaxCallsPerAgent)
            ) &&
            (
                DynamicLineBalancingSettings == other.DynamicLineBalancingSettings ||
                DynamicLineBalancingSettings != null &&
                DynamicLineBalancingSettings.Equals(other.DynamicLineBalancingSettings)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
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
            if (OutboundLineCount != null)
            {
                hash = hash * 59 + OutboundLineCount.GetHashCode();
            }

            if (AbandonRate != null)
            {
                hash = hash * 59 + AbandonRate.GetHashCode();
            }

            if (MaxCallsPerAgent != null)
            {
                hash = hash * 59 + MaxCallsPerAgent.GetHashCode();
            }

            if (DynamicLineBalancingSettings != null)
            {
                hash = hash * 59 + DynamicLineBalancingSettings.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            return hash;
        }
    }
}

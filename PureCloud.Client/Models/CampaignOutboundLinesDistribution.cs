using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Lines distribution information or Campaign&#39;s Edge Group or Site
/// </summary>
[DataContract]
public partial class CampaignOutboundLinesDistribution : IEquatable<CampaignOutboundLinesDistribution>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignOutboundLinesDistribution" /> class.
    /// </summary>
    /// <param name="Campaign">The Campaign for which dialing group distribution information was requested.</param>
    /// <param name="MaxOutboundLineCount">Maximum outbound calls that can be placed for Campaign&#39;s Edge Group or Site.</param>
    /// <param name="MaxLineUtilization">Maximum ratio of dialer calls to Campaign&#39;s Edge Group or Site capacity.</param>
    /// <param name="AvailableOutboundLines">Number of available outbound lines in Campaign&#39;s Edge Group or Site.</param>
    /// <param name="ReservedLines">Number of reserved outbound lines in Campaign&#39;s Edge Group or Site.</param>
    /// <param name="CampaignsWithReservedLines">Information about campaigns with reserving lines in Campaign&#39;s Edge Group or Site.</param>
    /// <param name="CampaignsWithDynamicallyAllocatedLines">Information about campaigns using dynamic lines allocation in Campaign&#39;s Edge Group or Site.</param>
    public CampaignOutboundLinesDistribution(AddressableEntityRef Campaign = null, int? MaxOutboundLineCount = null, double? MaxLineUtilization = null, int? AvailableOutboundLines = null, int? ReservedLines = null, List<CampaignOutboundLinesReservation> CampaignsWithReservedLines = null, List<CampaignOutboundLinesAllocation> CampaignsWithDynamicallyAllocatedLines = null)
    {
        this.Campaign = Campaign;
        this.MaxOutboundLineCount = MaxOutboundLineCount;
        this.MaxLineUtilization = MaxLineUtilization;
        this.AvailableOutboundLines = AvailableOutboundLines;
        this.ReservedLines = ReservedLines;
        this.CampaignsWithReservedLines = CampaignsWithReservedLines;
        this.CampaignsWithDynamicallyAllocatedLines = CampaignsWithDynamicallyAllocatedLines;

    }



    /// <summary>
    /// The Campaign for which dialing group distribution information was requested
    /// </summary>
    /// <value>The Campaign for which dialing group distribution information was requested</value>
    [DataMember(Name = "campaign", EmitDefaultValue = false)]
    public AddressableEntityRef Campaign { get; set; }



    /// <summary>
    /// Maximum outbound calls that can be placed for Campaign&#39;s Edge Group or Site
    /// </summary>
    /// <value>Maximum outbound calls that can be placed for Campaign&#39;s Edge Group or Site</value>
    [DataMember(Name = "maxOutboundLineCount", EmitDefaultValue = false)]
    public int? MaxOutboundLineCount { get; set; }



    /// <summary>
    /// Maximum ratio of dialer calls to Campaign&#39;s Edge Group or Site capacity
    /// </summary>
    /// <value>Maximum ratio of dialer calls to Campaign&#39;s Edge Group or Site capacity</value>
    [DataMember(Name = "maxLineUtilization", EmitDefaultValue = false)]
    public double? MaxLineUtilization { get; set; }



    /// <summary>
    /// Number of available outbound lines in Campaign&#39;s Edge Group or Site
    /// </summary>
    /// <value>Number of available outbound lines in Campaign&#39;s Edge Group or Site</value>
    [DataMember(Name = "availableOutboundLines", EmitDefaultValue = false)]
    public int? AvailableOutboundLines { get; set; }



    /// <summary>
    /// Number of reserved outbound lines in Campaign&#39;s Edge Group or Site
    /// </summary>
    /// <value>Number of reserved outbound lines in Campaign&#39;s Edge Group or Site</value>
    [DataMember(Name = "reservedLines", EmitDefaultValue = false)]
    public int? ReservedLines { get; set; }



    /// <summary>
    /// Information about campaigns with reserving lines in Campaign&#39;s Edge Group or Site
    /// </summary>
    /// <value>Information about campaigns with reserving lines in Campaign&#39;s Edge Group or Site</value>
    [DataMember(Name = "campaignsWithReservedLines", EmitDefaultValue = false)]
    public List<CampaignOutboundLinesReservation> CampaignsWithReservedLines { get; set; }



    /// <summary>
    /// Information about campaigns using dynamic lines allocation in Campaign&#39;s Edge Group or Site
    /// </summary>
    /// <value>Information about campaigns using dynamic lines allocation in Campaign&#39;s Edge Group or Site</value>
    [DataMember(Name = "campaignsWithDynamicallyAllocatedLines", EmitDefaultValue = false)]
    public List<CampaignOutboundLinesAllocation> CampaignsWithDynamicallyAllocatedLines { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignOutboundLinesDistribution {\n");

        sb.Append("  Campaign: ").Append(Campaign).Append("\n");
        sb.Append("  MaxOutboundLineCount: ").Append(MaxOutboundLineCount).Append("\n");
        sb.Append("  MaxLineUtilization: ").Append(MaxLineUtilization).Append("\n");
        sb.Append("  AvailableOutboundLines: ").Append(AvailableOutboundLines).Append("\n");
        sb.Append("  ReservedLines: ").Append(ReservedLines).Append("\n");
        sb.Append("  CampaignsWithReservedLines: ").Append(CampaignsWithReservedLines).Append("\n");
        sb.Append("  CampaignsWithDynamicallyAllocatedLines: ").Append(CampaignsWithDynamicallyAllocatedLines).Append("\n");
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
        return Equals(obj as CampaignOutboundLinesDistribution);
    }

    /// <summary>
    /// Returns true if CampaignOutboundLinesDistribution instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignOutboundLinesDistribution to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignOutboundLinesDistribution other)
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
                MaxOutboundLineCount == other.MaxOutboundLineCount ||
                MaxOutboundLineCount != null &&
                MaxOutboundLineCount.Equals(other.MaxOutboundLineCount)
            ) &&
            (
                MaxLineUtilization == other.MaxLineUtilization ||
                MaxLineUtilization != null &&
                MaxLineUtilization.Equals(other.MaxLineUtilization)
            ) &&
            (
                AvailableOutboundLines == other.AvailableOutboundLines ||
                AvailableOutboundLines != null &&
                AvailableOutboundLines.Equals(other.AvailableOutboundLines)
            ) &&
            (
                ReservedLines == other.ReservedLines ||
                ReservedLines != null &&
                ReservedLines.Equals(other.ReservedLines)
            ) &&
            (
                CampaignsWithReservedLines == other.CampaignsWithReservedLines ||
                CampaignsWithReservedLines != null &&
                CampaignsWithReservedLines.SequenceEqual(other.CampaignsWithReservedLines)
            ) &&
            (
                CampaignsWithDynamicallyAllocatedLines == other.CampaignsWithDynamicallyAllocatedLines ||
                CampaignsWithDynamicallyAllocatedLines != null &&
                CampaignsWithDynamicallyAllocatedLines.SequenceEqual(other.CampaignsWithDynamicallyAllocatedLines)
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

            if (MaxOutboundLineCount != null)
            {
                hash = hash * 59 + MaxOutboundLineCount.GetHashCode();
            }

            if (MaxLineUtilization != null)
            {
                hash = hash * 59 + MaxLineUtilization.GetHashCode();
            }

            if (AvailableOutboundLines != null)
            {
                hash = hash * 59 + AvailableOutboundLines.GetHashCode();
            }

            if (ReservedLines != null)
            {
                hash = hash * 59 + ReservedLines.GetHashCode();
            }

            if (CampaignsWithReservedLines != null)
            {
                hash = hash * 59 + CampaignsWithReservedLines.GetHashCode();
            }

            if (CampaignsWithDynamicallyAllocatedLines != null)
            {
                hash = hash * 59 + CampaignsWithDynamicallyAllocatedLines.GetHashCode();
            }

            return hash;
        }
    }
}

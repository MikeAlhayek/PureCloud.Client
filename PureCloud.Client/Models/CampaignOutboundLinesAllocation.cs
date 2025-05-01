using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignOutboundLinesAllocation
/// </summary>
[DataContract]
public partial class CampaignOutboundLinesAllocation : IEquatable<CampaignOutboundLinesAllocation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignOutboundLinesAllocation" /> class.
    /// </summary>
    /// <param name="Campaign">The Campaign.</param>
    /// <param name="CampaignWeight">The relative weight of the campaign.</param>
    /// <param name="LinesAssigned">The number of lines dynamically assigned to the campaign.</param>
    /// <param name="LegacyWeight">true if relative weight of the campaign is not explicitly specified, false otherwise.</param>
    public CampaignOutboundLinesAllocation(DomainEntityRef Campaign = null, int? CampaignWeight = null, int? LinesAssigned = null, bool? LegacyWeight = null)
    {
        this.Campaign = Campaign;
        this.CampaignWeight = CampaignWeight;
        this.LinesAssigned = LinesAssigned;
        this.LegacyWeight = LegacyWeight;

    }



    /// <summary>
    /// The Campaign
    /// </summary>
    /// <value>The Campaign</value>
    [DataMember(Name = "campaign", EmitDefaultValue = false)]
    public DomainEntityRef Campaign { get; set; }



    /// <summary>
    /// The relative weight of the campaign
    /// </summary>
    /// <value>The relative weight of the campaign</value>
    [DataMember(Name = "campaignWeight", EmitDefaultValue = false)]
    public int? CampaignWeight { get; set; }



    /// <summary>
    /// The number of lines dynamically assigned to the campaign
    /// </summary>
    /// <value>The number of lines dynamically assigned to the campaign</value>
    [DataMember(Name = "linesAssigned", EmitDefaultValue = false)]
    public int? LinesAssigned { get; set; }



    /// <summary>
    /// true if relative weight of the campaign is not explicitly specified, false otherwise
    /// </summary>
    /// <value>true if relative weight of the campaign is not explicitly specified, false otherwise</value>
    [DataMember(Name = "legacyWeight", EmitDefaultValue = false)]
    public bool? LegacyWeight { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignOutboundLinesAllocation {\n");

        sb.Append("  Campaign: ").Append(Campaign).Append("\n");
        sb.Append("  CampaignWeight: ").Append(CampaignWeight).Append("\n");
        sb.Append("  LinesAssigned: ").Append(LinesAssigned).Append("\n");
        sb.Append("  LegacyWeight: ").Append(LegacyWeight).Append("\n");
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
        return Equals(obj as CampaignOutboundLinesAllocation);
    }

    /// <summary>
    /// Returns true if CampaignOutboundLinesAllocation instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignOutboundLinesAllocation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignOutboundLinesAllocation other)
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
                CampaignWeight == other.CampaignWeight ||
                CampaignWeight != null &&
                CampaignWeight.Equals(other.CampaignWeight)
            ) &&
            (
                LinesAssigned == other.LinesAssigned ||
                LinesAssigned != null &&
                LinesAssigned.Equals(other.LinesAssigned)
            ) &&
            (
                LegacyWeight == other.LegacyWeight ||
                LegacyWeight != null &&
                LegacyWeight.Equals(other.LegacyWeight)
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

            if (CampaignWeight != null)
            {
                hash = hash * 59 + CampaignWeight.GetHashCode();
            }

            if (LinesAssigned != null)
            {
                hash = hash * 59 + LinesAssigned.GetHashCode();
            }

            if (LegacyWeight != null)
            {
                hash = hash * 59 + LegacyWeight.GetHashCode();
            }

            return hash;
        }
    }
}

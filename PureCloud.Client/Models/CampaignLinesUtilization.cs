using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignLinesUtilization
/// </summary>

public partial class CampaignLinesUtilization : IEquatable<CampaignLinesUtilization>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignLinesUtilization" /> class.
    /// </summary>
    /// <param name="AssignedOutboundLines">Number of outbound lines assigned to the campaign.</param>
    /// <param name="TotalAvailableOutboundLines">Total number of available outbound lines in Campaign&#39;s Edge Group or Site.</param>
    public CampaignLinesUtilization(int? AssignedOutboundLines = null, int? TotalAvailableOutboundLines = null)
    {
        this.AssignedOutboundLines = AssignedOutboundLines;
        this.TotalAvailableOutboundLines = TotalAvailableOutboundLines;

    }



    /// <summary>
    /// Number of outbound lines assigned to the campaign
    /// </summary>
    /// <value>Number of outbound lines assigned to the campaign</value>
    [JsonPropertyName("assignedOutboundLines")]
    public int? AssignedOutboundLines { get; set; }



    /// <summary>
    /// Total number of available outbound lines in Campaign&#39;s Edge Group or Site
    /// </summary>
    /// <value>Total number of available outbound lines in Campaign&#39;s Edge Group or Site</value>
    [JsonPropertyName("totalAvailableOutboundLines")]
    public int? TotalAvailableOutboundLines { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignLinesUtilization {\n");

        sb.Append("  AssignedOutboundLines: ").Append(AssignedOutboundLines).Append("\n");
        sb.Append("  TotalAvailableOutboundLines: ").Append(TotalAvailableOutboundLines).Append("\n");
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
        return Equals(obj as CampaignLinesUtilization);
    }

    /// <summary>
    /// Returns true if CampaignLinesUtilization instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignLinesUtilization to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignLinesUtilization other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AssignedOutboundLines == other.AssignedOutboundLines ||
                AssignedOutboundLines != null &&
                AssignedOutboundLines.Equals(other.AssignedOutboundLines)
            ) &&
            (
                TotalAvailableOutboundLines == other.TotalAvailableOutboundLines ||
                TotalAvailableOutboundLines != null &&
                TotalAvailableOutboundLines.Equals(other.TotalAvailableOutboundLines)
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
            if (AssignedOutboundLines != null)
            {
                hash = hash * 59 + AssignedOutboundLines.GetHashCode();
            }

            if (TotalAvailableOutboundLines != null)
            {
                hash = hash * 59 + TotalAvailableOutboundLines.GetHashCode();
            }

            return hash;
        }
    }
}

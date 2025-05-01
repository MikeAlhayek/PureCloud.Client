using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignOutboundLinesReservation
/// </summary>
[DataContract]
public partial class CampaignOutboundLinesReservation : IEquatable<CampaignOutboundLinesReservation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignOutboundLinesReservation" /> class.
    /// </summary>
    /// <param name="Campaign">The Campaign.</param>
    /// <param name="LinesReserved">The number of lines reserved for the campaign.</param>
    public CampaignOutboundLinesReservation(DomainEntityRef Campaign = null, int? LinesReserved = null)
    {
        this.Campaign = Campaign;
        this.LinesReserved = LinesReserved;

    }



    /// <summary>
    /// The Campaign
    /// </summary>
    /// <value>The Campaign</value>
    [DataMember(Name = "campaign", EmitDefaultValue = false)]
    public DomainEntityRef Campaign { get; set; }



    /// <summary>
    /// The number of lines reserved for the campaign
    /// </summary>
    /// <value>The number of lines reserved for the campaign</value>
    [DataMember(Name = "linesReserved", EmitDefaultValue = false)]
    public int? LinesReserved { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignOutboundLinesReservation {\n");

        sb.Append("  Campaign: ").Append(Campaign).Append("\n");
        sb.Append("  LinesReserved: ").Append(LinesReserved).Append("\n");
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
        return Equals(obj as CampaignOutboundLinesReservation);
    }

    /// <summary>
    /// Returns true if CampaignOutboundLinesReservation instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignOutboundLinesReservation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignOutboundLinesReservation other)
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
                LinesReserved == other.LinesReserved ||
                LinesReserved != null &&
                LinesReserved.Equals(other.LinesReserved)
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

            if (LinesReserved != null)
            {
                hash = hash * 59 + LinesReserved.GetHashCode();
            }

            return hash;
        }
    }
}

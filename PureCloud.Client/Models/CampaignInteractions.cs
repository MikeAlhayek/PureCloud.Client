using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignInteractions
/// </summary>
[DataContract]
public partial class CampaignInteractions : IEquatable<CampaignInteractions>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignInteractions" /> class.
    /// </summary>
    /// <param name="Campaign">Campaign.</param>
    /// <param name="PendingInteractions">PendingInteractions.</param>
    /// <param name="ProceedingInteractions">ProceedingInteractions.</param>
    /// <param name="PreviewingInteractions">PreviewingInteractions.</param>
    /// <param name="InteractingInteractions">InteractingInteractions.</param>
    /// <param name="ScheduledInteractions">ScheduledInteractions.</param>
    public CampaignInteractions(DomainEntityRef Campaign = null, List<CampaignInteraction> PendingInteractions = null, List<CampaignInteraction> ProceedingInteractions = null, List<CampaignInteraction> PreviewingInteractions = null, List<CampaignInteraction> InteractingInteractions = null, List<CampaignInteraction> ScheduledInteractions = null)
    {
        this.Campaign = Campaign;
        this.PendingInteractions = PendingInteractions;
        this.ProceedingInteractions = ProceedingInteractions;
        this.PreviewingInteractions = PreviewingInteractions;
        this.InteractingInteractions = InteractingInteractions;
        this.ScheduledInteractions = ScheduledInteractions;

    }



    /// <summary>
    /// Gets or Sets Campaign
    /// </summary>
    [DataMember(Name = "campaign", EmitDefaultValue = false)]
    public DomainEntityRef Campaign { get; set; }



    /// <summary>
    /// Gets or Sets PendingInteractions
    /// </summary>
    [DataMember(Name = "pendingInteractions", EmitDefaultValue = false)]
    public List<CampaignInteraction> PendingInteractions { get; set; }



    /// <summary>
    /// Gets or Sets ProceedingInteractions
    /// </summary>
    [DataMember(Name = "proceedingInteractions", EmitDefaultValue = false)]
    public List<CampaignInteraction> ProceedingInteractions { get; set; }



    /// <summary>
    /// Gets or Sets PreviewingInteractions
    /// </summary>
    [DataMember(Name = "previewingInteractions", EmitDefaultValue = false)]
    public List<CampaignInteraction> PreviewingInteractions { get; set; }



    /// <summary>
    /// Gets or Sets InteractingInteractions
    /// </summary>
    [DataMember(Name = "interactingInteractions", EmitDefaultValue = false)]
    public List<CampaignInteraction> InteractingInteractions { get; set; }



    /// <summary>
    /// Gets or Sets ScheduledInteractions
    /// </summary>
    [DataMember(Name = "scheduledInteractions", EmitDefaultValue = false)]
    public List<CampaignInteraction> ScheduledInteractions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignInteractions {\n");

        sb.Append("  Campaign: ").Append(Campaign).Append("\n");
        sb.Append("  PendingInteractions: ").Append(PendingInteractions).Append("\n");
        sb.Append("  ProceedingInteractions: ").Append(ProceedingInteractions).Append("\n");
        sb.Append("  PreviewingInteractions: ").Append(PreviewingInteractions).Append("\n");
        sb.Append("  InteractingInteractions: ").Append(InteractingInteractions).Append("\n");
        sb.Append("  ScheduledInteractions: ").Append(ScheduledInteractions).Append("\n");
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
        return Equals(obj as CampaignInteractions);
    }

    /// <summary>
    /// Returns true if CampaignInteractions instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignInteractions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignInteractions other)
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
                PendingInteractions == other.PendingInteractions ||
                PendingInteractions != null &&
                PendingInteractions.SequenceEqual(other.PendingInteractions)
            ) &&
            (
                ProceedingInteractions == other.ProceedingInteractions ||
                ProceedingInteractions != null &&
                ProceedingInteractions.SequenceEqual(other.ProceedingInteractions)
            ) &&
            (
                PreviewingInteractions == other.PreviewingInteractions ||
                PreviewingInteractions != null &&
                PreviewingInteractions.SequenceEqual(other.PreviewingInteractions)
            ) &&
            (
                InteractingInteractions == other.InteractingInteractions ||
                InteractingInteractions != null &&
                InteractingInteractions.SequenceEqual(other.InteractingInteractions)
            ) &&
            (
                ScheduledInteractions == other.ScheduledInteractions ||
                ScheduledInteractions != null &&
                ScheduledInteractions.SequenceEqual(other.ScheduledInteractions)
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

            if (PendingInteractions != null)
            {
                hash = hash * 59 + PendingInteractions.GetHashCode();
            }

            if (ProceedingInteractions != null)
            {
                hash = hash * 59 + ProceedingInteractions.GetHashCode();
            }

            if (PreviewingInteractions != null)
            {
                hash = hash * 59 + PreviewingInteractions.GetHashCode();
            }

            if (InteractingInteractions != null)
            {
                hash = hash * 59 + InteractingInteractions.GetHashCode();
            }

            if (ScheduledInteractions != null)
            {
                hash = hash * 59 + ScheduledInteractions.GetHashCode();
            }

            return hash;
        }
    }
}

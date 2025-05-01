using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkPlanBidRanks
/// </summary>
[DataContract]
public partial class WorkPlanBidRanks : IEquatable<WorkPlanBidRanks>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkPlanBidRanks" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the user..</param>
    /// <param name="WorkPlanBiddingPerformance">Work plan bidding agent performance ranking. The range of values is between 0 and 9999..</param>
    /// <param name="BiddingTieBreaker">Custom agent ranking metric that some customers can use..</param>
    public WorkPlanBidRanks(string Id = null, int? WorkPlanBiddingPerformance = null, string BiddingTieBreaker = null)
    {
        this.Id = Id;
        this.WorkPlanBiddingPerformance = WorkPlanBiddingPerformance;
        this.BiddingTieBreaker = BiddingTieBreaker;

    }



    /// <summary>
    /// The globally unique identifier for the user.
    /// </summary>
    /// <value>The globally unique identifier for the user.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Work plan bidding agent performance ranking. The range of values is between 0 and 9999.
    /// </summary>
    /// <value>Work plan bidding agent performance ranking. The range of values is between 0 and 9999.</value>
    [DataMember(Name = "workPlanBiddingPerformance", EmitDefaultValue = false)]
    public int? WorkPlanBiddingPerformance { get; set; }



    /// <summary>
    /// Custom agent ranking metric that some customers can use.
    /// </summary>
    /// <value>Custom agent ranking metric that some customers can use.</value>
    [DataMember(Name = "biddingTieBreaker", EmitDefaultValue = false)]
    public string BiddingTieBreaker { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkPlanBidRanks {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  WorkPlanBiddingPerformance: ").Append(WorkPlanBiddingPerformance).Append("\n");
        sb.Append("  BiddingTieBreaker: ").Append(BiddingTieBreaker).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as WorkPlanBidRanks);
    }

    /// <summary>
    /// Returns true if WorkPlanBidRanks instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkPlanBidRanks to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkPlanBidRanks other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                WorkPlanBiddingPerformance == other.WorkPlanBiddingPerformance ||
                WorkPlanBiddingPerformance != null &&
                WorkPlanBiddingPerformance.Equals(other.WorkPlanBiddingPerformance)
            ) &&
            (
                BiddingTieBreaker == other.BiddingTieBreaker ||
                BiddingTieBreaker != null &&
                BiddingTieBreaker.Equals(other.BiddingTieBreaker)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (WorkPlanBiddingPerformance != null)
            {
                hash = hash * 59 + WorkPlanBiddingPerformance.GetHashCode();
            }

            if (BiddingTieBreaker != null)
            {
                hash = hash * 59 + BiddingTieBreaker.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

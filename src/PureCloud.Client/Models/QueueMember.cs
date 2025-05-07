using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueMember
/// </summary>

public partial class QueueMember : IEquatable<QueueMember>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueMember" /> class.
    /// </summary>
    /// <param name="Id">The queue member&#39;s id..</param>
    /// <param name="Name">Name.</param>
    /// <param name="User">User.</param>
    /// <param name="RingNumber">RingNumber.</param>
    /// <param name="Joined">Joined.</param>
    /// <param name="MemberBy">MemberBy.</param>
    /// <param name="RoutingStatus">RoutingStatus.</param>
    public QueueMember(string Id = null, string Name = null, User User = null, int? RingNumber = null, bool? Joined = null, string MemberBy = null, RoutingStatus RoutingStatus = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.User = User;
        this.RingNumber = RingNumber;
        this.Joined = Joined;
        this.MemberBy = MemberBy;
        this.RoutingStatus = RoutingStatus;

    }



    /// <summary>
    /// The queue member&#39;s id.
    /// </summary>
    /// <value>The queue member&#39;s id.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public User User { get; set; }



    /// <summary>
    /// Gets or Sets RingNumber
    /// </summary>
    [JsonPropertyName("ringNumber")]
    public int? RingNumber { get; set; }



    /// <summary>
    /// Gets or Sets Joined
    /// </summary>
    [JsonPropertyName("joined")]
    public bool? Joined { get; set; }



    /// <summary>
    /// Gets or Sets MemberBy
    /// </summary>
    [JsonPropertyName("memberBy")]
    public string MemberBy { get; set; }



    /// <summary>
    /// Gets or Sets RoutingStatus
    /// </summary>
    [JsonPropertyName("routingStatus")]
    public RoutingStatus RoutingStatus { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueMember {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  RingNumber: ").Append(RingNumber).Append("\n");
        sb.Append("  Joined: ").Append(Joined).Append("\n");
        sb.Append("  MemberBy: ").Append(MemberBy).Append("\n");
        sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
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
        return Equals(obj as QueueMember);
    }

    /// <summary>
    /// Returns true if QueueMember instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueMember to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueMember other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                RingNumber == other.RingNumber ||
                RingNumber != null &&
                RingNumber.Equals(other.RingNumber)
            ) &&
            (
                Joined == other.Joined ||
                Joined != null &&
                Joined.Equals(other.Joined)
            ) &&
            (
                MemberBy == other.MemberBy ||
                MemberBy != null &&
                MemberBy.Equals(other.MemberBy)
            ) &&
            (
                RoutingStatus == other.RoutingStatus ||
                RoutingStatus != null &&
                RoutingStatus.Equals(other.RoutingStatus)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (RingNumber != null)
            {
                hash = hash * 59 + RingNumber.GetHashCode();
            }

            if (Joined != null)
            {
                hash = hash * 59 + Joined.GetHashCode();
            }

            if (MemberBy != null)
            {
                hash = hash * 59 + MemberBy.GetHashCode();
            }

            if (RoutingStatus != null)
            {
                hash = hash * 59 + RoutingStatus.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

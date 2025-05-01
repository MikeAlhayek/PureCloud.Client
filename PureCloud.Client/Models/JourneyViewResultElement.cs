using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// An element within a journey view result
/// </summary>
[DataContract]
public partial class JourneyViewResultElement : IEquatable<JourneyViewResultElement>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewResultElement" /> class.
    /// </summary>
    public JourneyViewResultElement()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// the metrics of the current element
    /// </summary>
    /// <value>the metrics of the current element</value>
    [DataMember(Name = "metrics", EmitDefaultValue = false)]
    public JourneyViewResultMetrics Metrics { get; private set; }



    /// <summary>
    /// the list of links following the current element in the journey
    /// </summary>
    /// <value>the list of links following the current element in the journey</value>
    [DataMember(Name = "followedBy", EmitDefaultValue = false)]
    public List<JourneyViewResultLink> FollowedBy { get; private set; }



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
        sb.Append("class JourneyViewResultElement {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Metrics: ").Append(Metrics).Append("\n");
        sb.Append("  FollowedBy: ").Append(FollowedBy).Append("\n");
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
        return Equals(obj as JourneyViewResultElement);
    }

    /// <summary>
    /// Returns true if JourneyViewResultElement instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewResultElement to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewResultElement other)
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
                Metrics == other.Metrics ||
                Metrics != null &&
                Metrics.Equals(other.Metrics)
            ) &&
            (
                FollowedBy == other.FollowedBy ||
                FollowedBy != null &&
                FollowedBy.SequenceEqual(other.FollowedBy)
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

            if (Metrics != null)
            {
                hash = hash * 59 + Metrics.GetHashCode();
            }

            if (FollowedBy != null)
            {
                hash = hash * 59 + FollowedBy.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

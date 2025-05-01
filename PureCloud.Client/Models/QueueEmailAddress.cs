using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueEmailAddress
/// </summary>
[DataContract]
public partial class QueueEmailAddress : IEquatable<QueueEmailAddress>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueEmailAddress" /> class.
    /// </summary>
    /// <param name="Domain">Domain.</param>
    /// <param name="Route">Route.</param>
    public QueueEmailAddress(DomainEntityRef Domain = null, InboundRoute Route = null)
    {
        this.Domain = Domain;
        this.Route = Route;

    }



    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    [DataMember(Name = "domain", EmitDefaultValue = false)]
    public DomainEntityRef Domain { get; set; }



    /// <summary>
    /// Gets or Sets Route
    /// </summary>
    [DataMember(Name = "route", EmitDefaultValue = false)]
    public InboundRoute Route { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueEmailAddress {\n");

        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Route: ").Append(Route).Append("\n");
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
        return Equals(obj as QueueEmailAddress);
    }

    /// <summary>
    /// Returns true if QueueEmailAddress instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueEmailAddress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueEmailAddress other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Domain == other.Domain ||
                Domain != null &&
                Domain.Equals(other.Domain)
            ) &&
            (
                Route == other.Route ||
                Route != null &&
                Route.Equals(other.Route)
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
            if (Domain != null)
            {
                hash = hash * 59 + Domain.GetHashCode();
            }

            if (Route != null)
            {
                hash = hash * 59 + Route.GetHashCode();
            }

            return hash;
        }
    }
}

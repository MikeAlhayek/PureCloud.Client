using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// RoutingActivityData
/// </summary>
[DataContract]
public partial class RoutingActivityData : IEquatable<RoutingActivityData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingActivityData" /> class.
    /// </summary>
    /// <param name="Group">A mapping from grouping dimension to value.</param>
    /// <param name="Data">Data for metrics.</param>
    /// <param name="Truncated">Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities..</param>
    /// <param name="Entities">Details for active entities.</param>
    public RoutingActivityData(Dictionary<string, string> Group = null, List<RoutingActivityMetricValue> Data = null, bool? Truncated = null, List<RoutingActivityEntityData> Entities = null)
    {
        this.Group = Group;
        this.Data = Data;
        this.Truncated = Truncated;
        this.Entities = Entities;

    }



    /// <summary>
    /// A mapping from grouping dimension to value
    /// </summary>
    /// <value>A mapping from grouping dimension to value</value>
    [DataMember(Name = "group", EmitDefaultValue = false)]
    public Dictionary<string, string> Group { get; set; }



    /// <summary>
    /// Data for metrics
    /// </summary>
    /// <value>Data for metrics</value>
    [DataMember(Name = "data", EmitDefaultValue = false)]
    public List<RoutingActivityMetricValue> Data { get; set; }



    /// <summary>
    /// Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities.
    /// </summary>
    /// <value>Flag for a truncated list of entities. If truncated, the first half of the list of entities will contain the oldest entities and the second half the newest entities.</value>
    [DataMember(Name = "truncated", EmitDefaultValue = false)]
    public bool? Truncated { get; set; }



    /// <summary>
    /// Details for active entities
    /// </summary>
    /// <value>Details for active entities</value>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<RoutingActivityEntityData> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RoutingActivityData {\n");

        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("  Truncated: ").Append(Truncated).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as RoutingActivityData);
    }

    /// <summary>
    /// Returns true if RoutingActivityData instances are equal
    /// </summary>
    /// <param name="other">Instance of RoutingActivityData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RoutingActivityData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Group == other.Group ||
                Group != null &&
                Group.SequenceEqual(other.Group)
            ) &&
            (
                Data == other.Data ||
                Data != null &&
                Data.SequenceEqual(other.Data)
            ) &&
            (
                Truncated == other.Truncated ||
                Truncated != null &&
                Truncated.Equals(other.Truncated)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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
            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            if (Data != null)
            {
                hash = hash * 59 + Data.GetHashCode();
            }

            if (Truncated != null)
            {
                hash = hash * 59 + Truncated.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            return hash;
        }
    }
}

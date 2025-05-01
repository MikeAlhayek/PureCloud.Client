using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DynamicContactQueueingSettings
/// </summary>
[DataContract]
public partial class DynamicContactQueueingSettings : IEquatable<DynamicContactQueueingSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DynamicContactQueueingSettings" /> class.
    /// </summary>
    /// <param name="Sort">Whether to sort contacts dynamically.</param>
    /// <param name="Filter">Whether to filter contacts dynamically.</param>
    public DynamicContactQueueingSettings(bool? Sort = null, bool? Filter = null)
    {
        this.Sort = Sort;
        this.Filter = Filter;

    }



    /// <summary>
    /// Whether to sort contacts dynamically
    /// </summary>
    /// <value>Whether to sort contacts dynamically</value>
    [DataMember(Name = "sort", EmitDefaultValue = false)]
    public bool? Sort { get; set; }



    /// <summary>
    /// Whether to filter contacts dynamically
    /// </summary>
    /// <value>Whether to filter contacts dynamically</value>
    [DataMember(Name = "filter", EmitDefaultValue = false)]
    public bool? Filter { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DynamicContactQueueingSettings {\n");

        sb.Append("  Sort: ").Append(Sort).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
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
        return this.Equals(obj as DynamicContactQueueingSettings);
    }

    /// <summary>
    /// Returns true if DynamicContactQueueingSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of DynamicContactQueueingSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DynamicContactQueueingSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Sort == other.Sort ||
                this.Sort != null &&
                this.Sort.Equals(other.Sort)
            ) &&
            (
                this.Filter == other.Filter ||
                this.Filter != null &&
                this.Filter.Equals(other.Filter)
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
            if (this.Sort != null)
            {
                hash = hash * 59 + this.Sort.GetHashCode();
            }

            if (this.Filter != null)
            {
                hash = hash * 59 + this.Filter.GetHashCode();
            }

            return hash;
        }
    }
}

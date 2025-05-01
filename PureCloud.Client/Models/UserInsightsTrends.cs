using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UserInsightsTrends
/// </summary>
[DataContract]
public partial class UserInsightsTrends : IEquatable<UserInsightsTrends>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserInsightsTrends" /> class.
    /// </summary>
    /// <param name="ComparativePeriod">List of trend data in the comparative period.</param>
    /// <param name="PrimaryPeriod">List of trend data in the primary period.</param>
    public UserInsightsTrends(List<UserTrendData> ComparativePeriod = null, List<UserTrendData> PrimaryPeriod = null)
    {
        this.ComparativePeriod = ComparativePeriod;
        this.PrimaryPeriod = PrimaryPeriod;

    }



    /// <summary>
    /// List of trend data in the comparative period
    /// </summary>
    /// <value>List of trend data in the comparative period</value>
    [DataMember(Name = "comparativePeriod", EmitDefaultValue = false)]
    public List<UserTrendData> ComparativePeriod { get; set; }



    /// <summary>
    /// List of trend data in the primary period
    /// </summary>
    /// <value>List of trend data in the primary period</value>
    [DataMember(Name = "primaryPeriod", EmitDefaultValue = false)]
    public List<UserTrendData> PrimaryPeriod { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserInsightsTrends {\n");

        sb.Append("  ComparativePeriod: ").Append(ComparativePeriod).Append("\n");
        sb.Append("  PrimaryPeriod: ").Append(PrimaryPeriod).Append("\n");
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
        return Equals(obj as UserInsightsTrends);
    }

    /// <summary>
    /// Returns true if UserInsightsTrends instances are equal
    /// </summary>
    /// <param name="other">Instance of UserInsightsTrends to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserInsightsTrends other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ComparativePeriod == other.ComparativePeriod ||
                ComparativePeriod != null &&
                ComparativePeriod.SequenceEqual(other.ComparativePeriod)
            ) &&
            (
                PrimaryPeriod == other.PrimaryPeriod ||
                PrimaryPeriod != null &&
                PrimaryPeriod.SequenceEqual(other.PrimaryPeriod)
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
            if (ComparativePeriod != null)
            {
                hash = hash * 59 + ComparativePeriod.GetHashCode();
            }

            if (PrimaryPeriod != null)
            {
                hash = hash * 59 + PrimaryPeriod.GetHashCode();
            }

            return hash;
        }
    }
}

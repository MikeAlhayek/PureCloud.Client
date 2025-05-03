using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemQuerySort
/// </summary>

public partial class WorkitemQuerySort : IEquatable<WorkitemQuerySort>
{
    /// <summary>
    /// Specify an attribute for sorting. It's possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can't be present in more than one filter.
    /// </summary>
    /// <value>Specify an attribute for sorting. It's possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can't be present in more than one filter.</value>
    
    public enum NameEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Datedue for "dateDue"
        /// </summary>
        [EnumMember(Value = "dateDue")]
        Datedue,

        /// <summary>
        /// Enum Priority for "priority"
        /// </summary>
        [EnumMember(Value = "priority")]
        Priority
    }
    /// <summary>
    /// Specify an attribute for sorting. It's possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can't be present in more than one filter.
    /// </summary>
    /// <value>Specify an attribute for sorting. It's possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can't be present in more than one filter.</value>
    [JsonPropertyName("name")]
    public NameEnum? Name { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemQuerySort" /> class.
    /// </summary>
    /// <param name="Name">Specify an attribute for sorting. It&#39;s possible to use an attribute both for sorting and in the query at the same time, but these restrictions apply: Only the operators EQ, LT, LTE, GT, GTE, BETWEEN and BEGINS_WITH are supported and the attribute can&#39;t be present in more than one filter..</param>
    /// <param name="Ascending">Sort Ascending.</param>
    public WorkitemQuerySort(NameEnum? Name = null, bool? Ascending = null)
    {
        this.Name = Name;
        this.Ascending = Ascending;

    }





    /// <summary>
    /// Sort Ascending
    /// </summary>
    /// <value>Sort Ascending</value>
    [JsonPropertyName("ascending")]
    public bool? Ascending { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemQuerySort {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Ascending: ").Append(Ascending).Append("\n");
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
        return Equals(obj as WorkitemQuerySort);
    }

    /// <summary>
    /// Returns true if WorkitemQuerySort instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemQuerySort to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemQuerySort other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Ascending == other.Ascending ||
                Ascending != null &&
                Ascending.Equals(other.Ascending)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Ascending != null)
            {
                hash = hash * 59 + Ascending.GetHashCode();
            }

            return hash;
        }
    }
}

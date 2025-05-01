using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HeadcountForecast
/// </summary>
[DataContract]
public partial class HeadcountForecast : IEquatable<HeadcountForecast>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="HeadcountForecast" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected HeadcountForecast() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="HeadcountForecast" /> class.
    /// </summary>
    /// <param name="Required">Headcount information with shrinkage (required).</param>
    /// <param name="RequiredWithoutShrinkage">Headcount information without shrinkage (required).</param>
    public HeadcountForecast(List<HeadcountInterval> Required = null, List<HeadcountInterval> RequiredWithoutShrinkage = null)
    {
        this.Required = Required;
        this.RequiredWithoutShrinkage = RequiredWithoutShrinkage;

    }



    /// <summary>
    /// Headcount information with shrinkage
    /// </summary>
    /// <value>Headcount information with shrinkage</value>
    [DataMember(Name = "required", EmitDefaultValue = false)]
    public List<HeadcountInterval> Required { get; set; }



    /// <summary>
    /// Headcount information without shrinkage
    /// </summary>
    /// <value>Headcount information without shrinkage</value>
    [DataMember(Name = "requiredWithoutShrinkage", EmitDefaultValue = false)]
    public List<HeadcountInterval> RequiredWithoutShrinkage { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HeadcountForecast {\n");

        sb.Append("  Required: ").Append(Required).Append("\n");
        sb.Append("  RequiredWithoutShrinkage: ").Append(RequiredWithoutShrinkage).Append("\n");
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
        return Equals(obj as HeadcountForecast);
    }

    /// <summary>
    /// Returns true if HeadcountForecast instances are equal
    /// </summary>
    /// <param name="other">Instance of HeadcountForecast to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HeadcountForecast other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Required == other.Required ||
                Required != null &&
                Required.SequenceEqual(other.Required)
            ) &&
            (
                RequiredWithoutShrinkage == other.RequiredWithoutShrinkage ||
                RequiredWithoutShrinkage != null &&
                RequiredWithoutShrinkage.SequenceEqual(other.RequiredWithoutShrinkage)
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
            if (Required != null)
            {
                hash = hash * 59 + Required.GetHashCode();
            }

            if (RequiredWithoutShrinkage != null)
            {
                hash = hash * 59 + RequiredWithoutShrinkage.GetHashCode();
            }

            return hash;
        }
    }
}

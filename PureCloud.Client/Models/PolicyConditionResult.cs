using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// PolicyConditionResult
/// </summary>
[DataContract]
public partial class PolicyConditionResult : IEquatable<PolicyConditionResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyConditionResult" /> class.
    /// </summary>
    /// <param name="Name">The condition name.</param>
    /// <param name="Result">The boolean result of the condition.</param>
    public PolicyConditionResult(string Name = null, bool? Result = null)
    {
        this.Name = Name;
        this.Result = Result;

    }



    /// <summary>
    /// The condition name
    /// </summary>
    /// <value>The condition name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The boolean result of the condition
    /// </summary>
    /// <value>The boolean result of the condition</value>
    [DataMember(Name = "result", EmitDefaultValue = false)]
    public bool? Result { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PolicyConditionResult {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
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
        return Equals(obj as PolicyConditionResult);
    }

    /// <summary>
    /// Returns true if PolicyConditionResult instances are equal
    /// </summary>
    /// <param name="other">Instance of PolicyConditionResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PolicyConditionResult other)
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
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
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

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            return hash;
        }
    }
}

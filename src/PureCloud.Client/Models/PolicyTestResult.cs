using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PolicyTestResult
/// </summary>

public partial class PolicyTestResult : IEquatable<PolicyTestResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyTestResult" /> class.
    /// </summary>
    /// <param name="Id">The ID of the policy being tested..</param>
    /// <param name="Name">The name of the policy being tested..</param>
    /// <param name="Result">The result of the evaluation against supplied test data..</param>
    /// <param name="PolicyConditionResults">The results of conditions, with their boolean result..</param>
    public PolicyTestResult(string Id = null, string Name = null, string Result = null, List<PolicyConditionResult> PolicyConditionResults = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Result = Result;
        this.PolicyConditionResults = PolicyConditionResults;

    }



    /// <summary>
    /// The ID of the policy being tested.
    /// </summary>
    /// <value>The ID of the policy being tested.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the policy being tested.
    /// </summary>
    /// <value>The name of the policy being tested.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The result of the evaluation against supplied test data.
    /// </summary>
    /// <value>The result of the evaluation against supplied test data.</value>
    [JsonPropertyName("result")]
    public string Result { get; set; }



    /// <summary>
    /// The results of conditions, with their boolean result.
    /// </summary>
    /// <value>The results of conditions, with their boolean result.</value>
    [JsonPropertyName("policyConditionResults")]
    public List<PolicyConditionResult> PolicyConditionResults { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PolicyTestResult {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Result: ").Append(Result).Append("\n");
        sb.Append("  PolicyConditionResults: ").Append(PolicyConditionResults).Append("\n");
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
        return Equals(obj as PolicyTestResult);
    }

    /// <summary>
    /// Returns true if PolicyTestResult instances are equal
    /// </summary>
    /// <param name="other">Instance of PolicyTestResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PolicyTestResult other)
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
                Result == other.Result ||
                Result != null &&
                Result.Equals(other.Result)
            ) &&
            (
                PolicyConditionResults == other.PolicyConditionResults ||
                PolicyConditionResults != null &&
                PolicyConditionResults.SequenceEqual(other.PolicyConditionResults)
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

            if (Result != null)
            {
                hash = hash * 59 + Result.GetHashCode();
            }

            if (PolicyConditionResults != null)
            {
                hash = hash * 59 + PolicyConditionResults.GetHashCode();
            }

            return hash;
        }
    }
}

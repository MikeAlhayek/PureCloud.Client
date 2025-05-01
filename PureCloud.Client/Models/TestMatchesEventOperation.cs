using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Results from evaluating matching criteria against test input
/// </summary>
[DataContract]
public partial class TestMatchesEventOperation : IEquatable<TestMatchesEventOperation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TestMatchesEventOperation" /> class.
    /// </summary>
    /// <param name="Name">The name of the processing step.</param>
    /// <param name="Step">The number of the processing step.</param>
    /// <param name="MatchedTriggers">Triggers that matched.</param>
    /// <param name="UnmatchedTriggers">Triggers that did not match.</param>
    public TestMatchesEventOperation(string Name = null, int? Step = null, List<TestModeTrigger> MatchedTriggers = null, List<TestModeTrigger> UnmatchedTriggers = null)
    {
        this.Name = Name;
        this.Step = Step;
        this.MatchedTriggers = MatchedTriggers;
        this.UnmatchedTriggers = UnmatchedTriggers;

    }



    /// <summary>
    /// The name of the processing step
    /// </summary>
    /// <value>The name of the processing step</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The number of the processing step
    /// </summary>
    /// <value>The number of the processing step</value>
    [DataMember(Name = "step", EmitDefaultValue = false)]
    public int? Step { get; set; }



    /// <summary>
    /// Triggers that matched
    /// </summary>
    /// <value>Triggers that matched</value>
    [DataMember(Name = "matchedTriggers", EmitDefaultValue = false)]
    public List<TestModeTrigger> MatchedTriggers { get; set; }



    /// <summary>
    /// Triggers that did not match
    /// </summary>
    /// <value>Triggers that did not match</value>
    [DataMember(Name = "unmatchedTriggers", EmitDefaultValue = false)]
    public List<TestModeTrigger> UnmatchedTriggers { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TestMatchesEventOperation {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Step: ").Append(Step).Append("\n");
        sb.Append("  MatchedTriggers: ").Append(MatchedTriggers).Append("\n");
        sb.Append("  UnmatchedTriggers: ").Append(UnmatchedTriggers).Append("\n");
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
        return Equals(obj as TestMatchesEventOperation);
    }

    /// <summary>
    /// Returns true if TestMatchesEventOperation instances are equal
    /// </summary>
    /// <param name="other">Instance of TestMatchesEventOperation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TestMatchesEventOperation other)
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
                Step == other.Step ||
                Step != null &&
                Step.Equals(other.Step)
            ) &&
            (
                MatchedTriggers == other.MatchedTriggers ||
                MatchedTriggers != null &&
                MatchedTriggers.SequenceEqual(other.MatchedTriggers)
            ) &&
            (
                UnmatchedTriggers == other.UnmatchedTriggers ||
                UnmatchedTriggers != null &&
                UnmatchedTriggers.SequenceEqual(other.UnmatchedTriggers)
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

            if (Step != null)
            {
                hash = hash * 59 + Step.GetHashCode();
            }

            if (MatchedTriggers != null)
            {
                hash = hash * 59 + MatchedTriggers.GetHashCode();
            }

            if (UnmatchedTriggers != null)
            {
                hash = hash * 59 + UnmatchedTriggers.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Information about the Trigger test mode target validation step
/// </summary>
[DataContract]
public partial class TestTargetOperation : IEquatable<TestTargetOperation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TestTargetOperation" /> class.
    /// </summary>
    /// <param name="Name">The name of the processing step.</param>
    /// <param name="Step">The number of the processing step.</param>
    /// <param name="Matches">Whether or not the operation matches expectations.</param>
    /// <param name="Details">Details about why the operation did or did not succeed.</param>
    public TestTargetOperation(string Name = null, int? Step = null, bool? Matches = null, List<string> Details = null)
    {
        this.Name = Name;
        this.Step = Step;
        this.Matches = Matches;
        this.Details = Details;

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
    /// Whether or not the operation matches expectations
    /// </summary>
    /// <value>Whether or not the operation matches expectations</value>
    [DataMember(Name = "matches", EmitDefaultValue = false)]
    public bool? Matches { get; set; }



    /// <summary>
    /// Details about why the operation did or did not succeed
    /// </summary>
    /// <value>Details about why the operation did or did not succeed</value>
    [DataMember(Name = "details", EmitDefaultValue = false)]
    public List<string> Details { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TestTargetOperation {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Step: ").Append(Step).Append("\n");
        sb.Append("  Matches: ").Append(Matches).Append("\n");
        sb.Append("  Details: ").Append(Details).Append("\n");
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
        return Equals(obj as TestTargetOperation);
    }

    /// <summary>
    /// Returns true if TestTargetOperation instances are equal
    /// </summary>
    /// <param name="other">Instance of TestTargetOperation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TestTargetOperation other)
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
                Matches == other.Matches ||
                Matches != null &&
                Matches.Equals(other.Matches)
            ) &&
            (
                Details == other.Details ||
                Details != null &&
                Details.SequenceEqual(other.Details)
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

            if (Matches != null)
            {
                hash = hash * 59 + Matches.GetHashCode();
            }

            if (Details != null)
            {
                hash = hash * 59 + Details.GetHashCode();
            }

            return hash;
        }
    }
}

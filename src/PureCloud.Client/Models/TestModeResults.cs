using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Information about trigger test mode execution
/// </summary>

public partial class TestModeResults : IEquatable<TestModeResults>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TestModeResults" /> class.
    /// </summary>
    /// <param name="SchemaValidation">Information about the validation of the schema of the event body passed in to test mode.</param>
    /// <param name="TargetValidation">Information about the validation of the trigger target.</param>
    /// <param name="JsonPathValidation">Information about the json path matching criteria.</param>
    /// <param name="TriggerMatches">Whether the trigger would have matched on the provided event body.</param>
    public TestModeResults(TestSchemaOperation SchemaValidation = null, TestTargetOperation TargetValidation = null, TestMatchesOperation JsonPathValidation = null, bool? TriggerMatches = null)
    {
        this.SchemaValidation = SchemaValidation;
        this.TargetValidation = TargetValidation;
        this.JsonPathValidation = JsonPathValidation;
        this.TriggerMatches = TriggerMatches;

    }



    /// <summary>
    /// Information about the validation of the schema of the event body passed in to test mode
    /// </summary>
    /// <value>Information about the validation of the schema of the event body passed in to test mode</value>
    [JsonPropertyName("schemaValidation")]
    public TestSchemaOperation SchemaValidation { get; set; }



    /// <summary>
    /// Information about the validation of the trigger target
    /// </summary>
    /// <value>Information about the validation of the trigger target</value>
    [JsonPropertyName("targetValidation")]
    public TestTargetOperation TargetValidation { get; set; }



    /// <summary>
    /// Information about the json path matching criteria
    /// </summary>
    /// <value>Information about the json path matching criteria</value>
    [JsonPropertyName("jsonPathValidation")]
    public TestMatchesOperation JsonPathValidation { get; set; }



    /// <summary>
    /// Whether the trigger would have matched on the provided event body
    /// </summary>
    /// <value>Whether the trigger would have matched on the provided event body</value>
    [JsonPropertyName("triggerMatches")]
    public bool? TriggerMatches { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TestModeResults {\n");

        sb.Append("  SchemaValidation: ").Append(SchemaValidation).Append("\n");
        sb.Append("  TargetValidation: ").Append(TargetValidation).Append("\n");
        sb.Append("  JsonPathValidation: ").Append(JsonPathValidation).Append("\n");
        sb.Append("  TriggerMatches: ").Append(TriggerMatches).Append("\n");
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
        return Equals(obj as TestModeResults);
    }

    /// <summary>
    /// Returns true if TestModeResults instances are equal
    /// </summary>
    /// <param name="other">Instance of TestModeResults to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TestModeResults other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SchemaValidation == other.SchemaValidation ||
                SchemaValidation != null &&
                SchemaValidation.Equals(other.SchemaValidation)
            ) &&
            (
                TargetValidation == other.TargetValidation ||
                TargetValidation != null &&
                TargetValidation.Equals(other.TargetValidation)
            ) &&
            (
                JsonPathValidation == other.JsonPathValidation ||
                JsonPathValidation != null &&
                JsonPathValidation.Equals(other.JsonPathValidation)
            ) &&
            (
                TriggerMatches == other.TriggerMatches ||
                TriggerMatches != null &&
                TriggerMatches.Equals(other.TriggerMatches)
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
            if (SchemaValidation != null)
            {
                hash = hash * 59 + SchemaValidation.GetHashCode();
            }

            if (TargetValidation != null)
            {
                hash = hash * 59 + TargetValidation.GetHashCode();
            }

            if (JsonPathValidation != null)
            {
                hash = hash * 59 + JsonPathValidation.GetHashCode();
            }

            if (TriggerMatches != null)
            {
                hash = hash * 59 + TriggerMatches.GetHashCode();
            }

            return hash;
        }
    }
}

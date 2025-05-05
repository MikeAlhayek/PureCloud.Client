using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// IntentFeedback
/// </summary>

public partial class IntentFeedback : IEquatable<IntentFeedback>
{
    /// <summary>
    /// The assessment on the detection for feedback text.
    /// </summary>
    /// <value>The assessment on the detection for feedback text.</value>
    
    public enum AssessmentEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Incorrect for "Incorrect"
        /// </summary>
        [EnumMember(Value = "Incorrect")]
        Incorrect,

        /// <summary>
        /// Enum Correct for "Correct"
        /// </summary>
        [EnumMember(Value = "Correct")]
        Correct,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Disabled for "Disabled"
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled
    }
    /// <summary>
    /// The assessment on the detection for feedback text.
    /// </summary>
    /// <value>The assessment on the detection for feedback text.</value>
    [JsonPropertyName("assessment")]
    public AssessmentEnum? Assessment { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="IntentFeedback" /> class.
    /// </summary>
    /// <param name="Assessment">The assessment on the detection for feedback text..</param>
    public IntentFeedback(AssessmentEnum? Assessment = null)
    {
        this.Assessment = Assessment;

    }



    /// <summary>
    /// The name of the detected intent.
    /// </summary>
    /// <value>The name of the detected intent.</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }



    /// <summary>
    /// The probability of the detected intent.
    /// </summary>
    /// <value>The probability of the detected intent.</value>
    [JsonPropertyName("probability")]
    public double? Probability { get; private set; }



    /// <summary>
    /// The collection of named entities detected.
    /// </summary>
    /// <value>The collection of named entities detected.</value>
    [JsonPropertyName("entities")]
    public List<DetectedNamedEntity> Entities { get; private set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IntentFeedback {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Probability: ").Append(Probability).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  Assessment: ").Append(Assessment).Append("\n");
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
        return Equals(obj as IntentFeedback);
    }

    /// <summary>
    /// Returns true if IntentFeedback instances are equal
    /// </summary>
    /// <param name="other">Instance of IntentFeedback to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IntentFeedback other)
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
                Probability == other.Probability ||
                Probability != null &&
                Probability.Equals(other.Probability)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                Assessment == other.Assessment ||
                Assessment != null &&
                Assessment.Equals(other.Assessment)
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

            if (Probability != null)
            {
                hash = hash * 59 + Probability.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (Assessment != null)
            {
                hash = hash * 59 + Assessment.GetHashCode();
            }

            return hash;
        }
    }
}

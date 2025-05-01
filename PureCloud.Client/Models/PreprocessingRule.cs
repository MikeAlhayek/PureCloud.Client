using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// PreprocessingRule
/// </summary>
[DataContract]
public partial class PreprocessingRule : IEquatable<PreprocessingRule>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PreprocessingRule" /> class.
    /// </summary>
    /// <param name="Find">The regular expression to which file lines are to be matched..</param>
    /// <param name="ReplaceWith">The string to be substituted for each match..</param>
    /// <param name="Global">Replaces all matching substrings in every line..</param>
    /// <param name="IgnoreCase">Enables case-insensitive matching.</param>
    public PreprocessingRule(string Find = null, string ReplaceWith = null, bool? Global = null, bool? IgnoreCase = null)
    {
        this.Find = Find;
        this.ReplaceWith = ReplaceWith;
        this.Global = Global;
        this.IgnoreCase = IgnoreCase;

    }



    /// <summary>
    /// The regular expression to which file lines are to be matched.
    /// </summary>
    /// <value>The regular expression to which file lines are to be matched.</value>
    [DataMember(Name = "find", EmitDefaultValue = false)]
    public string Find { get; set; }



    /// <summary>
    /// The string to be substituted for each match.
    /// </summary>
    /// <value>The string to be substituted for each match.</value>
    [DataMember(Name = "replaceWith", EmitDefaultValue = false)]
    public string ReplaceWith { get; set; }



    /// <summary>
    /// Replaces all matching substrings in every line.
    /// </summary>
    /// <value>Replaces all matching substrings in every line.</value>
    [DataMember(Name = "global", EmitDefaultValue = false)]
    public bool? Global { get; set; }



    /// <summary>
    /// Enables case-insensitive matching
    /// </summary>
    /// <value>Enables case-insensitive matching</value>
    [DataMember(Name = "ignoreCase", EmitDefaultValue = false)]
    public bool? IgnoreCase { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PreprocessingRule {\n");

        sb.Append("  Find: ").Append(Find).Append("\n");
        sb.Append("  ReplaceWith: ").Append(ReplaceWith).Append("\n");
        sb.Append("  Global: ").Append(Global).Append("\n");
        sb.Append("  IgnoreCase: ").Append(IgnoreCase).Append("\n");
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
        return Equals(obj as PreprocessingRule);
    }

    /// <summary>
    /// Returns true if PreprocessingRule instances are equal
    /// </summary>
    /// <param name="other">Instance of PreprocessingRule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PreprocessingRule other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Find == other.Find ||
                Find != null &&
                Find.Equals(other.Find)
            ) &&
            (
                ReplaceWith == other.ReplaceWith ||
                ReplaceWith != null &&
                ReplaceWith.Equals(other.ReplaceWith)
            ) &&
            (
                Global == other.Global ||
                Global != null &&
                Global.Equals(other.Global)
            ) &&
            (
                IgnoreCase == other.IgnoreCase ||
                IgnoreCase != null &&
                IgnoreCase.Equals(other.IgnoreCase)
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
            if (Find != null)
            {
                hash = hash * 59 + Find.GetHashCode();
            }

            if (ReplaceWith != null)
            {
                hash = hash * 59 + ReplaceWith.GetHashCode();
            }

            if (Global != null)
            {
                hash = hash * 59 + Global.GetHashCode();
            }

            if (IgnoreCase != null)
            {
                hash = hash * 59 + IgnoreCase.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Describes a flow location.
/// </summary>
[DataContract]
public partial class TextBotFlowLocation : IEquatable<TextBotFlowLocation>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowLocation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotFlowLocation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowLocation" /> class.
    /// </summary>
    /// <param name="ActionName">The name of the action that was active when the event of interest happened. (required).</param>
    /// <param name="ActionNumber">The number of the action that was active when the event of interest happened. (required).</param>
    /// <param name="SequenceName">The name of the state or task which was active when the event of interest happened. (required).</param>
    public TextBotFlowLocation(string ActionName = null, int? ActionNumber = null, string SequenceName = null)
    {
        this.ActionName = ActionName;
        this.ActionNumber = ActionNumber;
        this.SequenceName = SequenceName;

    }



    /// <summary>
    /// The name of the action that was active when the event of interest happened.
    /// </summary>
    /// <value>The name of the action that was active when the event of interest happened.</value>
    [DataMember(Name = "actionName", EmitDefaultValue = false)]
    public string ActionName { get; set; }



    /// <summary>
    /// The number of the action that was active when the event of interest happened.
    /// </summary>
    /// <value>The number of the action that was active when the event of interest happened.</value>
    [DataMember(Name = "actionNumber", EmitDefaultValue = false)]
    public int? ActionNumber { get; set; }



    /// <summary>
    /// The name of the state or task which was active when the event of interest happened.
    /// </summary>
    /// <value>The name of the state or task which was active when the event of interest happened.</value>
    [DataMember(Name = "sequenceName", EmitDefaultValue = false)]
    public string SequenceName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotFlowLocation {\n");

        sb.Append("  ActionName: ").Append(ActionName).Append("\n");
        sb.Append("  ActionNumber: ").Append(ActionNumber).Append("\n");
        sb.Append("  SequenceName: ").Append(SequenceName).Append("\n");
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
        return Equals(obj as TextBotFlowLocation);
    }

    /// <summary>
    /// Returns true if TextBotFlowLocation instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotFlowLocation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotFlowLocation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActionName == other.ActionName ||
                ActionName != null &&
                ActionName.Equals(other.ActionName)
            ) &&
            (
                ActionNumber == other.ActionNumber ||
                ActionNumber != null &&
                ActionNumber.Equals(other.ActionNumber)
            ) &&
            (
                SequenceName == other.SequenceName ||
                SequenceName != null &&
                SequenceName.Equals(other.SequenceName)
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
            if (ActionName != null)
            {
                hash = hash * 59 + ActionName.GetHashCode();
            }

            if (ActionNumber != null)
            {
                hash = hash * 59 + ActionNumber.GetHashCode();
            }

            if (SequenceName != null)
            {
                hash = hash * 59 + SequenceName.GetHashCode();
            }

            return hash;
        }
    }
}

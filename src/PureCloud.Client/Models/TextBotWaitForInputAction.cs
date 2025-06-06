using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings for a next-action of waiting for additional user input and sending the data as an input action to the bot flow.
/// </summary>

public partial class TextBotWaitForInputAction : IEquatable<TextBotWaitForInputAction>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotWaitForInputAction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotWaitForInputAction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotWaitForInputAction" /> class.
    /// </summary>
    /// <param name="ModeConstraints">The mode constraints for the user input. (required).</param>
    public TextBotWaitForInputAction(TextBotModeConstraints ModeConstraints = null)
    {
        this.ModeConstraints = ModeConstraints;

    }



    /// <summary>
    /// The mode constraints for the user input.
    /// </summary>
    /// <value>The mode constraints for the user input.</value>
    [JsonPropertyName("modeConstraints")]
    public TextBotModeConstraints ModeConstraints { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotWaitForInputAction {\n");

        sb.Append("  ModeConstraints: ").Append(ModeConstraints).Append("\n");
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
        return Equals(obj as TextBotWaitForInputAction);
    }

    /// <summary>
    /// Returns true if TextBotWaitForInputAction instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotWaitForInputAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotWaitForInputAction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ModeConstraints == other.ModeConstraints ||
                ModeConstraints != null &&
                ModeConstraints.Equals(other.ModeConstraints)
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
            if (ModeConstraints != null)
            {
                hash = hash * 59 + ModeConstraints.GetHashCode();
            }

            return hash;
        }
    }
}

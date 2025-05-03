using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Contract definition.
/// </summary>

public partial class ActionContractInput : IEquatable<ActionContractInput>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ActionContractInput" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ActionContractInput() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActionContractInput" /> class.
    /// </summary>
    /// <param name="Input">Execution input contract (required).</param>
    /// <param name="Output">Execution output contract (required).</param>
    public ActionContractInput(PostInputContract Input = null, PostOutputContract Output = null)
    {
        this.Input = Input;
        this.Output = Output;

    }



    /// <summary>
    /// Execution input contract
    /// </summary>
    /// <value>Execution input contract</value>
    [JsonPropertyName("input")]
    public PostInputContract Input { get; set; }



    /// <summary>
    /// Execution output contract
    /// </summary>
    /// <value>Execution output contract</value>
    [JsonPropertyName("output")]
    public PostOutputContract Output { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActionContractInput {\n");

        sb.Append("  Input: ").Append(Input).Append("\n");
        sb.Append("  Output: ").Append(Output).Append("\n");
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
        return Equals(obj as ActionContractInput);
    }

    /// <summary>
    /// Returns true if ActionContractInput instances are equal
    /// </summary>
    /// <param name="other">Instance of ActionContractInput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActionContractInput other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Input == other.Input ||
                Input != null &&
                Input.Equals(other.Input)
            ) &&
            (
                Output == other.Output ||
                Output != null &&
                Output.Equals(other.Output)
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
            if (Input != null)
            {
                hash = hash * 59 + Input.GetHashCode();
            }

            if (Output != null)
            {
                hash = hash * 59 + Output.GetHashCode();
            }

            return hash;
        }
    }
}

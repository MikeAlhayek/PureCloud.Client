using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDetectionRequest
/// </summary>

public partial class NluDetectionRequest : IEquatable<NluDetectionRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluDetectionRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluDetectionRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDetectionRequest" /> class.
    /// </summary>
    /// <param name="Input">The input subject to NLU detection. (required).</param>
    /// <param name="Context">The context for the input to NLU detection..</param>
    public NluDetectionRequest(NluDetectionInput Input = null, NluDetectionContext Context = null)
    {
        this.Input = Input;
        this.Context = Context;

    }



    /// <summary>
    /// The input subject to NLU detection.
    /// </summary>
    /// <value>The input subject to NLU detection.</value>
    [JsonPropertyName("input")]
    public NluDetectionInput Input { get; set; }



    /// <summary>
    /// The context for the input to NLU detection.
    /// </summary>
    /// <value>The context for the input to NLU detection.</value>
    [JsonPropertyName("context")]
    public NluDetectionContext Context { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluDetectionRequest {\n");

        sb.Append("  Input: ").Append(Input).Append("\n");
        sb.Append("  Context: ").Append(Context).Append("\n");
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
        return Equals(obj as NluDetectionRequest);
    }

    /// <summary>
    /// Returns true if NluDetectionRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDetectionRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluDetectionRequest other)
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
                Context == other.Context ||
                Context != null &&
                Context.Equals(other.Context)
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

            if (Context != null)
            {
                hash = hash * 59 + Context.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Identity of a CX infrastructure as code accelerator to be run and its inputs
/// </summary>
public partial class AcceleratorInput : IEquatable<AcceleratorInput>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AcceleratorInput" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AcceleratorInput() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AcceleratorInput" /> class.
    /// </summary>
    /// <param name="dryRun">Set this true to test the job without making any changes. Defaults to false..</param>
    /// <param name="acceleratorId">Accelerator ID (required).</param>
    /// <param name="parameters">Parameters required for this accelerator.</param>
    public AcceleratorInput(bool? dryRun = null, string acceleratorId = null, List<AcceleratorParameter> parameters = null)
    {
        this.DryRun = dryRun;
        this.AcceleratorId = acceleratorId;
        this.Parameters = parameters;
    }

    /// <summary>
    /// Set this true to test the job without making any changes. Defaults to false.
    /// </summary>
    public bool? DryRun { get; set; }

    /// <summary>
    /// Accelerator ID
    /// </summary>
    public string AcceleratorId { get; set; }

    /// <summary>
    /// Parameters required for this accelerator
    /// </summary>
    public List<AcceleratorParameter> Parameters { get; set; }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as AcceleratorInput);
    }

    /// <summary>
    /// Returns true if AcceleratorInput instances are equal
    /// </summary>
    /// <param name="other">Instance of AcceleratorInput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AcceleratorInput other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DryRun == other.DryRun ||
                DryRun != null &&
                DryRun.Equals(other.DryRun)
            ) &&
            (
                AcceleratorId == other.AcceleratorId ||
                AcceleratorId != null &&
                AcceleratorId.Equals(other.AcceleratorId)
            ) &&
            (
                Parameters == other.Parameters ||
                Parameters != null &&
                Parameters.SequenceEqual(other.Parameters)
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
            if (DryRun != null)
            {
                hash = hash * 59 + DryRun.GetHashCode();
            }

            if (AcceleratorId != null)
            {
                hash = hash * 59 + AcceleratorId.GetHashCode();
            }

            if (Parameters != null)
            {
                hash = hash * 59 + Parameters.GetHashCode();
            }

            return hash;
        }
    }
}

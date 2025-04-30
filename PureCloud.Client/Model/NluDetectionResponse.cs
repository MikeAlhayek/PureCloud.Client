using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// NluDetectionResponse
/// </summary>
[DataContract]
public partial class NluDetectionResponse : IEquatable<NluDetectionResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDetectionResponse" /> class.
    /// </summary>
    /// <param name="Output">Output.</param>
    /// <param name="Input">Input.</param>
    public NluDetectionResponse(NluDetectionOutput Output = null, NluDetectionInput Input = null)
    {
        this.Output = Output;
        this.Input = Input;

    }



    /// <summary>
    /// The NLU domain version which performed the detection.
    /// </summary>
    /// <value>The NLU domain version which performed the detection.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public NluDomainVersion Version { get; private set; }



    /// <summary>
    /// Gets or Sets Output
    /// </summary>
    [DataMember(Name = "output", EmitDefaultValue = false)]
    public NluDetectionOutput Output { get; set; }



    /// <summary>
    /// Gets or Sets Input
    /// </summary>
    [DataMember(Name = "input", EmitDefaultValue = false)]
    public NluDetectionInput Input { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluDetectionResponse {\n");

        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Output: ").Append(Output).Append("\n");
        sb.Append("  Input: ").Append(Input).Append("\n");
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
        return this.Equals(obj as NluDetectionResponse);
    }

    /// <summary>
    /// Returns true if NluDetectionResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDetectionResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluDetectionResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Version == other.Version ||
                this.Version != null &&
                this.Version.Equals(other.Version)
            ) &&
            (
                this.Output == other.Output ||
                this.Output != null &&
                this.Output.Equals(other.Output)
            ) &&
            (
                this.Input == other.Input ||
                this.Input != null &&
                this.Input.Equals(other.Input)
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
            if (this.Version != null)
            {
                hash = hash * 59 + this.Version.GetHashCode();
            }

            if (this.Output != null)
            {
                hash = hash * 59 + this.Output.GetHashCode();
            }

            if (this.Input != null)
            {
                hash = hash * 59 + this.Input.GetHashCode();
            }

            return hash;
        }
    }
}

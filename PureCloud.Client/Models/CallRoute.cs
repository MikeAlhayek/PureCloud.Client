using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallRoute
/// </summary>
[DataContract]
public partial class CallRoute : IEquatable<CallRoute>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CallRoute" /> class.
    /// </summary>
    /// <param name="Targets">A list of CallTargets to be called when the CallRoute is executed.</param>
    public CallRoute(List<CallTarget> Targets = null)
    {
        this.Targets = Targets;

    }



    /// <summary>
    /// A list of CallTargets to be called when the CallRoute is executed
    /// </summary>
    /// <value>A list of CallTargets to be called when the CallRoute is executed</value>
    [DataMember(Name = "targets", EmitDefaultValue = false)]
    public List<CallTarget> Targets { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallRoute {\n");

        sb.Append("  Targets: ").Append(Targets).Append("\n");
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
        return Equals(obj as CallRoute);
    }

    /// <summary>
    /// Returns true if CallRoute instances are equal
    /// </summary>
    /// <param name="other">Instance of CallRoute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallRoute other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Targets == other.Targets ||
                Targets != null &&
                Targets.SequenceEqual(other.Targets)
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
            if (Targets != null)
            {
                hash = hash * 59 + Targets.GetHashCode();
            }

            return hash;
        }
    }
}

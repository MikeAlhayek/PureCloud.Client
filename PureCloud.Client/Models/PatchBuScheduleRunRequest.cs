using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchBuScheduleRunRequest
/// </summary>
[DataContract]
public partial class PatchBuScheduleRunRequest : IEquatable<PatchBuScheduleRunRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchBuScheduleRunRequest" /> class.
    /// </summary>
    /// <param name="ReschedulingOptions">The rescheduling options to update.</param>
    public PatchBuScheduleRunRequest(PatchBuReschedulingOptionsRequest ReschedulingOptions = null)
    {
        this.ReschedulingOptions = ReschedulingOptions;

    }



    /// <summary>
    /// The rescheduling options to update
    /// </summary>
    /// <value>The rescheduling options to update</value>
    [DataMember(Name = "reschedulingOptions", EmitDefaultValue = false)]
    public PatchBuReschedulingOptionsRequest ReschedulingOptions { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchBuScheduleRunRequest {\n");

        sb.Append("  ReschedulingOptions: ").Append(ReschedulingOptions).Append("\n");
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
        return Equals(obj as PatchBuScheduleRunRequest);
    }

    /// <summary>
    /// Returns true if PatchBuScheduleRunRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchBuScheduleRunRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchBuScheduleRunRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ReschedulingOptions == other.ReschedulingOptions ||
                ReschedulingOptions != null &&
                ReschedulingOptions.Equals(other.ReschedulingOptions)
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
            if (ReschedulingOptions != null)
            {
                hash = hash * 59 + ReschedulingOptions.GetHashCode();
            }

            return hash;
        }
    }
}

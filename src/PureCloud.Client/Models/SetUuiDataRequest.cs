using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SetUuiDataRequest
/// </summary>

public partial class SetUuiDataRequest : IEquatable<SetUuiDataRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SetUuiDataRequest" /> class.
    /// </summary>
    /// <param name="UuiData">The value of the uuiData to set..</param>
    public SetUuiDataRequest(string UuiData = null)
    {
        this.UuiData = UuiData;

    }



    /// <summary>
    /// The value of the uuiData to set.
    /// </summary>
    /// <value>The value of the uuiData to set.</value>
    [JsonPropertyName("uuiData")]
    public string UuiData { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SetUuiDataRequest {\n");

        sb.Append("  UuiData: ").Append(UuiData).Append("\n");
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
        return Equals(obj as SetUuiDataRequest);
    }

    /// <summary>
    /// Returns true if SetUuiDataRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of SetUuiDataRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SetUuiDataRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UuiData == other.UuiData ||
                UuiData != null &&
                UuiData.Equals(other.UuiData)
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
            if (UuiData != null)
            {
                hash = hash * 59 + UuiData.GetHashCode();
            }

            return hash;
        }
    }
}

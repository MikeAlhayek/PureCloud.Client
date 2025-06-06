using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PredictorModels
/// </summary>

public partial class PredictorModels : IEquatable<PredictorModels>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PredictorModels" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    /// <param name="_PredictorModels">_PredictorModels.</param>
    public PredictorModels(List<PredictorModel> Entities = null, List<PredictorModel> _PredictorModels = null)
    {
        this.Entities = Entities;
        this._PredictorModels = _PredictorModels;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<PredictorModel> Entities { get; set; }



    /// <summary>
    /// Gets or Sets _PredictorModels
    /// </summary>
    [JsonPropertyName("predictorModels")]
    public List<PredictorModel> _PredictorModels { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PredictorModels {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
        sb.Append("  _PredictorModels: ").Append(_PredictorModels).Append("\n");
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
        return Equals(obj as PredictorModels);
    }

    /// <summary>
    /// Returns true if PredictorModels instances are equal
    /// </summary>
    /// <param name="other">Instance of PredictorModels to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PredictorModels other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
            ) &&
            (
                _PredictorModels == other._PredictorModels ||
                _PredictorModels != null &&
                _PredictorModels.SequenceEqual(other._PredictorModels)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (_PredictorModels != null)
            {
                hash = hash * 59 + _PredictorModels.GetHashCode();
            }

            return hash;
        }
    }
}

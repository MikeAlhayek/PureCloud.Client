using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SessionMetricData
/// </summary>

public partial class SessionMetricData : IEquatable<SessionMetricData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SessionMetricData" /> class.
    /// </summary>
    /// <param name="Model">Model to be used for internal evaluation purposes.</param>
    /// <param name="Computed">Forecasted data for the requested session.</param>
    /// <param name="Historical">Historical data for the requested session.</param>
    /// <param name="ModelMetaData">Contains forecast meta data.</param>
    public SessionMetricData(ModelData Model = null, ComputedData Computed = null, HistoricalData Historical = null, ModelMetaData ModelMetaData = null)
    {
        this.Model = Model;
        this.Computed = Computed;
        this.Historical = Historical;
        this.ModelMetaData = ModelMetaData;

    }



    /// <summary>
    /// Model to be used for internal evaluation purposes
    /// </summary>
    /// <value>Model to be used for internal evaluation purposes</value>
    [JsonPropertyName("model")]
    public ModelData Model { get; set; }



    /// <summary>
    /// Forecasted data for the requested session
    /// </summary>
    /// <value>Forecasted data for the requested session</value>
    [JsonPropertyName("computed")]
    public ComputedData Computed { get; set; }



    /// <summary>
    /// Historical data for the requested session
    /// </summary>
    /// <value>Historical data for the requested session</value>
    [JsonPropertyName("historical")]
    public HistoricalData Historical { get; set; }



    /// <summary>
    /// Contains forecast meta data
    /// </summary>
    /// <value>Contains forecast meta data</value>
    [JsonPropertyName("modelMetaData")]
    public ModelMetaData ModelMetaData { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SessionMetricData {\n");

        sb.Append("  Model: ").Append(Model).Append("\n");
        sb.Append("  Computed: ").Append(Computed).Append("\n");
        sb.Append("  Historical: ").Append(Historical).Append("\n");
        sb.Append("  ModelMetaData: ").Append(ModelMetaData).Append("\n");
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
        return Equals(obj as SessionMetricData);
    }

    /// <summary>
    /// Returns true if SessionMetricData instances are equal
    /// </summary>
    /// <param name="other">Instance of SessionMetricData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SessionMetricData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Model == other.Model ||
                Model != null &&
                Model.Equals(other.Model)
            ) &&
            (
                Computed == other.Computed ||
                Computed != null &&
                Computed.Equals(other.Computed)
            ) &&
            (
                Historical == other.Historical ||
                Historical != null &&
                Historical.Equals(other.Historical)
            ) &&
            (
                ModelMetaData == other.ModelMetaData ||
                ModelMetaData != null &&
                ModelMetaData.Equals(other.ModelMetaData)
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
            if (Model != null)
            {
                hash = hash * 59 + Model.GetHashCode();
            }

            if (Computed != null)
            {
                hash = hash * 59 + Computed.GetHashCode();
            }

            if (Historical != null)
            {
                hash = hash * 59 + Historical.GetHashCode();
            }

            if (ModelMetaData != null)
            {
                hash = hash * 59 + ModelMetaData.GetHashCode();
            }

            return hash;
        }
    }
}

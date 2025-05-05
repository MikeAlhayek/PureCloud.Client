using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Disposition
/// </summary>

public partial class Disposition : IEquatable<Disposition>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Disposition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Disposition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Disposition" /> class.
    /// </summary>
    /// <param name="Name">Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table.. (required).</param>
    /// <param name="Analyzer">The final media analyzer result that triggered the disposition result, if any..</param>
    /// <param name="DispositionParameters">Contains various parameters related to call analysis..</param>
    /// <param name="DetectedSpeechStart">Absolute time when the speech started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DetectedSpeechEnd">Absolute time when the speech ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public Disposition(string Name = null, string Analyzer = null, DispositionParameters DispositionParameters = null, DateTime? DetectedSpeechStart = null, DateTime? DetectedSpeechEnd = null)
    {
        this.Name = Name;
        this.Analyzer = Analyzer;
        this.DispositionParameters = DispositionParameters;
        this.DetectedSpeechStart = DetectedSpeechStart;
        this.DetectedSpeechEnd = DetectedSpeechEnd;

    }



    /// <summary>
    /// Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table..
    /// </summary>
    /// <value>Name of the disposition. Either a platform predefined value, or the name of the disposition in the disposition table..</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The final media analyzer result that triggered the disposition result, if any.
    /// </summary>
    /// <value>The final media analyzer result that triggered the disposition result, if any.</value>
    [JsonPropertyName("analyzer")]
    public string Analyzer { get; set; }



    /// <summary>
    /// Contains various parameters related to call analysis.
    /// </summary>
    /// <value>Contains various parameters related to call analysis.</value>
    [JsonPropertyName("dispositionParameters")]
    public DispositionParameters DispositionParameters { get; set; }



    /// <summary>
    /// Absolute time when the speech started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Absolute time when the speech started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("detectedSpeechStart")]
    public DateTime? DetectedSpeechStart { get; set; }



    /// <summary>
    /// Absolute time when the speech ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Absolute time when the speech ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("detectedSpeechEnd")]
    public DateTime? DetectedSpeechEnd { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Disposition {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Analyzer: ").Append(Analyzer).Append("\n");
        sb.Append("  DispositionParameters: ").Append(DispositionParameters).Append("\n");
        sb.Append("  DetectedSpeechStart: ").Append(DetectedSpeechStart).Append("\n");
        sb.Append("  DetectedSpeechEnd: ").Append(DetectedSpeechEnd).Append("\n");
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
        return Equals(obj as Disposition);
    }

    /// <summary>
    /// Returns true if Disposition instances are equal
    /// </summary>
    /// <param name="other">Instance of Disposition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Disposition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Analyzer == other.Analyzer ||
                Analyzer != null &&
                Analyzer.Equals(other.Analyzer)
            ) &&
            (
                DispositionParameters == other.DispositionParameters ||
                DispositionParameters != null &&
                DispositionParameters.Equals(other.DispositionParameters)
            ) &&
            (
                DetectedSpeechStart == other.DetectedSpeechStart ||
                DetectedSpeechStart != null &&
                DetectedSpeechStart.Equals(other.DetectedSpeechStart)
            ) &&
            (
                DetectedSpeechEnd == other.DetectedSpeechEnd ||
                DetectedSpeechEnd != null &&
                DetectedSpeechEnd.Equals(other.DetectedSpeechEnd)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Analyzer != null)
            {
                hash = hash * 59 + Analyzer.GetHashCode();
            }

            if (DispositionParameters != null)
            {
                hash = hash * 59 + DispositionParameters.GetHashCode();
            }

            if (DetectedSpeechStart != null)
            {
                hash = hash * 59 + DetectedSpeechStart.GetHashCode();
            }

            if (DetectedSpeechEnd != null)
            {
                hash = hash * 59 + DetectedSpeechEnd.GetHashCode();
            }

            return hash;
        }
    }
}

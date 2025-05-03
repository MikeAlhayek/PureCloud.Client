using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TranscriptionEnginesRequest
/// </summary>

public partial class TranscriptionEnginesRequest : IEquatable<TranscriptionEnginesRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptionEnginesRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TranscriptionEnginesRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptionEnginesRequest" /> class.
    /// </summary>
    /// <param name="TranscriptionEngines">The transcription engine setting (required).</param>
    public TranscriptionEnginesRequest(List<ProgramTranscriptionEngine> TranscriptionEngines = null)
    {
        this.TranscriptionEngines = TranscriptionEngines;

    }



    /// <summary>
    /// The transcription engine setting
    /// </summary>
    /// <value>The transcription engine setting</value>
    [JsonPropertyName("transcriptionEngines")]
    public List<ProgramTranscriptionEngine> TranscriptionEngines { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TranscriptionEnginesRequest {\n");

        sb.Append("  TranscriptionEngines: ").Append(TranscriptionEngines).Append("\n");
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
        return Equals(obj as TranscriptionEnginesRequest);
    }

    /// <summary>
    /// Returns true if TranscriptionEnginesRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TranscriptionEnginesRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TranscriptionEnginesRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TranscriptionEngines == other.TranscriptionEngines ||
                TranscriptionEngines != null &&
                TranscriptionEngines.SequenceEqual(other.TranscriptionEngines)
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
            if (TranscriptionEngines != null)
            {
                hash = hash * 59 + TranscriptionEngines.GetHashCode();
            }

            return hash;
        }
    }
}

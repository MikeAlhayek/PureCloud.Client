using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaIceStatistics
/// </summary>

public partial class MediaIceStatistics : IEquatable<MediaIceStatistics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaIceStatistics" /> class.
    /// </summary>
    /// <param name="SelectedPairs">The candidate pairs selected for the media stream.</param>
    public MediaIceStatistics(List<MediaIceSelectedPair> SelectedPairs = null)
    {
        this.SelectedPairs = SelectedPairs;

    }



    /// <summary>
    /// The candidate pairs selected for the media stream
    /// </summary>
    /// <value>The candidate pairs selected for the media stream</value>
    [JsonPropertyName("selectedPairs")]
    public List<MediaIceSelectedPair> SelectedPairs { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaIceStatistics {\n");

        sb.Append("  SelectedPairs: ").Append(SelectedPairs).Append("\n");
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
        return Equals(obj as MediaIceStatistics);
    }

    /// <summary>
    /// Returns true if MediaIceStatistics instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaIceStatistics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaIceStatistics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SelectedPairs == other.SelectedPairs ||
                SelectedPairs != null &&
                SelectedPairs.SequenceEqual(other.SelectedPairs)
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
            if (SelectedPairs != null)
            {
                hash = hash * 59 + SelectedPairs.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluUtterance
/// </summary>

public partial class NluUtterance : IEquatable<NluUtterance>
{
    /// <summary>
    /// The source of the utterance.
    /// </summary>
    /// <value>The source of the utterance.</value>
    
    public enum SourceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Generated for "Generated"
        /// </summary>
        [EnumMember(Value = "Generated")]
        Generated,

        /// <summary>
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User
    }
    /// <summary>
    /// The source of the utterance.
    /// </summary>
    /// <value>The source of the utterance.</value>
    [JsonPropertyName("source")]
    public SourceEnum? Source { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NluUtterance" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluUtterance() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluUtterance" /> class.
    /// </summary>
    /// <param name="Source">The source of the utterance..</param>
    /// <param name="Segments">The list of segments that that constitute this utterance for the given intent. (required).</param>
    public NluUtterance(SourceEnum? Source = null, List<NluUtteranceSegment> Segments = null)
    {
        this.Source = Source;
        this.Segments = Segments;

    }



    /// <summary>
    /// ID of the utterance.
    /// </summary>
    /// <value>ID of the utterance.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// The list of segments that that constitute this utterance for the given intent.
    /// </summary>
    /// <value>The list of segments that that constitute this utterance for the given intent.</value>
    [JsonPropertyName("segments")]
    public List<NluUtteranceSegment> Segments { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluUtterance {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  Segments: ").Append(Segments).Append("\n");
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
        return Equals(obj as NluUtterance);
    }

    /// <summary>
    /// Returns true if NluUtterance instances are equal
    /// </summary>
    /// <param name="other">Instance of NluUtterance to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluUtterance other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                Segments == other.Segments ||
                Segments != null &&
                Segments.SequenceEqual(other.Segments)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (Segments != null)
            {
                hash = hash * 59 + Segments.GetHashCode();
            }

            return hash;
        }
    }
}

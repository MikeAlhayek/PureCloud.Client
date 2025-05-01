using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// GreetingAudioFile
/// </summary>
[DataContract]
public partial class GreetingAudioFile : IEquatable<GreetingAudioFile>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GreetingAudioFile" /> class.
    /// </summary>
    /// <param name="DurationMilliseconds">DurationMilliseconds.</param>
    /// <param name="SizeBytes">SizeBytes.</param>
    /// <param name="SelfUri">SelfUri.</param>
    public GreetingAudioFile(long? DurationMilliseconds = null, long? SizeBytes = null, string SelfUri = null)
    {
        this.DurationMilliseconds = DurationMilliseconds;
        this.SizeBytes = SizeBytes;
        this.SelfUri = SelfUri;

    }



    /// <summary>
    /// Gets or Sets DurationMilliseconds
    /// </summary>
    [DataMember(Name = "durationMilliseconds", EmitDefaultValue = false)]
    public long? DurationMilliseconds { get; set; }



    /// <summary>
    /// Gets or Sets SizeBytes
    /// </summary>
    [DataMember(Name = "sizeBytes", EmitDefaultValue = false)]
    public long? SizeBytes { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GreetingAudioFile {\n");

        sb.Append("  DurationMilliseconds: ").Append(DurationMilliseconds).Append("\n");
        sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as GreetingAudioFile);
    }

    /// <summary>
    /// Returns true if GreetingAudioFile instances are equal
    /// </summary>
    /// <param name="other">Instance of GreetingAudioFile to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GreetingAudioFile other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DurationMilliseconds == other.DurationMilliseconds ||
                DurationMilliseconds != null &&
                DurationMilliseconds.Equals(other.DurationMilliseconds)
            ) &&
            (
                SizeBytes == other.SizeBytes ||
                SizeBytes != null &&
                SizeBytes.Equals(other.SizeBytes)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (DurationMilliseconds != null)
            {
                hash = hash * 59 + DurationMilliseconds.GetHashCode();
            }

            if (SizeBytes != null)
            {
                hash = hash * 59 + SizeBytes.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

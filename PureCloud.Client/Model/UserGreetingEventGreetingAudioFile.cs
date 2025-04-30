using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// UserGreetingEventGreetingAudioFile
/// </summary>
[DataContract]
public partial class UserGreetingEventGreetingAudioFile : IEquatable<UserGreetingEventGreetingAudioFile>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserGreetingEventGreetingAudioFile" /> class.
    /// </summary>
    /// <param name="DurationMilliseconds">DurationMilliseconds.</param>
    /// <param name="SizeBytes">SizeBytes.</param>
    public UserGreetingEventGreetingAudioFile(long? DurationMilliseconds = null, long? SizeBytes = null)
    {
        this.DurationMilliseconds = DurationMilliseconds;
        this.SizeBytes = SizeBytes;

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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserGreetingEventGreetingAudioFile {\n");

        sb.Append("  DurationMilliseconds: ").Append(DurationMilliseconds).Append("\n");
        sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
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
        return this.Equals(obj as UserGreetingEventGreetingAudioFile);
    }

    /// <summary>
    /// Returns true if UserGreetingEventGreetingAudioFile instances are equal
    /// </summary>
    /// <param name="other">Instance of UserGreetingEventGreetingAudioFile to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserGreetingEventGreetingAudioFile other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.DurationMilliseconds == other.DurationMilliseconds ||
                this.DurationMilliseconds != null &&
                this.DurationMilliseconds.Equals(other.DurationMilliseconds)
            ) &&
            (
                this.SizeBytes == other.SizeBytes ||
                this.SizeBytes != null &&
                this.SizeBytes.Equals(other.SizeBytes)
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
            if (this.DurationMilliseconds != null)
            {
                hash = hash * 59 + this.DurationMilliseconds.GetHashCode();
            }

            if (this.SizeBytes != null)
            {
                hash = hash * 59 + this.SizeBytes.GetHashCode();
            }

            return hash;
        }
    }
}

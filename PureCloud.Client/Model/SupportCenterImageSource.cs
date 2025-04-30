using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// SupportCenterImageSource
/// </summary>
[DataContract]
public partial class SupportCenterImageSource : IEquatable<SupportCenterImageSource>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterImageSource" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SupportCenterImageSource() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SupportCenterImageSource" /> class.
    /// </summary>
    /// <param name="DefaultUrl">Default URL for image (required).</param>
    public SupportCenterImageSource(string DefaultUrl = null)
    {
        this.DefaultUrl = DefaultUrl;

    }



    /// <summary>
    /// Default URL for image
    /// </summary>
    /// <value>Default URL for image</value>
    [DataMember(Name = "defaultUrl", EmitDefaultValue = false)]
    public string DefaultUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SupportCenterImageSource {\n");

        sb.Append("  DefaultUrl: ").Append(DefaultUrl).Append("\n");
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
        return this.Equals(obj as SupportCenterImageSource);
    }

    /// <summary>
    /// Returns true if SupportCenterImageSource instances are equal
    /// </summary>
    /// <param name="other">Instance of SupportCenterImageSource to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SupportCenterImageSource other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.DefaultUrl == other.DefaultUrl ||
                this.DefaultUrl != null &&
                this.DefaultUrl.Equals(other.DefaultUrl)
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
            if (this.DefaultUrl != null)
            {
                hash = hash * 59 + this.DefaultUrl.GetHashCode();
            }

            return hash;
        }
    }
}

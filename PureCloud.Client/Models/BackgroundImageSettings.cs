using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The settings to Agent Video background image
/// </summary>
[DataContract]
public partial class BackgroundImageSettings : IEquatable<BackgroundImageSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BackgroundImageSettings" /> class.
    /// </summary>
    /// <param name="Url">BackgroundImage URL for agent video settings.</param>
    public BackgroundImageSettings(string Url = null)
    {
        this.Url = Url;

    }



    /// <summary>
    /// BackgroundImage URL for agent video settings
    /// </summary>
    /// <value>BackgroundImage URL for agent video settings</value>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BackgroundImageSettings {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
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
        return Equals(obj as BackgroundImageSettings);
    }

    /// <summary>
    /// Returns true if BackgroundImageSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of BackgroundImageSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BackgroundImageSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
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
            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            return hash;
        }
    }
}

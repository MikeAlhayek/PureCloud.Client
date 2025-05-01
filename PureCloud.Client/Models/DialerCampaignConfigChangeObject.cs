using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerCampaignConfigChangeObject
/// </summary>
[DataContract]
public partial class DialerCampaignConfigChangeObject : IEquatable<DialerCampaignConfigChangeObject>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerCampaignConfigChangeObject" /> class.
    /// </summary>
    public DialerCampaignConfigChangeObject()
    {

    }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerCampaignConfigChangeObject {\n");

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
        return this.Equals(obj as DialerCampaignConfigChangeObject);
    }

    /// <summary>
    /// Returns true if DialerCampaignConfigChangeObject instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerCampaignConfigChangeObject to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerCampaignConfigChangeObject other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true && false;
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
            return hash;
        }
    }
}

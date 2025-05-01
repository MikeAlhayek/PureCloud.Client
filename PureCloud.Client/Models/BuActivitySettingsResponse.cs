using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuActivitySettingsResponse
/// </summary>
[DataContract]
public partial class BuActivitySettingsResponse : IEquatable<BuActivitySettingsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BuActivitySettingsResponse" /> class.
    /// </summary>
    /// <param name="DefaultActivityCode">Default Activity Code settings.</param>
    public BuActivitySettingsResponse(ActivityCodeReference DefaultActivityCode = null)
    {
        this.DefaultActivityCode = DefaultActivityCode;

    }



    /// <summary>
    /// Default Activity Code settings
    /// </summary>
    /// <value>Default Activity Code settings</value>
    [DataMember(Name = "defaultActivityCode", EmitDefaultValue = false)]
    public ActivityCodeReference DefaultActivityCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuActivitySettingsResponse {\n");

        sb.Append("  DefaultActivityCode: ").Append(DefaultActivityCode).Append("\n");
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
        return Equals(obj as BuActivitySettingsResponse);
    }

    /// <summary>
    /// Returns true if BuActivitySettingsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuActivitySettingsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuActivitySettingsResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DefaultActivityCode == other.DefaultActivityCode ||
                DefaultActivityCode != null &&
                DefaultActivityCode.Equals(other.DefaultActivityCode)
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
            if (DefaultActivityCode != null)
            {
                hash = hash * 59 + DefaultActivityCode.GetHashCode();
            }

            return hash;
        }
    }
}

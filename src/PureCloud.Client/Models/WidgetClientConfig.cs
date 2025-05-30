using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WidgetClientConfig
/// </summary>

public partial class WidgetClientConfig : IEquatable<WidgetClientConfig>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WidgetClientConfig" /> class.
    /// </summary>
    /// <param name="V1">V1.</param>
    /// <param name="V2">V2.</param>
    /// <param name="V1Http">V1Http.</param>
    /// <param name="ThirdParty">ThirdParty.</param>
    public WidgetClientConfig(WidgetClientConfigV1 V1 = null, object V2 = null, WidgetClientConfigV1Http V1Http = null, object ThirdParty = null)
    {
        this.V1 = V1;
        this.V2 = V2;
        this.V1Http = V1Http;
        this.ThirdParty = ThirdParty;

    }



    /// <summary>
    /// Gets or Sets V1
    /// </summary>
    [JsonPropertyName("v1")]
    public WidgetClientConfigV1 V1 { get; set; }



    /// <summary>
    /// Gets or Sets V2
    /// </summary>
    [JsonPropertyName("v2")]
    public object V2 { get; set; }



    /// <summary>
    /// Gets or Sets V1Http
    /// </summary>
    [JsonPropertyName("v1-http")]
    public WidgetClientConfigV1Http V1Http { get; set; }



    /// <summary>
    /// Gets or Sets ThirdParty
    /// </summary>
    [JsonPropertyName("third-party")]
    public object ThirdParty { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WidgetClientConfig {\n");

        sb.Append("  V1: ").Append(V1).Append("\n");
        sb.Append("  V2: ").Append(V2).Append("\n");
        sb.Append("  V1Http: ").Append(V1Http).Append("\n");
        sb.Append("  ThirdParty: ").Append(ThirdParty).Append("\n");
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
        return Equals(obj as WidgetClientConfig);
    }

    /// <summary>
    /// Returns true if WidgetClientConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of WidgetClientConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WidgetClientConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                V1 == other.V1 ||
                V1 != null &&
                V1.Equals(other.V1)
            ) &&
            (
                V2 == other.V2 ||
                V2 != null &&
                V2.Equals(other.V2)
            ) &&
            (
                V1Http == other.V1Http ||
                V1Http != null &&
                V1Http.Equals(other.V1Http)
            ) &&
            (
                ThirdParty == other.ThirdParty ||
                ThirdParty != null &&
                ThirdParty.Equals(other.ThirdParty)
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
            if (V1 != null)
            {
                hash = hash * 59 + V1.GetHashCode();
            }

            if (V2 != null)
            {
                hash = hash * 59 + V2.GetHashCode();
            }

            if (V1Http != null)
            {
                hash = hash * 59 + V1Http.GetHashCode();
            }

            if (ThirdParty != null)
            {
                hash = hash * 59 + ThirdParty.GetHashCode();
            }

            return hash;
        }
    }
}

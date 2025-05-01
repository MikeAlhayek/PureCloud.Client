using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WidgetClientConfig
/// </summary>
[DataContract]
public partial class WidgetClientConfig : IEquatable<WidgetClientConfig>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WidgetClientConfig" /> class.
    /// </summary>
    /// <param name="V1">V1.</param>
    /// <param name="V2">V2.</param>
    /// <param name="V1Http">V1Http.</param>
    /// <param name="ThirdParty">ThirdParty.</param>
    public WidgetClientConfig(WidgetClientConfigV1 V1 = null, Object V2 = null, WidgetClientConfigV1Http V1Http = null, Object ThirdParty = null)
    {
        this.V1 = V1;
        this.V2 = V2;
        this.V1Http = V1Http;
        this.ThirdParty = ThirdParty;

    }



    /// <summary>
    /// Gets or Sets V1
    /// </summary>
    [DataMember(Name = "v1", EmitDefaultValue = false)]
    public WidgetClientConfigV1 V1 { get; set; }



    /// <summary>
    /// Gets or Sets V2
    /// </summary>
    [DataMember(Name = "v2", EmitDefaultValue = false)]
    public Object V2 { get; set; }



    /// <summary>
    /// Gets or Sets V1Http
    /// </summary>
    [DataMember(Name = "v1-http", EmitDefaultValue = false)]
    public WidgetClientConfigV1Http V1Http { get; set; }



    /// <summary>
    /// Gets or Sets ThirdParty
    /// </summary>
    [DataMember(Name = "third-party", EmitDefaultValue = false)]
    public Object ThirdParty { get; set; }


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
        return this.Equals(obj as WidgetClientConfig);
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
                this.V1 == other.V1 ||
                this.V1 != null &&
                this.V1.Equals(other.V1)
            ) &&
            (
                this.V2 == other.V2 ||
                this.V2 != null &&
                this.V2.Equals(other.V2)
            ) &&
            (
                this.V1Http == other.V1Http ||
                this.V1Http != null &&
                this.V1Http.Equals(other.V1Http)
            ) &&
            (
                this.ThirdParty == other.ThirdParty ||
                this.ThirdParty != null &&
                this.ThirdParty.Equals(other.ThirdParty)
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
            if (this.V1 != null)
            {
                hash = hash * 59 + this.V1.GetHashCode();
            }

            if (this.V2 != null)
            {
                hash = hash * 59 + this.V2.GetHashCode();
            }

            if (this.V1Http != null)
            {
                hash = hash * 59 + this.V1Http.GetHashCode();
            }

            if (this.ThirdParty != null)
            {
                hash = hash * 59 + this.ThirdParty.GetHashCode();
            }

            return hash;
        }
    }
}

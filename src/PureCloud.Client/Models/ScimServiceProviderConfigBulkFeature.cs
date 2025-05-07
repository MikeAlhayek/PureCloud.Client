using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a \&quot;bulk\&quot; request in the SCIM service provider&#39;s configuration.
/// </summary>

public partial class ScimServiceProviderConfigBulkFeature : IEquatable<ScimServiceProviderConfigBulkFeature>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimServiceProviderConfigBulkFeature" /> class.
    /// </summary>
    public ScimServiceProviderConfigBulkFeature()
    {

    }



    /// <summary>
    /// Indicates whether configuration options are supported.
    /// </summary>
    /// <value>Indicates whether configuration options are supported.</value>
    [JsonPropertyName("supported")]
    public bool? Supported { get; set; }



    /// <summary>
    /// The maximum number of operations for each bulk request.
    /// </summary>
    /// <value>The maximum number of operations for each bulk request.</value>
    [JsonPropertyName("maxOperations")]
    public int? MaxOperations { get; set; }



    /// <summary>
    /// The maximum payload size.
    /// </summary>
    /// <value>The maximum payload size.</value>
    [JsonPropertyName("maxPayloadSize")]
    public int? MaxPayloadSize { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimServiceProviderConfigBulkFeature {\n");

        sb.Append("  Supported: ").Append(Supported).Append("\n");
        sb.Append("  MaxOperations: ").Append(MaxOperations).Append("\n");
        sb.Append("  MaxPayloadSize: ").Append(MaxPayloadSize).Append("\n");
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
        return Equals(obj as ScimServiceProviderConfigBulkFeature);
    }

    /// <summary>
    /// Returns true if ScimServiceProviderConfigBulkFeature instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimServiceProviderConfigBulkFeature to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimServiceProviderConfigBulkFeature other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Supported == other.Supported ||
                Supported != null &&
                Supported.Equals(other.Supported)
            ) &&
            (
                MaxOperations == other.MaxOperations ||
                MaxOperations != null &&
                MaxOperations.Equals(other.MaxOperations)
            ) &&
            (
                MaxPayloadSize == other.MaxPayloadSize ||
                MaxPayloadSize != null &&
                MaxPayloadSize.Equals(other.MaxPayloadSize)
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
            if (Supported != null)
            {
                hash = hash * 59 + Supported.GetHashCode();
            }

            if (MaxOperations != null)
            {
                hash = hash * 59 + MaxOperations.GetHashCode();
            }

            if (MaxPayloadSize != null)
            {
                hash = hash * 59 + MaxPayloadSize.GetHashCode();
            }

            return hash;
        }
    }
}

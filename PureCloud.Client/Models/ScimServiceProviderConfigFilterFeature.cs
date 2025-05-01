using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a \&quot;filter\&quot; request in the SCIM service provider&#39;s configuration.
/// </summary>
[DataContract]
public partial class ScimServiceProviderConfigFilterFeature : IEquatable<ScimServiceProviderConfigFilterFeature>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimServiceProviderConfigFilterFeature" /> class.
    /// </summary>
    public ScimServiceProviderConfigFilterFeature()
    {

    }



    /// <summary>
    /// Indicates whether configuration options are supported.
    /// </summary>
    /// <value>Indicates whether configuration options are supported.</value>
    [DataMember(Name = "supported", EmitDefaultValue = false)]
    public bool? Supported { get; private set; }



    /// <summary>
    /// The maximum number of results returned from a filtered query.
    /// </summary>
    /// <value>The maximum number of results returned from a filtered query.</value>
    [DataMember(Name = "maxResults", EmitDefaultValue = false)]
    public int? MaxResults { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimServiceProviderConfigFilterFeature {\n");

        sb.Append("  Supported: ").Append(Supported).Append("\n");
        sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
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
        return Equals(obj as ScimServiceProviderConfigFilterFeature);
    }

    /// <summary>
    /// Returns true if ScimServiceProviderConfigFilterFeature instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimServiceProviderConfigFilterFeature to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimServiceProviderConfigFilterFeature other)
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
                MaxResults == other.MaxResults ||
                MaxResults != null &&
                MaxResults.Equals(other.MaxResults)
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

            if (MaxResults != null)
            {
                hash = hash * 59 + MaxResults.GetHashCode();
            }

            return hash;
        }
    }
}

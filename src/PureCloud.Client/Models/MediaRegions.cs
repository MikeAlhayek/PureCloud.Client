using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaRegions
/// </summary>

public partial class MediaRegions : IEquatable<MediaRegions>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaRegions" /> class.
    /// </summary>
    public MediaRegions()
    {

    }



    /// <summary>
    /// The AWS region your organization is in.
    /// </summary>
    /// <value>The AWS region your organization is in.</value>
    [JsonPropertyName("awsHomeRegion")]
    public string AwsHomeRegion { get; private set; }



    /// <summary>
    /// The list of AWS regions to which Genesys Cloud is deployed with full functionality including media streaming.
    /// </summary>
    /// <value>The list of AWS regions to which Genesys Cloud is deployed with full functionality including media streaming.</value>
    [JsonPropertyName("awsCoreRegions")]
    public List<string> AwsCoreRegions { get; private set; }



    /// <summary>
    /// The list of AWS regions that Genesys Cloud uses only for media streaming.
    /// </summary>
    /// <value>The list of AWS regions that Genesys Cloud uses only for media streaming.</value>
    [JsonPropertyName("awsSatelliteRegions")]
    public List<string> AwsSatelliteRegions { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaRegions {\n");

        sb.Append("  AwsHomeRegion: ").Append(AwsHomeRegion).Append("\n");
        sb.Append("  AwsCoreRegions: ").Append(AwsCoreRegions).Append("\n");
        sb.Append("  AwsSatelliteRegions: ").Append(AwsSatelliteRegions).Append("\n");
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
        return Equals(obj as MediaRegions);
    }

    /// <summary>
    /// Returns true if MediaRegions instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaRegions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaRegions other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AwsHomeRegion == other.AwsHomeRegion ||
                AwsHomeRegion != null &&
                AwsHomeRegion.Equals(other.AwsHomeRegion)
            ) &&
            (
                AwsCoreRegions == other.AwsCoreRegions ||
                AwsCoreRegions != null &&
                AwsCoreRegions.SequenceEqual(other.AwsCoreRegions)
            ) &&
            (
                AwsSatelliteRegions == other.AwsSatelliteRegions ||
                AwsSatelliteRegions != null &&
                AwsSatelliteRegions.SequenceEqual(other.AwsSatelliteRegions)
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
            if (AwsHomeRegion != null)
            {
                hash = hash * 59 + AwsHomeRegion.GetHashCode();
            }

            if (AwsCoreRegions != null)
            {
                hash = hash * 59 + AwsCoreRegions.GetHashCode();
            }

            if (AwsSatelliteRegions != null)
            {
                hash = hash * 59 + AwsSatelliteRegions.GetHashCode();
            }

            return hash;
        }
    }
}

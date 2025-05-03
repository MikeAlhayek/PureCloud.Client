using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchiveRetention
/// </summary>

public partial class ArchiveRetention : IEquatable<ArchiveRetention>
{
    /// <summary>
    /// Gets or Sets StorageMedium
    /// </summary>
    
    public enum StorageMediumEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Cloudarchive for "CLOUDARCHIVE"
        /// </summary>
        [EnumMember(Value = "CLOUDARCHIVE")]
        Cloudarchive
    }
    /// <summary>
    /// Gets or Sets StorageMedium
    /// </summary>
    [JsonPropertyName("storageMedium")]
    public StorageMediumEnum? StorageMedium { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchiveRetention" /> class.
    /// </summary>
    /// <param name="Days">Days.</param>
    /// <param name="StorageMedium">StorageMedium.</param>
    public ArchiveRetention(int? Days = null, StorageMediumEnum? StorageMedium = null)
    {
        this.Days = Days;
        this.StorageMedium = StorageMedium;

    }



    /// <summary>
    /// Gets or Sets Days
    /// </summary>
    [JsonPropertyName("days")]
    public int? Days { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchiveRetention {\n");

        sb.Append("  Days: ").Append(Days).Append("\n");
        sb.Append("  StorageMedium: ").Append(StorageMedium).Append("\n");
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
        return Equals(obj as ArchiveRetention);
    }

    /// <summary>
    /// Returns true if ArchiveRetention instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchiveRetention to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchiveRetention other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Days == other.Days ||
                Days != null &&
                Days.Equals(other.Days)
            ) &&
            (
                StorageMedium == other.StorageMedium ||
                StorageMedium != null &&
                StorageMedium.Equals(other.StorageMedium)
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
            if (Days != null)
            {
                hash = hash * 59 + Days.GetHashCode();
            }

            if (StorageMedium != null)
            {
                hash = hash * 59 + StorageMedium.GetHashCode();
            }

            return hash;
        }
    }
}

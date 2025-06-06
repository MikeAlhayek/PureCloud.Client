using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestDataPrizes
/// </summary>

public partial class ContestDataPrizes : IEquatable<ContestDataPrizes>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestDataPrizes" /> class.
    /// </summary>
    /// <param name="Tier">Tier of the prize.</param>
    /// <param name="Name">Name of the prize.</param>
    /// <param name="ImageId">Id of the prize image.</param>
    public ContestDataPrizes(int? Tier = null, string Name = null, string ImageId = null)
    {
        this.Tier = Tier;
        this.Name = Name;
        this.ImageId = ImageId;

    }



    /// <summary>
    /// Tier of the prize
    /// </summary>
    /// <value>Tier of the prize</value>
    [JsonPropertyName("tier")]
    public int? Tier { get; set; }



    /// <summary>
    /// Name of the prize
    /// </summary>
    /// <value>Name of the prize</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Id of the prize image
    /// </summary>
    /// <value>Id of the prize image</value>
    [JsonPropertyName("imageId")]
    public string ImageId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestDataPrizes {\n");

        sb.Append("  Tier: ").Append(Tier).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  ImageId: ").Append(ImageId).Append("\n");
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
        return Equals(obj as ContestDataPrizes);
    }

    /// <summary>
    /// Returns true if ContestDataPrizes instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestDataPrizes to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestDataPrizes other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Tier == other.Tier ||
                Tier != null &&
                Tier.Equals(other.Tier)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                ImageId == other.ImageId ||
                ImageId != null &&
                ImageId.Equals(other.ImageId)
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
            if (Tier != null)
            {
                hash = hash * 59 + Tier.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (ImageId != null)
            {
                hash = hash * 59 + ImageId.GetHashCode();
            }

            return hash;
        }
    }
}

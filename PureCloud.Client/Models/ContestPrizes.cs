using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContestPrizes
/// </summary>

public partial class ContestPrizes : IEquatable<ContestPrizes>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ContestPrizes" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContestPrizes() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContestPrizes" /> class.
    /// </summary>
    /// <param name="Tier">The Contest Prize tier (required).</param>
    /// <param name="Name">The Contest Prize name (required).</param>
    /// <param name="Description">The Contest Prize description (required).</param>
    /// <param name="ImageId">The Contest Prize image id (required).</param>
    /// <param name="WinnersCount">The Contest Prize winner Count (required).</param>
    public ContestPrizes(int? Tier = null, string Name = null, string Description = null, string ImageId = null, int? WinnersCount = null)
    {
        this.Tier = Tier;
        this.Name = Name;
        this.Description = Description;
        this.ImageId = ImageId;
        this.WinnersCount = WinnersCount;

    }



    /// <summary>
    /// The Contest Prize tier
    /// </summary>
    /// <value>The Contest Prize tier</value>
    [JsonPropertyName("tier")]
    public int? Tier { get; set; }



    /// <summary>
    /// The Contest Prize name
    /// </summary>
    /// <value>The Contest Prize name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The Contest Prize description
    /// </summary>
    /// <value>The Contest Prize description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The Contest Prize image id
    /// </summary>
    /// <value>The Contest Prize image id</value>
    [JsonPropertyName("imageId")]
    public string ImageId { get; set; }



    /// <summary>
    /// The Contest Prize image url
    /// </summary>
    /// <value>The Contest Prize image url</value>
    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; private set; }



    /// <summary>
    /// The Contest Prize winner Count
    /// </summary>
    /// <value>The Contest Prize winner Count</value>
    [JsonPropertyName("winnersCount")]
    public int? WinnersCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContestPrizes {\n");

        sb.Append("  Tier: ").Append(Tier).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ImageId: ").Append(ImageId).Append("\n");
        sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
        sb.Append("  WinnersCount: ").Append(WinnersCount).Append("\n");
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
        return Equals(obj as ContestPrizes);
    }

    /// <summary>
    /// Returns true if ContestPrizes instances are equal
    /// </summary>
    /// <param name="other">Instance of ContestPrizes to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContestPrizes other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                ImageId == other.ImageId ||
                ImageId != null &&
                ImageId.Equals(other.ImageId)
            ) &&
            (
                ImageUrl == other.ImageUrl ||
                ImageUrl != null &&
                ImageUrl.Equals(other.ImageUrl)
            ) &&
            (
                WinnersCount == other.WinnersCount ||
                WinnersCount != null &&
                WinnersCount.Equals(other.WinnersCount)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ImageId != null)
            {
                hash = hash * 59 + ImageId.GetHashCode();
            }

            if (ImageUrl != null)
            {
                hash = hash * 59 + ImageUrl.GetHashCode();
            }

            if (WinnersCount != null)
            {
                hash = hash * 59 + WinnersCount.GetHashCode();
            }

            return hash;
        }
    }
}

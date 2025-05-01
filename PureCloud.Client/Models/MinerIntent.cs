using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MinerIntent
/// </summary>
[DataContract]
public partial class MinerIntent : IEquatable<MinerIntent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MinerIntent" /> class.
    /// </summary>
    /// <param name="Name">Intent name..</param>
    /// <param name="Miner">The miner to which the intent belongs..</param>
    /// <param name="Utterances">The utterances that are extracted for an Intent..</param>
    /// <param name="AnalyticVolumePercent">Percentage of conversations belonging to the intent..</param>
    public MinerIntent(string Name = null, Miner Miner = null, List<Utterance> Utterances = null, double? AnalyticVolumePercent = null)
    {
        this.Name = Name;
        this.Miner = Miner;
        this.Utterances = Utterances;
        this.AnalyticVolumePercent = AnalyticVolumePercent;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Intent name.
    /// </summary>
    /// <value>Intent name.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The miner to which the intent belongs.
    /// </summary>
    /// <value>The miner to which the intent belongs.</value>
    [DataMember(Name = "miner", EmitDefaultValue = false)]
    public Miner Miner { get; set; }



    /// <summary>
    /// The utterances that are extracted for an Intent.
    /// </summary>
    /// <value>The utterances that are extracted for an Intent.</value>
    [DataMember(Name = "utterances", EmitDefaultValue = false)]
    public List<Utterance> Utterances { get; set; }



    /// <summary>
    /// Percentage of conversations belonging to the intent.
    /// </summary>
    /// <value>Percentage of conversations belonging to the intent.</value>
    [DataMember(Name = "analyticVolumePercent", EmitDefaultValue = false)]
    public double? AnalyticVolumePercent { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MinerIntent {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Miner: ").Append(Miner).Append("\n");
        sb.Append("  Utterances: ").Append(Utterances).Append("\n");
        sb.Append("  AnalyticVolumePercent: ").Append(AnalyticVolumePercent).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as MinerIntent);
    }

    /// <summary>
    /// Returns true if MinerIntent instances are equal
    /// </summary>
    /// <param name="other">Instance of MinerIntent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MinerIntent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Miner == other.Miner ||
                Miner != null &&
                Miner.Equals(other.Miner)
            ) &&
            (
                Utterances == other.Utterances ||
                Utterances != null &&
                Utterances.SequenceEqual(other.Utterances)
            ) &&
            (
                AnalyticVolumePercent == other.AnalyticVolumePercent ||
                AnalyticVolumePercent != null &&
                AnalyticVolumePercent.Equals(other.AnalyticVolumePercent)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Miner != null)
            {
                hash = hash * 59 + Miner.GetHashCode();
            }

            if (Utterances != null)
            {
                hash = hash * 59 + Utterances.GetHashCode();
            }

            if (AnalyticVolumePercent != null)
            {
                hash = hash * 59 + AnalyticVolumePercent.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

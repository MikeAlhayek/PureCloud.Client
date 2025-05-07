using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowHealthIntentInfo
/// </summary>

public partial class FlowHealthIntentInfo : IEquatable<FlowHealthIntentInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowHealthIntentInfo" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="LanguageHealth">Health computation info for each language..</param>
    public FlowHealthIntentInfo(string Name = null, Dictionary<string, LocaleHealth> LanguageHealth = null)
    {
        this.Name = Name;
        this.LanguageHealth = LanguageHealth;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Health computation info for each language.
    /// </summary>
    /// <value>Health computation info for each language.</value>
    [JsonPropertyName("languageHealth")]
    public Dictionary<string, LocaleHealth> LanguageHealth { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowHealthIntentInfo {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  LanguageHealth: ").Append(LanguageHealth).Append("\n");
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
        return Equals(obj as FlowHealthIntentInfo);
    }

    /// <summary>
    /// Returns true if FlowHealthIntentInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowHealthIntentInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowHealthIntentInfo other)
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
                LanguageHealth == other.LanguageHealth ||
                LanguageHealth != null &&
                LanguageHealth.SequenceEqual(other.LanguageHealth)
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

            if (LanguageHealth != null)
            {
                hash = hash * 59 + LanguageHealth.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

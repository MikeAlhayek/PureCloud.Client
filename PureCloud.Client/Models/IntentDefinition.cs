using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// IntentDefinition
/// </summary>

public partial class IntentDefinition : IEquatable<IntentDefinition>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="IntentDefinition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected IntentDefinition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IntentDefinition" /> class.
    /// </summary>
    /// <param name="Name">The name of the intent. (required).</param>
    /// <param name="Description">The description of the intent..</param>
    /// <param name="EntityTypeBindings">The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities.</param>
    /// <param name="Utterances">The utterances that act as training phrases for the intent. (required).</param>
    /// <param name="AdditionalLanguages">Additional languages for intents.</param>
    public IntentDefinition(string Name = null, string Description = null, List<NamedEntityTypeBinding> EntityTypeBindings = null, List<NluUtterance> Utterances = null, Dictionary<string, AdditionalLanguagesIntent> AdditionalLanguages = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.EntityTypeBindings = EntityTypeBindings;
        this.Utterances = Utterances;
        this.AdditionalLanguages = AdditionalLanguages;

    }



    /// <summary>
    /// ID of the intent.
    /// </summary>
    /// <value>ID of the intent.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the intent.
    /// </summary>
    /// <value>The name of the intent.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The description of the intent.
    /// </summary>
    /// <value>The description of the intent.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities
    /// </summary>
    /// <value>The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities</value>
    [JsonPropertyName("entityTypeBindings")]
    public List<NamedEntityTypeBinding> EntityTypeBindings { get; set; }



    /// <summary>
    /// The references for the named entity used in this intent.This field is mutually exclusive with entityTypeBindings
    /// </summary>
    /// <value>The references for the named entity used in this intent.This field is mutually exclusive with entityTypeBindings</value>
    [JsonPropertyName("entityNameReferences")]
    public List<string> EntityNameReferences { get; private set; }



    /// <summary>
    /// The utterances that act as training phrases for the intent.
    /// </summary>
    /// <value>The utterances that act as training phrases for the intent.</value>
    [JsonPropertyName("utterances")]
    public List<NluUtterance> Utterances { get; set; }



    /// <summary>
    /// Additional languages for intents
    /// </summary>
    /// <value>Additional languages for intents</value>
    [JsonPropertyName("additionalLanguages")]
    public Dictionary<string, AdditionalLanguagesIntent> AdditionalLanguages { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IntentDefinition {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  EntityTypeBindings: ").Append(EntityTypeBindings).Append("\n");
        sb.Append("  EntityNameReferences: ").Append(EntityNameReferences).Append("\n");
        sb.Append("  Utterances: ").Append(Utterances).Append("\n");
        sb.Append("  AdditionalLanguages: ").Append(AdditionalLanguages).Append("\n");
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
        return Equals(obj as IntentDefinition);
    }

    /// <summary>
    /// Returns true if IntentDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of IntentDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IntentDefinition other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                EntityTypeBindings == other.EntityTypeBindings ||
                EntityTypeBindings != null &&
                EntityTypeBindings.SequenceEqual(other.EntityTypeBindings)
            ) &&
            (
                EntityNameReferences == other.EntityNameReferences ||
                EntityNameReferences != null &&
                EntityNameReferences.SequenceEqual(other.EntityNameReferences)
            ) &&
            (
                Utterances == other.Utterances ||
                Utterances != null &&
                Utterances.SequenceEqual(other.Utterances)
            ) &&
            (
                AdditionalLanguages == other.AdditionalLanguages ||
                AdditionalLanguages != null &&
                AdditionalLanguages.SequenceEqual(other.AdditionalLanguages)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (EntityTypeBindings != null)
            {
                hash = hash * 59 + EntityTypeBindings.GetHashCode();
            }

            if (EntityNameReferences != null)
            {
                hash = hash * 59 + EntityNameReferences.GetHashCode();
            }

            if (Utterances != null)
            {
                hash = hash * 59 + Utterances.GetHashCode();
            }

            if (AdditionalLanguages != null)
            {
                hash = hash * 59 + AdditionalLanguages.GetHashCode();
            }

            return hash;
        }
    }
}

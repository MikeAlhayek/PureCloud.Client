using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// IntentDefinition
/// </summary>
[DataContract]
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
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the intent.
    /// </summary>
    /// <value>The name of the intent.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The description of the intent.
    /// </summary>
    /// <value>The description of the intent.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities
    /// </summary>
    /// <value>The bindings for the named entity types used in this intent.This field is mutually exclusive with entityNameReferences and entities</value>
    [DataMember(Name = "entityTypeBindings", EmitDefaultValue = false)]
    public List<NamedEntityTypeBinding> EntityTypeBindings { get; set; }



    /// <summary>
    /// The references for the named entity used in this intent.This field is mutually exclusive with entityTypeBindings
    /// </summary>
    /// <value>The references for the named entity used in this intent.This field is mutually exclusive with entityTypeBindings</value>
    [DataMember(Name = "entityNameReferences", EmitDefaultValue = false)]
    public List<string> EntityNameReferences { get; private set; }



    /// <summary>
    /// The utterances that act as training phrases for the intent.
    /// </summary>
    /// <value>The utterances that act as training phrases for the intent.</value>
    [DataMember(Name = "utterances", EmitDefaultValue = false)]
    public List<NluUtterance> Utterances { get; set; }



    /// <summary>
    /// Additional languages for intents
    /// </summary>
    /// <value>Additional languages for intents</value>
    [DataMember(Name = "additionalLanguages", EmitDefaultValue = false)]
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
        return this.Equals(obj as IntentDefinition);
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
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.Description == other.Description ||
                this.Description != null &&
                this.Description.Equals(other.Description)
            ) &&
            (
                this.EntityTypeBindings == other.EntityTypeBindings ||
                this.EntityTypeBindings != null &&
                this.EntityTypeBindings.SequenceEqual(other.EntityTypeBindings)
            ) &&
            (
                this.EntityNameReferences == other.EntityNameReferences ||
                this.EntityNameReferences != null &&
                this.EntityNameReferences.SequenceEqual(other.EntityNameReferences)
            ) &&
            (
                this.Utterances == other.Utterances ||
                this.Utterances != null &&
                this.Utterances.SequenceEqual(other.Utterances)
            ) &&
            (
                this.AdditionalLanguages == other.AdditionalLanguages ||
                this.AdditionalLanguages != null &&
                this.AdditionalLanguages.SequenceEqual(other.AdditionalLanguages)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.Description != null)
            {
                hash = hash * 59 + this.Description.GetHashCode();
            }

            if (this.EntityTypeBindings != null)
            {
                hash = hash * 59 + this.EntityTypeBindings.GetHashCode();
            }

            if (this.EntityNameReferences != null)
            {
                hash = hash * 59 + this.EntityNameReferences.GetHashCode();
            }

            if (this.Utterances != null)
            {
                hash = hash * 59 + this.Utterances.GetHashCode();
            }

            if (this.AdditionalLanguages != null)
            {
                hash = hash * 59 + this.AdditionalLanguages.GetHashCode();
            }

            return hash;
        }
    }
}

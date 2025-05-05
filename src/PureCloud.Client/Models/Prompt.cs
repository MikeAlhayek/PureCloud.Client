using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Prompt
/// </summary>

public partial class Prompt : IEquatable<Prompt>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Prompt" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Prompt() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Prompt" /> class.
    /// </summary>
    /// <param name="Id">The prompt identifier.</param>
    /// <param name="Name">The prompt name. (required).</param>
    /// <param name="Description">Description.</param>
    public Prompt(string Id = null, string Name = null, string Description = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;

    }



    /// <summary>
    /// The prompt identifier
    /// </summary>
    /// <value>The prompt identifier</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The prompt name.
    /// </summary>
    /// <value>The prompt name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// List of resources associated with this prompt
    /// </summary>
    /// <value>List of resources associated with this prompt</value>
    [JsonPropertyName("resources")]
    public List<PromptAsset> Resources { get; private set; }



    /// <summary>
    /// Current prompt operation status
    /// </summary>
    /// <value>Current prompt operation status</value>
    [JsonPropertyName("currentOperation")]
    public Operation CurrentOperation { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Prompt {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Resources: ").Append(Resources).Append("\n");
        sb.Append("  CurrentOperation: ").Append(CurrentOperation).Append("\n");
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
        return Equals(obj as Prompt);
    }

    /// <summary>
    /// Returns true if Prompt instances are equal
    /// </summary>
    /// <param name="other">Instance of Prompt to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Prompt other)
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
                Resources == other.Resources ||
                Resources != null &&
                Resources.SequenceEqual(other.Resources)
            ) &&
            (
                CurrentOperation == other.CurrentOperation ||
                CurrentOperation != null &&
                CurrentOperation.Equals(other.CurrentOperation)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Resources != null)
            {
                hash = hash * 59 + Resources.GetHashCode();
            }

            if (CurrentOperation != null)
            {
                hash = hash * 59 + CurrentOperation.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Definition of an Action Draft to be created or updated.
/// </summary>

public partial class UpdateDraftInput : IEquatable<UpdateDraftInput>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateDraftInput" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateDraftInput() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateDraftInput" /> class.
    /// </summary>
    /// <param name="Category">Category of action, Can be up to 256 characters long.</param>
    /// <param name="Name">Name of action, Can be up to 256 characters long.</param>
    /// <param name="Config">Configuration to support request and response processing.</param>
    /// <param name="Contract">Action contract.</param>
    /// <param name="Secure">Indication of whether or not the action is designed to accept sensitive data.</param>
    /// <param name="Version">Version of current Draft (required).</param>
    public UpdateDraftInput(string Category = null, string Name = null, ActionConfig Config = null, ActionContractInput Contract = null, bool? Secure = null, int? Version = null)
    {
        this.Category = Category;
        this.Name = Name;
        this.Config = Config;
        this.Contract = Contract;
        this.Secure = Secure;
        this.Version = Version;

    }



    /// <summary>
    /// Category of action, Can be up to 256 characters long
    /// </summary>
    /// <value>Category of action, Can be up to 256 characters long</value>
    [JsonPropertyName("category")]
    public string Category { get; set; }



    /// <summary>
    /// Name of action, Can be up to 256 characters long
    /// </summary>
    /// <value>Name of action, Can be up to 256 characters long</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Configuration to support request and response processing
    /// </summary>
    /// <value>Configuration to support request and response processing</value>
    [JsonPropertyName("config")]
    public ActionConfig Config { get; set; }



    /// <summary>
    /// Action contract
    /// </summary>
    /// <value>Action contract</value>
    [JsonPropertyName("contract")]
    public ActionContractInput Contract { get; set; }



    /// <summary>
    /// Indication of whether or not the action is designed to accept sensitive data
    /// </summary>
    /// <value>Indication of whether or not the action is designed to accept sensitive data</value>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }



    /// <summary>
    /// Version of current Draft
    /// </summary>
    /// <value>Version of current Draft</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateDraftInput {\n");

        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Config: ").Append(Config).Append("\n");
        sb.Append("  Contract: ").Append(Contract).Append("\n");
        sb.Append("  Secure: ").Append(Secure).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as UpdateDraftInput);
    }

    /// <summary>
    /// Returns true if UpdateDraftInput instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateDraftInput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateDraftInput other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Config == other.Config ||
                Config != null &&
                Config.Equals(other.Config)
            ) &&
            (
                Contract == other.Contract ||
                Contract != null &&
                Contract.Equals(other.Contract)
            ) &&
            (
                Secure == other.Secure ||
                Secure != null &&
                Secure.Equals(other.Secure)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Config != null)
            {
                hash = hash * 59 + Config.GetHashCode();
            }

            if (Contract != null)
            {
                hash = hash * 59 + Contract.GetHashCode();
            }

            if (Secure != null)
            {
                hash = hash * 59 + Secure.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}

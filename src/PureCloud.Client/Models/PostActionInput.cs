using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Definition of an Action to be created or updated.
/// </summary>

public partial class PostActionInput : IEquatable<PostActionInput>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PostActionInput" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PostActionInput() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PostActionInput" /> class.
    /// </summary>
    /// <param name="Category">Category of action, Can be up to 256 characters long (required).</param>
    /// <param name="Name">Name of action, Can be up to 256 characters long (required).</param>
    /// <param name="IntegrationId">The ID of the integration this action is associated to (required).</param>
    /// <param name="Config">Configuration to support request and response processing (required).</param>
    /// <param name="Contract">Action contract (required).</param>
    /// <param name="Secure">Indication of whether or not the action is designed to accept sensitive data.</param>
    public PostActionInput(string Category = null, string Name = null, string IntegrationId = null, ActionConfig Config = null, ActionContractInput Contract = null, bool? Secure = null)
    {
        this.Category = Category;
        this.Name = Name;
        this.IntegrationId = IntegrationId;
        this.Config = Config;
        this.Contract = Contract;
        this.Secure = Secure;

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
    /// The ID of the integration this action is associated to
    /// </summary>
    /// <value>The ID of the integration this action is associated to</value>
    [JsonPropertyName("integrationId")]
    public string IntegrationId { get; set; }



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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PostActionInput {\n");

        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("  Config: ").Append(Config).Append("\n");
        sb.Append("  Contract: ").Append(Contract).Append("\n");
        sb.Append("  Secure: ").Append(Secure).Append("\n");
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
        return Equals(obj as PostActionInput);
    }

    /// <summary>
    /// Returns true if PostActionInput instances are equal
    /// </summary>
    /// <param name="other">Instance of PostActionInput to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PostActionInput other)
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
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
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

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
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

            return hash;
        }
    }
}

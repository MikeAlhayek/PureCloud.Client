using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Action
/// </summary>

public partial class Action : IEquatable<Action>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Action" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="IntegrationId">The ID of the integration for which this action is associated.</param>
    /// <param name="Category">Category of Action.</param>
    /// <param name="Contract">Action contract.</param>
    /// <param name="Version">Version of this action.</param>
    /// <param name="Secure">Indication of whether or not the action is designed to accept sensitive data.</param>
    /// <param name="Config">Configuration to support request and response processing.</param>
    public Action(string Name = null, string IntegrationId = null, string Category = null, ActionContract Contract = null, int? Version = null, bool? Secure = null, ActionConfig Config = null)
    {
        this.Name = Name;
        this.IntegrationId = IntegrationId;
        this.Category = Category;
        this.Contract = Contract;
        this.Version = Version;
        this.Secure = Secure;
        this.Config = Config;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The ID of the integration for which this action is associated
    /// </summary>
    /// <value>The ID of the integration for which this action is associated</value>
    [JsonPropertyName("integrationId")]
    public string IntegrationId { get; set; }



    /// <summary>
    /// Category of Action
    /// </summary>
    /// <value>Category of Action</value>
    [JsonPropertyName("category")]
    public string Category { get; set; }



    /// <summary>
    /// Action contract
    /// </summary>
    /// <value>Action contract</value>
    [JsonPropertyName("contract")]
    public ActionContract Contract { get; set; }



    /// <summary>
    /// Version of this action
    /// </summary>
    /// <value>Version of this action</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// Indication of whether or not the action is designed to accept sensitive data
    /// </summary>
    /// <value>Indication of whether or not the action is designed to accept sensitive data</value>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }



    /// <summary>
    /// Configuration to support request and response processing
    /// </summary>
    /// <value>Configuration to support request and response processing</value>
    [JsonPropertyName("config")]
    public ActionConfig Config { get; set; }



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
        sb.Append("class Action {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  Contract: ").Append(Contract).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Secure: ").Append(Secure).Append("\n");
        sb.Append("  Config: ").Append(Config).Append("\n");
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
        return Equals(obj as Action);
    }

    /// <summary>
    /// Returns true if Action instances are equal
    /// </summary>
    /// <param name="other">Instance of Action to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Action other)
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
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
            ) &&
            (
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                Contract == other.Contract ||
                Contract != null &&
                Contract.Equals(other.Contract)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Secure == other.Secure ||
                Secure != null &&
                Secure.Equals(other.Secure)
            ) &&
            (
                Config == other.Config ||
                Config != null &&
                Config.Equals(other.Config)
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

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
            }

            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (Contract != null)
            {
                hash = hash * 59 + Contract.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Secure != null)
            {
                hash = hash * 59 + Secure.GetHashCode();
            }

            if (Config != null)
            {
                hash = hash * 59 + Config.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

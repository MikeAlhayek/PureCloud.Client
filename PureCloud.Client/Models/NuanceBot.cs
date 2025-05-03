using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Model for a Nuance bot
/// </summary>

public partial class NuanceBot : IEquatable<NuanceBot>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceBot" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NuanceBot() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NuanceBot" /> class.
    /// </summary>
    /// <param name="Id">Nuance bot Id (required).</param>
    /// <param name="Name">Nuance bot name (required).</param>
    /// <param name="IntegrationId">The Integration Id for this bot (required).</param>
    /// <param name="NuanceOrganization">The Nuance Organization for this bot (required).</param>
    /// <param name="Application">The Application for this bot (required).</param>
    /// <param name="NuanceEnvironment">The environment of the Nuance bot (required).</param>
    /// <param name="Geography">The Geography of the Nuance bot (required).</param>
    /// <param name="Credentials">client ID/Secret objects for the credentials that execute this Nuance bot.</param>
    /// <param name="Variables">List of available variables in this Nuance bot.  When querying, use the &#39;expand&#x3D;variables&#39; query param to populate this value.</param>
    /// <param name="TransferNodes">List of transferNodes in this Nuance bot.  When querying, use the &#39;expand&#x3D;transferNodes&#39; query param to populate this value.</param>
    /// <param name="Locales">List of locales associated with this Nuance bot.  Generally in the ISO format such as &#39;en-US&#39;.</param>
    /// <param name="Channels">List of channels associated with this Nuance bot..</param>
    public NuanceBot(string Id = null, string Name = null, string IntegrationId = null, NuanceOrganization NuanceOrganization = null, NuanceApplication Application = null, NuanceEnvironment NuanceEnvironment = null, NuanceGeography Geography = null, List<NuanceBotCredentials> Credentials = null, List<NuanceBotVariable> Variables = null, List<NuanceBotTransferNode> TransferNodes = null, List<string> Locales = null, List<NuanceChannel> Channels = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.IntegrationId = IntegrationId;
        this.NuanceOrganization = NuanceOrganization;
        this.Application = Application;
        this.NuanceEnvironment = NuanceEnvironment;
        this.Geography = Geography;
        this.Credentials = Credentials;
        this.Variables = Variables;
        this.TransferNodes = TransferNodes;
        this.Locales = Locales;
        this.Channels = Channels;

    }



    /// <summary>
    /// Nuance bot Id
    /// </summary>
    /// <value>Nuance bot Id</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Nuance bot name
    /// </summary>
    /// <value>Nuance bot name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The Integration Id for this bot
    /// </summary>
    /// <value>The Integration Id for this bot</value>
    [JsonPropertyName("integrationId")]
    public string IntegrationId { get; set; }



    /// <summary>
    /// The Nuance Organization for this bot
    /// </summary>
    /// <value>The Nuance Organization for this bot</value>
    [JsonPropertyName("nuanceOrganization")]
    public NuanceOrganization NuanceOrganization { get; set; }



    /// <summary>
    /// The Application for this bot
    /// </summary>
    /// <value>The Application for this bot</value>
    [JsonPropertyName("application")]
    public NuanceApplication Application { get; set; }



    /// <summary>
    /// The environment of the Nuance bot
    /// </summary>
    /// <value>The environment of the Nuance bot</value>
    [JsonPropertyName("nuanceEnvironment")]
    public NuanceEnvironment NuanceEnvironment { get; set; }



    /// <summary>
    /// The Geography of the Nuance bot
    /// </summary>
    /// <value>The Geography of the Nuance bot</value>
    [JsonPropertyName("geography")]
    public NuanceGeography Geography { get; set; }



    /// <summary>
    /// client ID/Secret objects for the credentials that execute this Nuance bot
    /// </summary>
    /// <value>client ID/Secret objects for the credentials that execute this Nuance bot</value>
    [JsonPropertyName("credentials")]
    public List<NuanceBotCredentials> Credentials { get; set; }



    /// <summary>
    /// List of available variables in this Nuance bot.  When querying, use the &#39;expand&#x3D;variables&#39; query param to populate this value
    /// </summary>
    /// <value>List of available variables in this Nuance bot.  When querying, use the &#39;expand&#x3D;variables&#39; query param to populate this value</value>
    [JsonPropertyName("variables")]
    public List<NuanceBotVariable> Variables { get; set; }



    /// <summary>
    /// List of transferNodes in this Nuance bot.  When querying, use the &#39;expand&#x3D;transferNodes&#39; query param to populate this value
    /// </summary>
    /// <value>List of transferNodes in this Nuance bot.  When querying, use the &#39;expand&#x3D;transferNodes&#39; query param to populate this value</value>
    [JsonPropertyName("transferNodes")]
    public List<NuanceBotTransferNode> TransferNodes { get; set; }



    /// <summary>
    /// List of locales associated with this Nuance bot.  Generally in the ISO format such as &#39;en-US&#39;
    /// </summary>
    /// <value>List of locales associated with this Nuance bot.  Generally in the ISO format such as &#39;en-US&#39;</value>
    [JsonPropertyName("locales")]
    public List<string> Locales { get; set; }



    /// <summary>
    /// List of channels associated with this Nuance bot.
    /// </summary>
    /// <value>List of channels associated with this Nuance bot.</value>
    [JsonPropertyName("channels")]
    public List<NuanceChannel> Channels { get; set; }



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
        sb.Append("class NuanceBot {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("  NuanceOrganization: ").Append(NuanceOrganization).Append("\n");
        sb.Append("  Application: ").Append(Application).Append("\n");
        sb.Append("  NuanceEnvironment: ").Append(NuanceEnvironment).Append("\n");
        sb.Append("  Geography: ").Append(Geography).Append("\n");
        sb.Append("  Credentials: ").Append(Credentials).Append("\n");
        sb.Append("  Variables: ").Append(Variables).Append("\n");
        sb.Append("  TransferNodes: ").Append(TransferNodes).Append("\n");
        sb.Append("  Locales: ").Append(Locales).Append("\n");
        sb.Append("  Channels: ").Append(Channels).Append("\n");
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
        return Equals(obj as NuanceBot);
    }

    /// <summary>
    /// Returns true if NuanceBot instances are equal
    /// </summary>
    /// <param name="other">Instance of NuanceBot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NuanceBot other)
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
                NuanceOrganization == other.NuanceOrganization ||
                NuanceOrganization != null &&
                NuanceOrganization.Equals(other.NuanceOrganization)
            ) &&
            (
                Application == other.Application ||
                Application != null &&
                Application.Equals(other.Application)
            ) &&
            (
                NuanceEnvironment == other.NuanceEnvironment ||
                NuanceEnvironment != null &&
                NuanceEnvironment.Equals(other.NuanceEnvironment)
            ) &&
            (
                Geography == other.Geography ||
                Geography != null &&
                Geography.Equals(other.Geography)
            ) &&
            (
                Credentials == other.Credentials ||
                Credentials != null &&
                Credentials.SequenceEqual(other.Credentials)
            ) &&
            (
                Variables == other.Variables ||
                Variables != null &&
                Variables.SequenceEqual(other.Variables)
            ) &&
            (
                TransferNodes == other.TransferNodes ||
                TransferNodes != null &&
                TransferNodes.SequenceEqual(other.TransferNodes)
            ) &&
            (
                Locales == other.Locales ||
                Locales != null &&
                Locales.SequenceEqual(other.Locales)
            ) &&
            (
                Channels == other.Channels ||
                Channels != null &&
                Channels.SequenceEqual(other.Channels)
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

            if (NuanceOrganization != null)
            {
                hash = hash * 59 + NuanceOrganization.GetHashCode();
            }

            if (Application != null)
            {
                hash = hash * 59 + Application.GetHashCode();
            }

            if (NuanceEnvironment != null)
            {
                hash = hash * 59 + NuanceEnvironment.GetHashCode();
            }

            if (Geography != null)
            {
                hash = hash * 59 + Geography.GetHashCode();
            }

            if (Credentials != null)
            {
                hash = hash * 59 + Credentials.GetHashCode();
            }

            if (Variables != null)
            {
                hash = hash * 59 + Variables.GetHashCode();
            }

            if (TransferNodes != null)
            {
                hash = hash * 59 + TransferNodes.GetHashCode();
            }

            if (Locales != null)
            {
                hash = hash * 59 + Locales.GetHashCode();
            }

            if (Channels != null)
            {
                hash = hash * 59 + Channels.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}

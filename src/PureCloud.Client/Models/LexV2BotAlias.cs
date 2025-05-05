using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LexV2BotAlias
/// </summary>

public partial class LexV2BotAlias : IEquatable<LexV2BotAlias>
{
    /// <summary>
    /// The status of the Lex V2 bot alias
    /// </summary>
    /// <value>The status of the Lex V2 bot alias</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Creating for "Creating"
        /// </summary>
        [EnumMember(Value = "Creating")]
        Creating,

        /// <summary>
        /// Enum Available for "Available"
        /// </summary>
        [EnumMember(Value = "Available")]
        Available,

        /// <summary>
        /// Enum Deleting for "Deleting"
        /// </summary>
        [EnumMember(Value = "Deleting")]
        Deleting,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// The status of the Lex V2 bot alias
    /// </summary>
    /// <value>The status of the Lex V2 bot alias</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LexV2BotAlias" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LexV2BotAlias() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LexV2BotAlias" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Region">The Lex V2 bot region (required).</param>
    /// <param name="AliasId">The Lex V2 bot alias Id (required).</param>
    /// <param name="Bot">The Lex V2 bot this is an alias for.</param>
    /// <param name="BotVersion">The version of the Lex V2 bot this alias points at.</param>
    /// <param name="Status">The status of the Lex V2 bot alias.</param>
    /// <param name="Language">The target language of the Lex V2 bot.</param>
    /// <param name="Intents">An array of Intents associated with this bot alias.</param>
    public LexV2BotAlias(string Name = null, string Region = null, string AliasId = null, LexV2Bot Bot = null, string BotVersion = null, StatusEnum? Status = null, string Language = null, List<LexV2Intent> Intents = null)
    {
        this.Name = Name;
        this.Region = Region;
        this.AliasId = AliasId;
        this.Bot = Bot;
        this.BotVersion = BotVersion;
        this.Status = Status;
        this.Language = Language;
        this.Intents = Intents;

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
    /// The Lex V2 bot region
    /// </summary>
    /// <value>The Lex V2 bot region</value>
    [JsonPropertyName("region")]
    public string Region { get; set; }



    /// <summary>
    /// The Lex V2 bot alias Id
    /// </summary>
    /// <value>The Lex V2 bot alias Id</value>
    [JsonPropertyName("aliasId")]
    public string AliasId { get; set; }



    /// <summary>
    /// The Lex V2 bot this is an alias for
    /// </summary>
    /// <value>The Lex V2 bot this is an alias for</value>
    [JsonPropertyName("bot")]
    public LexV2Bot Bot { get; set; }



    /// <summary>
    /// The version of the Lex V2 bot this alias points at
    /// </summary>
    /// <value>The version of the Lex V2 bot this alias points at</value>
    [JsonPropertyName("botVersion")]
    public string BotVersion { get; set; }





    /// <summary>
    /// The target language of the Lex V2 bot
    /// </summary>
    /// <value>The target language of the Lex V2 bot</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// An array of Intents associated with this bot alias
    /// </summary>
    /// <value>An array of Intents associated with this bot alias</value>
    [JsonPropertyName("intents")]
    public List<LexV2Intent> Intents { get; set; }



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
        sb.Append("class LexV2BotAlias {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Region: ").Append(Region).Append("\n");
        sb.Append("  AliasId: ").Append(AliasId).Append("\n");
        sb.Append("  Bot: ").Append(Bot).Append("\n");
        sb.Append("  BotVersion: ").Append(BotVersion).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Intents: ").Append(Intents).Append("\n");
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
        return Equals(obj as LexV2BotAlias);
    }

    /// <summary>
    /// Returns true if LexV2BotAlias instances are equal
    /// </summary>
    /// <param name="other">Instance of LexV2BotAlias to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LexV2BotAlias other)
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
                Region == other.Region ||
                Region != null &&
                Region.Equals(other.Region)
            ) &&
            (
                AliasId == other.AliasId ||
                AliasId != null &&
                AliasId.Equals(other.AliasId)
            ) &&
            (
                Bot == other.Bot ||
                Bot != null &&
                Bot.Equals(other.Bot)
            ) &&
            (
                BotVersion == other.BotVersion ||
                BotVersion != null &&
                BotVersion.Equals(other.BotVersion)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Intents == other.Intents ||
                Intents != null &&
                Intents.SequenceEqual(other.Intents)
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

            if (Region != null)
            {
                hash = hash * 59 + Region.GetHashCode();
            }

            if (AliasId != null)
            {
                hash = hash * 59 + AliasId.GetHashCode();
            }

            if (Bot != null)
            {
                hash = hash * 59 + Bot.GetHashCode();
            }

            if (BotVersion != null)
            {
                hash = hash * 59 + BotVersion.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Intents != null)
            {
                hash = hash * 59 + Intents.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
